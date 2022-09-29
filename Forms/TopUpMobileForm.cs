using BankApp.Classes;
using System.Text.RegularExpressions;


namespace BankApp.Forms
{
    public partial class TopUpMobileForm : Form
    {
        public TopUpMobileForm()
        {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TopUpMobileForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void ToUpAccountButton_Click(object sender, EventArgs e)
        {
            string phoneNumber = TopUpMobileTextBox.Text;
            string phoneNumberToCheck = String.Concat(phoneNumber[0], phoneNumber[1], phoneNumber[2]);
            string selectedOperator = OperatorsComboBox.GetItemText(OperatorsComboBox.SelectedItem);

            bool numberCheck = isCorrectMobileOperator(selectedOperator, phoneNumberToCheck);
            if (numberCheck == true)
            {
               MessageBox.Show("Введите корректные данные", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (numberCheck == false)
            {
                phoneNumber = TopUpMobileTextBox.Text;
                var cardNumber = CardNumberLabel.Text;
                var cardCVV = CardCVVLabel.Text;
                var cardDate = CardDateLabel.Text;

                Decimal sum = Convert.ToDecimal(SumTextBox.Text);
                Decimal commission = ((Convert.ToDecimal(sum) * BankOptions.CommissionCoefficient) / 100);
                Decimal totalSum = commission + sum;

                if (!isCorrectPhoneNumber(phoneNumber))
                {
                    MessageBox.Show("Пожалуйста, введите номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TopUpMobileTextBox.Select();
                    return;
                }

                var cardInfo = BankService.GetBankCardInfo(cardNumber);
                string cardCVVCheck = cardInfo["bank_card_cvv_code"].Trim();
                string cardDateCheck = cardInfo["date"].Trim();
                string cardCurrency = cardInfo["bank_card_currency"].Trim();
                Decimal cardBalanceCheck = Convert.ToDecimal(cardInfo["bank_card_balance"].Trim());

                var error = isCorrectCardOptions(
                    cardCurrency, cardCVV, cardCVVCheck, cardDate, cardDateCheck, sum, cardBalanceCheck
                    );
                if (error == false)
                {
                    DataStorage.bankCard = CardNumberLabel.Text;
                    
                    ValidationForm validation = new ValidationForm();
                    validation.ShowDialog();

                    if (DataStorage.attempts > 0)
                    {
                        BankService.MakeTransactionToBankService(
                            "Пополнение мобильного", $"+7{phoneNumber}",
                            "Mobile", sum, cardNumber, "", DataStorage.idClient
                            );
                            Close();
                        }
                    }
            }
        }

        private bool isCorrectPhoneNumber(string phoneNumber)
        {
            const string IsPhoneNumberRegex = "^[0-9]{10}$";
            return Regex.IsMatch(TopUpMobileTextBox.Text, IsPhoneNumberRegex);
        }

        private bool isCorrectMobileOperator(string selectedOperator, string phoneNumberToCheck)
        {
            bool numberCheck = false;

            Dictionary<string, List<string>> operatorsCode = new ()
            {
                {"MTC", new List<string> {"915", "919", "910"} },
                {"MegaFon", new List<string> { "920", "921", "902" } },
                {"Beeline", new List<string> { "908", "960", "906" } },
                {"Tele2", new List<string> { "968", "980", "981" } },
                {"Yota", new List<string> { "999", "998", "991" } },
                {"Ростелеком", new List<string> { "900", "901", "911" } }
            };

            if (operatorsCode.ContainsKey(selectedOperator))
            {
                var codes = operatorsCode[selectedOperator];
                if (codes.Contains(phoneNumberToCheck))
                {
                    numberCheck = true;
                }
            } 
            else numberCheck = true;

            return numberCheck;
        }

        private bool isCorrectCardOptions(string cardCurrency, string cardCVV, string cardCVVCheck, 
            string cardDate, string cardDateCheck, Decimal sum, Decimal cardBalanceCheck)
        {
            bool error = false;
            var btn = MessageBoxButtons.OK;
            var ico = MessageBoxIcon.Information;

            if (cardCurrency != "RUB")
            {
                MessageBox.Show($"Пополнение мобильного может происходить только в {BankOptions.CurrencyByDefault}", "Отмена", btn, ico);
                error = true;
            }

            if (cardCVV != cardCVVCheck)
            {
                MessageBox.Show("Ошибка. Некорректно введен CVV-код", "Отмена", btn, ico);
                error = true;
            }

            if (cardDate != cardDateCheck)
            {
                MessageBox.Show("Ошибка. Некорректно введена дата карты", "Отмена", btn, ico);
                error = true;
            }

            if (Convert.ToDecimal(sum) < 1.00m)
            {
                MessageBox.Show("Ошибка. Минимальная сумма пополнения 1", "Отмена", btn, ico);
                error = true;
            }

            if (sum > cardBalanceCheck)
            {
                MessageBox.Show("Ошибка. Недостаточно средств для совершения операции", "Отмена", btn, ico);
                error = true;
            }
            return error;
        }

        private void TopUpMobileForm_Load(object sender, EventArgs e)
        {
            TopUpMobileTextBox.Text = DataStorage.phoneNumber;
            CardNumberLabel.Text = DataStorage.cardNumber;

            var operators = BankService.GetBankServiceByType("Mobile");
            OperatorsComboBox.DataSource = operators;
            OperatorsComboBox.ValueMember = "id_service";
            OperatorsComboBox.DisplayMember = "service_name";
        }

        private void SumTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SumTextBox.Text)) 
            {
                SumTextBox.Text = string.Empty;
                ComissionLabel.Text = "0";
                ToBePaidLabel.Text = "0";
            }
            else
            {
                Decimal sum = Convert.ToDecimal(SumTextBox.Text);
                ComissionLabel.Text = Convert.ToString((sum * BankOptions.CommissionCoefficient) / 100);
                ToBePaidLabel.Text = Convert.ToString(((sum * 100) / 100) + sum);
            }
        }
    }
}
