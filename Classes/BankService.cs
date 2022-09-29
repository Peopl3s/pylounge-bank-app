using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace BankApp.Classes
{
    public static class BankService
    {
        private static DataBaseConnection connector = new (
            ConnectionFactory.getConnection(ConnectionFactory.getProviderType(ConfigurationManager.ConnectionStrings["DefaultConnection"].ProviderName),
            ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
            );

        public static DataBaseConnection Connector { get => connector; set => connector = value; }

        public static int CreateNewCard(string cardPaymentSystem, string cardType,
            string cardCurrency, Decimal cardPinCode, string idClient)
        {
            var cvvCode = string.Empty;
            var cardNumber = string.Empty;
            bool isCardFree = false;

            DateTime createCardDateTime = DateTime.Now;
            var cardDate = createCardDateTime.AddYears(BankOptions.CardValidityPeriodYears);

            do
            {
                cvvCode = BankOptions.GenerateCvvCode();
                cardNumber = BankOptions.GenerateCardNumber(cardPaymentSystem);

                var queryCheckCardNumber = @"SELECT * FROM bank_cards 
                                             WHERE bank_card_number = ?";

                OleDbCommand selectCardCommand = new OleDbCommand(queryCheckCardNumber, (OleDbConnection)Connector.GetConnection());
                selectCardCommand.Parameters.Add(new OleDbParameter("cardNumber", OleDbType.VarChar) { Value = cardNumber });

                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = selectCardCommand;

                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    isCardFree = true;
                }

            } while (isCardFree == false);

            var queryAddNewCard = @"INSERT INTO bank_cards(bank_card_type, bank_card_number, bank_card_cvv_code, 
                                 bank_card_currency, bank_card_payment_system, bank_card_date, 
                                 id_client, bank_card_pin) 
                                 VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbCommand addNewCardCommand = new OleDbCommand(queryAddNewCard, (OleDbConnection)Connector.GetConnection());
            addNewCardCommand.Parameters.AddRange(new[]
            {
            new OleDbParameter("@cardType", OleDbType.VarChar){ Value = cardType },
            new OleDbParameter("@cardNumber", OleDbType.VarChar){ Value = cardNumber },
            new OleDbParameter("@cvvCode", OleDbType.VarChar){ Value = cvvCode },
            new OleDbParameter("@cardCurrency", OleDbType.VarChar) { Value = cardCurrency },
            new OleDbParameter("@cardPaymentSystem", OleDbType.VarChar){ Value = cardPaymentSystem },
            new OleDbParameter("@cardDate", OleDbType.Date){ Value = cardDate },
            new OleDbParameter("@idClient", OleDbType.Integer){ Value = idClient },
            new OleDbParameter("@cardPinCode", OleDbType.Integer){ Value = cardPinCode }
        });

            Connector.OpenConnection();

            int countAffectedRows = addNewCardCommand.ExecuteNonQuery();

            Connector.CloseConnection();

            return countAffectedRows;
        }

        public static DataTable GetBankServiceByType(string serviceType)
        {
            var queryChooseOperator = @"SELECT id_service, service_name 
                                        FROM client_services 
                                        WHERE service_type = ?";
            OleDbCommand commandChooseOperator = new OleDbCommand(queryChooseOperator, (OleDbConnection)Connector.GetConnection());
            commandChooseOperator.Parameters.Add(new OleDbParameter("@serviceType", OleDbType.VarChar) { Value = serviceType });

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = commandChooseOperator;
            DataTable operators = new();

            Connector.OpenConnection();

            adapter.Fill(operators);

            Connector.CloseConnection();

            return operators;
        }

        public static Dictionary<string, string> GetBankCardInfo(string cardNumber)
        {
            Dictionary<string, string> cardInfo = new ();
            var queryCheckCard = @"SELECT id_bank_card, bank_card_cvv_code, 
                                   CONCAT(FORMAT(bank_card_date, '%M'), '/', FORMAT(bank_card_date, '%y')) AS date, 
                                   bank_card_balance, bank_card_currency, bank_card_payment_system, bank_card_number
                                   FROM bank_cards 
                                   WHERE bank_card_number = ?";
            OleDbCommand commandCheckCard = new OleDbCommand(queryCheckCard, (OleDbConnection)Connector.GetConnection());
            commandCheckCard.Parameters.Add(new OleDbParameter("@cardNumber", OleDbType.VarChar) { Value = cardNumber });

            Connector.OpenConnection();
            using (OleDbDataReader reader = commandCheckCard.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cardInfo["bank_card_cvv_code"] = reader["bank_card_cvv_code"].ToString();
                        cardInfo["date"] = reader["date"].ToString();
                        cardInfo["bank_card_balance"] = Math.Round(Convert.ToDecimal(reader["bank_card_balance"]), 2).ToString();
                        cardInfo["bank_card_currency"] = reader["bank_card_currency"].ToString();
                        cardInfo["bank_card_payment_system"] = reader["bank_card_payment_system"].ToString();
                        cardInfo["id_bank_card"] = reader["id_bank_card"].ToString();
                        cardInfo["bank_card_number"] = cardNumber;
                    }
                }
                else return cardInfo;
            }
            Connector.CloseConnection();
            return cardInfo;
        }

        public static void MakeTransactionToBankService(string transactionName, string transactionDestination, 
            string serviceType, Decimal sum, string cardNumber, string personalAccount, string idClient)
        {
            var (transactionNumber, transactionDate) = TransactionHelper.GenerateTransactionDateNumber();

            var queryUpdateBalance = @"UPDATE bank_cards SET bank_card_balance = bank_card_balance - ? 
                                       WHERE bank_card_number = ?";
            OleDbCommand commandUpdateBalance = new OleDbCommand(queryUpdateBalance, (OleDbConnection)Connector.GetConnection());
            commandUpdateBalance.Parameters.AddRange(new[]
            {
                new OleDbParameter("@sum", OleDbType.Decimal) { Value = sum},
                new OleDbParameter("@cardNumber", OleDbType.VarChar) { Value = cardNumber}
             });

            var queryAddTransaction = @"INSERT INTO transactions(transaction_type, transaction_destination, 
                                        transaction_date, transaction_number, transaction_value, id_bank_card) 
                                        VALUES (?, ?, ?, ?, ?, 
                                        (SELECT id_bank_card FROM bank_cards WHERE bank_card_number = ?));";
            OleDbCommand commandAddTransaction = new OleDbCommand(queryAddTransaction, (OleDbConnection)Connector.GetConnection());
            commandAddTransaction.Parameters.AddRange(new[]
            {
                        new OleDbParameter("@transactionName", OleDbType.VarChar) { Value = transactionName },
                        new OleDbParameter("@transactionDestination", OleDbType.VarChar) { Value = transactionDestination },
                        new OleDbParameter("@transactionDate", OleDbType.Date) { Value = transactionDate},
                        new OleDbParameter("@transactionNumber", OleDbType.VarChar) { Value = transactionNumber},
                        new OleDbParameter("@sum", OleDbType.Decimal) { Value = sum},
                        new OleDbParameter("@cardNumber", OleDbType.VarChar) { Value = cardNumber}
            });

            var queryUpdateServiceBalance = @"UPDATE client_services SET service_balance = service_balance + ?
                                              WHERE service_name = ? 
                                              AND service_type = ?";
            OleDbCommand commandUpdateServiceBalance = new OleDbCommand(queryUpdateServiceBalance, (OleDbConnection)Connector.GetConnection());
            commandUpdateServiceBalance.Parameters.AddRange(new[]
            {
                new OleDbParameter("@sum", OleDbType.Decimal) { Value = sum },
                new OleDbParameter("@serviceName", OleDbType.VarChar) { Value = transactionDestination },
                new OleDbParameter("@serviceType", OleDbType.Decimal) { Value = serviceType }
            });

            OleDbCommand? commandAddPersonalAccountInfo = null;
            if (!string.IsNullOrEmpty(personalAccount))
            {
                var queryAddPersonalAccountInfo = @"INSERT INTO client_personal_accounts(personal_account, id_service, id_client)
                                                VALUES (?, 
                                                (SELECT id_service FROM client_services WHERE service_name = ?), ?);";
                commandAddPersonalAccountInfo = new OleDbCommand(queryAddPersonalAccountInfo, (OleDbConnection)Connector.GetConnection());
                commandAddPersonalAccountInfo.Parameters.AddRange(new[]
                {
                new OleDbParameter("@personalAccount", OleDbType.VarChar) { Value = personalAccount },
                new OleDbParameter("@serviceName", OleDbType.VarChar) { Value = transactionDestination },
                new OleDbParameter("@idClient", OleDbType.VarChar) { Value = idClient }
            });
            }

            Connector.OpenConnection();

            TransactionHelper.MakeTransaction(Connector.GetConnection(), new List<IDbCommand>{
                        commandUpdateBalance,  commandAddTransaction,
                        commandUpdateServiceBalance, commandAddPersonalAccountInfo
                    });

            Connector.CloseConnection();
        }

        public static Dictionary<string, string> GetCreditInfo(string cardNumber)
        {
            Dictionary<string, string> creditInfo = new ();

            var queryCheckCreditStatus = @"SELECT credits.id_bank_card, credits.credit_total_sum, credits.credit_sum, 
                                        credits.credit_date, credits.id_credit, credits.repayment_date, credits.repayment_sum
                                        FROM credits 
                                        INNER JOIN bank_cards 
                                        ON credits.id_bank_card = bank_cards.id_bank_card 
                                        WHERE bank_cards.id_bank_card = 
                                        (SELECT id_bank_card FROM bank_cards WHERE bank_card_number = ?)";
            OleDbCommand commandCheckCreditStatus = new OleDbCommand(queryCheckCreditStatus, (OleDbConnection)Connector.GetConnection());
            commandCheckCreditStatus.Parameters.Add(new OleDbParameter("@cardNumber", OleDbType.VarChar) { Value = cardNumber });

            Connector.OpenConnection();
            using (OleDbDataReader reader = commandCheckCreditStatus.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        creditInfo["id_bank_card"] = reader["id_bank_card"].ToString();
                        creditInfo["credit_total_sum"] = reader["credit_total_sum"].ToString();
                        creditInfo["credit_sum"] = reader["credit_sum"].ToString();
                        creditInfo["credit_date"] = reader["credit_date"].ToString();
                        creditInfo["id_credit"] = reader["id_credit"].ToString();
                        creditInfo["repayment_date"] = reader["repayment_date"].ToString();
                        creditInfo["repayment_sum"] = reader["repayment_sum"].ToString();
                    }
                }
            }
            Connector.CloseConnection();
            return creditInfo;
        }

        public static void CloseCredit(string cardNumber)
        {
            var queryDeleteCredit = @"DELETE FROM credits WHERE id_bank_card = 
                                      (SELECT id_bank_card FROM bank_cards WHERE bank_card_number = ?);";
            OleDbCommand commandDeleteCredit = new OleDbCommand(queryDeleteCredit, (OleDbConnection)Connector.GetConnection());
            commandDeleteCredit.Parameters.Add(new OleDbParameter("@cardNumber", OleDbType.VarChar) { Value = cardNumber });
            commandDeleteCredit.ExecuteNonQuery();
        }

        public static int GetBankCardPinCode(string bankCard)
        {
            int pin = 0;
            var queryCheckPin = @"SELECT bank_card_pin FROM bank_cards WHERE bank_card_number = ?";
            OleDbCommand commandCheckPin = new OleDbCommand(queryCheckPin, (OleDbConnection)Connector.GetConnection());
            commandCheckPin.Parameters.Add(new OleDbParameter("@bankCard", OleDbType.VarChar) { Value = bankCard });

            Connector.OpenConnection();
            using (OleDbDataReader reader = commandCheckPin.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pin = Convert.ToInt32(reader["bank_card_pin"]);
                    }
                }
            }
            Connector.CloseConnection();
            return pin;
        }

        public static Dictionary<string, string> GetRepaymentCreditInfo(string idCredit)
        {
            Dictionary<string, string> repaymentInfo = new();

            var querySelectRepayment = @"SELECT repayment_date, repayment_sum 
                                         FROM credits 
                                         WHERE id_credit = ?";
            OleDbCommand commandSelectRepayment = new OleDbCommand(querySelectRepayment, (OleDbConnection)Connector.GetConnection());
            commandSelectRepayment.Parameters.Add(new OleDbParameter("idCredit", OleDbType.VarChar) { Value = idCredit });
            
            Connector.OpenConnection();
            using (OleDbDataReader reader = commandSelectRepayment.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        repaymentInfo["repayment_date"] = reader["repayment_date"].ToString();
                        repaymentInfo["repayment_sum"] = reader["repayment_sum"].ToString();
                    }
                }
            }
            Connector.CloseConnection();
            return repaymentInfo;
        }

        public static Decimal CalculateCredit(Decimal sum, int numberOfMonths)
        {
            return sum * Convert.ToDecimal(BankOptions.CreditMonthlyRate + (BankOptions.CreditMonthlyRate
                / (Decimal)(Math.Pow(1 + Convert.ToDouble(BankOptions.CreditMonthlyRate), numberOfMonths) - 1)));
        }

        public static string OpenCredit(string cardNumber, Decimal totalSum, DateTime creditDate)
        {
            var queryCredit = @"INSERT INTO credits(credit_total_sum, credit_sum, credit_date, id_bank_card) 
                                VALUES (?, 0, ?, 
                                (SELECT id_bank_card FROM bank_cards WHERE bank_card_number = ?));";
            OleDbCommand commandCreateCredit = new OleDbCommand(queryCredit, (OleDbConnection)Connector.GetConnection());
            commandCreateCredit.Parameters.AddRange(new[]
            {
                    new OleDbParameter("@totalSum", OleDbType.Decimal){ Value = totalSum},
                    new OleDbParameter("@creditDate", OleDbType.Date){ Value = creditDate},
                    new OleDbParameter("@cardNumber", OleDbType.VarChar){ Value = cardNumber}
                });


            Connector.OpenConnection();

            commandCreateCredit.ExecuteNonQuery();

            var idCredit = string.Empty;

            var querySelectId = @"SELECT id_credit 
                                  FROM credits 
                                  WHERE id_bank_card = 
                                  (SELECT id_bank_card FROM bank_cards WHERE bank_card_number = ?)";
            OleDbCommand commandSelectIdCredit = new OleDbCommand(querySelectId, (OleDbConnection)Connector.GetConnection());
            commandSelectIdCredit.Parameters.Add(new OleDbParameter("@cardNumber", SqlDbType.NVarChar) { Value = DataStorage.cardNumber });

            using (OleDbDataReader reader = commandSelectIdCredit.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idCredit = reader["id_credit"].ToString();
                    }
                }
            }
            Connector.CloseConnection();
            return idCredit;
        }

        public static void UpdateCreditRepayment(string cardNumber, string idCredit, 
            DateTime repaymentDate, string payment)
        {
            var queryRepayment = @"UPDATE credits SET repayment_date = ?, repayment_sum = ?
                                   WHERE id_credit = ?";
            OleDbCommand commandRepayment = new OleDbCommand(queryRepayment, (OleDbConnection)Connector.GetConnection());
            commandRepayment.Parameters.AddRange(new[]
            {
                    new OleDbParameter("@repaymentDate", OleDbType.Date){ Value = repaymentDate},
                    new OleDbParameter("@payment", OleDbType.VarChar){ Value = payment },
                    new OleDbParameter("@idCredit", OleDbType.VarChar){ Value = idCredit}
                });

            var queryCardUpdate = @"UPDATE bank_cards SET bank_card_balance = bank_card_balance + ?
                                    WHERE bank_card_number = ?";
            OleDbCommand commandCardUpdate = new OleDbCommand(queryCardUpdate, (OleDbConnection)Connector.GetConnection());
            commandCardUpdate.Parameters.AddRange(new[]
            {
                    new OleDbParameter("@pay", OleDbType.VarChar){ Value = payment},
                    new OleDbParameter("@cardNumber", OleDbType.VarChar){ Value = cardNumber }
            });
            connector.OpenConnection();
            TransactionHelper.MakeTransaction(Connector.GetConnection(), new List<IDbCommand> { commandRepayment, commandCardUpdate });
            connector.CloseConnection();
        }

        public static DataTable GetAllCards(string idClient)
        {
            var queryMyCards = @"SELECT id_bank_card, bank_card_number 
                                 FROM bank_cards 
                                 WHERE id_client = ?";

            OleDbDataAdapter commandMyCards = new OleDbDataAdapter(queryMyCards, (OleDbConnection)Connector.GetConnection());
            commandMyCards.SelectCommand.Parameters.Add(new OleDbParameter
            {
                ParameterName = "@idClient",
                Value = idClient,
                OleDbType = OleDbType.VarChar
            });
            DataTable cards = new DataTable();

            Connector.OpenConnection();

            commandMyCards.Fill(cards);

            Connector.CloseConnection();

            return cards;
        }

        public static string GetCardCurrency(string cardNumber)
        {
            var cardCurrency = string.Empty;
            var queryCheckCurrency = @"SELECT bank_card_currency 
                                       FROM bank_cards 
                                       WHERE bank_card_number = ?";
            OleDbCommand commandCheckCurrency = new OleDbCommand(queryCheckCurrency,
                                                            (OleDbConnection)Connector.GetConnection());
            commandCheckCurrency.Parameters.Add(new OleDbParameter
            {
                ParameterName = "@cardNumber",
                Value = cardNumber,
                OleDbType = OleDbType.VarChar
            });

            Connector.OpenConnection();

            using (OleDbDataReader reader = commandCheckCurrency.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cardCurrency = reader["bank_card_currency"].ToString();
                    }
                }
            }
            Connector.CloseConnection();

            return cardCurrency.Trim();
        }

        public static void MakeRepaymentCreditService(DateTime toPayDate, string sumToPay, string cardNumber)
        {
            MessageBox.Show(toPayDate + sumToPay + cardNumber);
            var (transactionNumber, transactionDate) = TransactionHelper.GenerateTransactionDateNumber();

            var queryPayCredit = @"UPDATE credits SET repayment_date = ?, credit_sum = credit_sum + repayment_sum 
                                   WHERE id_bank_card = 
                                   (SELECT id_bank_card FROM bank_cards WHERE bank_card_number = ?)";

            var queryPay = @"UPDATE bank_cards SET bank_card_balance = bank_card_balance - ? 
                             WHERE bank_card_number = ?";

            var queryTransaction = @"INSERT INTO transactions(transaction_type,transaction_destination, transaction_date, 
                                     transaction_number, transaction_value, id_bank_card) 
                                     VALUES('Кредит', 'Погашение кредита', ?, ?, ?, 
                                     (SELECT id_bank_card FROM bank_cards 
                                     WHERE bank_card_number = ?))";

            OleDbCommand commandPayCredit = new OleDbCommand(queryPayCredit, (OleDbConnection)Connector.GetConnection());
            commandPayCredit.Parameters.AddRange(new[]
            {
                        new OleDbParameter("@toPayDate", OleDbType.Date){ Value = toPayDate},
                        new OleDbParameter("@cardNumber", OleDbType.VarChar){ Value = cardNumber}
                    });

            OleDbCommand commandPay = new OleDbCommand(queryPay, (OleDbConnection)Connector.GetConnection());
            commandPay.Parameters.AddRange(new[]
            {
                        new OleDbParameter("@sumToPay", OleDbType.VarChar){ Value = sumToPay},
                        new OleDbParameter("@cardNumber", OleDbType.VarChar){ Value = cardNumber}
            });

            OleDbCommand commandAddTransaction = new OleDbCommand(queryTransaction, (OleDbConnection)Connector.GetConnection());
            commandAddTransaction.Parameters.AddRange(new[]
            {
                        new OleDbParameter("@transactionDate", OleDbType.Date){ Value = transactionDate},
                        new OleDbParameter("@transactionNumber", OleDbType.VarChar){ Value = transactionNumber},
                        new OleDbParameter("@sumToPay", OleDbType.VarChar){ Value = sumToPay},
                        new OleDbParameter("@cardNumber", OleDbType.VarChar){ Value = cardNumber}
             });
            connector.OpenConnection();
            TransactionHelper.MakeTransaction(Connector.GetConnection(), new List<IDbCommand> {
                        commandPayCredit, commandPay, commandAddTransaction
                    });
            connector.CloseConnection();
        }

    }
}
