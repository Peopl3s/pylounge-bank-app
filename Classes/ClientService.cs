using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace BankApp.Classes
{
    public static class ClientService
    {
        private static DataBaseConnection connector = new(
            ConnectionFactory.getConnection(ConnectionFactory.getProviderType(ConfigurationManager.ConnectionStrings["DefaultConnection"].ProviderName),
            ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
            );

        public static DataBaseConnection Connector { get => connector; set => connector = value; }
        public static int ChangeEmail(string email, string idClient)
        {
            var queryChangeEmail = @"UPDATE clients SET client_email = ? 
                                     WHERE id_client = ?";
            OleDbCommand commandChangeEmail = new OleDbCommand(queryChangeEmail, (OleDbConnection)Connector.GetConnection());
            commandChangeEmail.Parameters.AddRange(new[]
            {
                new OleDbParameter("@email", OleDbType.VarChar) { Value = email},
                new OleDbParameter("@idClient", OleDbType.VarChar) { Value = idClient}
            });

            Connector.OpenConnection();
            int affectedRows = commandChangeEmail.ExecuteNonQuery();
            Connector.CloseConnection();

            return affectedRows;
        }

        public static int ChangePassword(string password, string idClient)
        {

            var queryChangePassword = @"UPDATE clients SET client_password = ? 
                                        WHERE id_client = 
                                        (SELECT id_client FROM clients WHERE id_client = ?)";
            OleDbCommand commandChangePassword = new OleDbCommand(queryChangePassword, (OleDbConnection)Connector.GetConnection());
            commandChangePassword.Parameters.AddRange(new[]
            {
                new OleDbParameter("@password", OleDbType.VarChar) { Value = password},
                new OleDbParameter("@idClient", OleDbType.VarChar) { Value = idClient}
            });

            Connector.OpenConnection();
            int affectedRows = commandChangePassword.ExecuteNonQuery();
            Connector.CloseConnection();

            return affectedRows;
        }

        public static int ChangePhoneNumber(string phoneNumber, string idClient)
        {
            var queryChangePhoneNumber = @"UPDATE clients SET client_phone_number = ? 
                                           WHERE id_client = ?";
            OleDbCommand commandChangePhoneNumber = new OleDbCommand(queryChangePhoneNumber, (OleDbConnection)Connector.GetConnection());
            commandChangePhoneNumber.Parameters.AddRange(new[]
            {
                new OleDbParameter("@phoneNumber", OleDbType.VarChar) { Value = phoneNumber},
                new OleDbParameter("@idClient", OleDbType.VarChar) { Value = idClient}
            });

            Connector.OpenConnection();
            int affectedRows = commandChangePhoneNumber.ExecuteNonQuery();
            Connector.CloseConnection();

            return affectedRows;
        }

        public static Dictionary<string, string> GetClientInfo(string idClient)
        {
            Dictionary<string, string> clientInfo = new ();
            var querySNM = @"SELECT CONCAT(client_last_name, ' ', client_first_name, ' ', client_middle_name) as snm, 
                             client_phone_number, client_email FROM clients WHERE id_client = ?";
            OleDbCommand commandGetSNM = new OleDbCommand(querySNM, (OleDbConnection)Connector.GetConnection());
            commandGetSNM.Parameters.Add(new OleDbParameter("@idClient", OleDbType.VarChar) { Value = idClient });

            Connector.OpenConnection();
            using (OleDbDataReader reader = commandGetSNM.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        clientInfo["snm"] = reader["snm"].ToString();
                        clientInfo["client_phone_number"] = reader["client_phone_number"].ToString();
                        clientInfo["client_email"] = reader["client_email"].ToString();
                    }
                }
            }
            Connector.CloseConnection();
            return clientInfo;
        }

        public static Dictionary<string, string> GetClientTransactionHistory(string idClient)
        {
            Dictionary<string, string> transactionHisory = new();
            var querySelectTransactions = @"SELECT transaction_type, transaction_destination, transaction_date, 
                                            transaction_number, transaction_value 
                                            FROM transactions INNER JOIN bank_cards ON transactions.id_bank_card = bank_cards.id_bank_card 
                                            INNER JOIN clients ON clients.id_client = bank_cards.id_client 
                                            WHERE clients.id_client = ?";
            OleDbCommand commandSelectTransactions = new OleDbCommand(querySelectTransactions, (OleDbConnection)Connector.GetConnection());
            commandSelectTransactions.Parameters.Add(new OleDbParameter("@idClient", OleDbType.VarChar) { Value = idClient });

            Connector.OpenConnection();
            using (OleDbDataReader reader = commandSelectTransactions.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        transactionHisory["transaction_type"] = reader["transaction_type"].ToString();
                        transactionHisory["transaction_destination"] = reader["transaction_destination"].ToString();
                        transactionHisory["transaction_date"] = reader["transaction_date"].ToString();
                        transactionHisory["transaction_number"] = reader["transaction_number"].ToString();
                        transactionHisory["transaction_value"] = reader["transaction_value"].ToString();
                    }
                }
            }
            Connector.CloseConnection();
            return transactionHisory;
        }

        public static bool IsClientAleadyCreated(string phoneNumber)
        {
            string queryGetPhone = @"SELECT client_phone_number 
                                     FROM clients 
                                     WHERE client_phone_number = ?";
            OleDbCommand commandGetPhone = new OleDbCommand(queryGetPhone, (OleDbConnection)Connector.GetConnection());
            commandGetPhone.Parameters.Add(new OleDbParameter("@clientPhoneNumber", OleDbType.VarChar) { Value = phoneNumber });

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = commandGetPhone;
            adapter.Fill(table);

            return table.Rows.Count > 0;
        }

        public static int SaveClient(string firstName, string lastName, string middleName,
            string gender, string password, string email, string phoneNumber)
        {
            string queryInsertClient = @"INSERT INTO clients(client_first_name, client_last_name, client_middle_name, 
                                         client_gender, client_password, client_email, client_phone_number) 
                                         VALUES(?, ?, ?, ?, ?, ?, ?)";

            Connector.OpenConnection();

            OleDbCommand commandAddNewUser = new OleDbCommand(queryInsertClient, (OleDbConnection)Connector.GetConnection());
            commandAddNewUser.Parameters.AddRange(new[]
            {
                    new OleDbParameter("@first_name", OleDbType.VarChar){ Value = firstName},
                    new OleDbParameter("@last_name", OleDbType.VarChar){ Value = lastName},
                    new OleDbParameter("@middle_name", OleDbType.VarChar){ Value = middleName},
                    new OleDbParameter("@gender", OleDbType.VarChar){ Value = gender },
                    new OleDbParameter("@password", OleDbType.VarChar){ Value = password },
                    new OleDbParameter("@email", OleDbType.VarChar){ Value = email },
                    new OleDbParameter("@phoneNumber", OleDbType.VarChar){ Value = phoneNumber }
                });

            int countAffectedRows = commandAddNewUser.ExecuteNonQuery();

            Connector.CloseConnection();

            return countAffectedRows;
        }

        public static (bool, string) SignIn(string phoneNumber, string password)
        {
            string querySelectClient = @"SELECT * FROM clients  
                                         WHERE client_phone_number = ? 
                                         AND client_password = ?";

            string queryGetId = "SELECT id_client FROM clients WHERE client_phone_number = ?";

            OleDbCommand commandGetId = new OleDbCommand(queryGetId, (OleDbConnection)Connector.GetConnection());
            commandGetId.Parameters.Add(new OleDbParameter("@clientPhoneNumber", OleDbType.VarChar) { Value = phoneNumber });

            Connector.OpenConnection();
            string idClient = string.Empty;
            using (OleDbDataReader reader = commandGetId.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idClient = reader["id_client"].ToString();
                    }
                }
            }

            OleDbCommand commandSelectClient = new OleDbCommand(querySelectClient, (OleDbConnection)Connector.GetConnection());
            commandSelectClient.Parameters.AddRange(new[] {
                    new OleDbParameter("@clientPhoneNumber", OleDbType.VarChar) { Value =  phoneNumber },
                    new OleDbParameter("@clientPassword", OleDbType.VarChar) { Value =  password }
                });

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = commandSelectClient;
            adapter.Fill(table);

            Connector.CloseConnection();

            return (table.Rows.Count > 0, idClient);
        }
    }
}
