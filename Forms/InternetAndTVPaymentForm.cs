using BankApp.Classes;
using System.Text.RegularExpressions;

namespace BankApp.Forms
{
    public partial class InternetAndTVPaymentForm : Form
    {
        public InternetAndTVPaymentForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void InternetTvPaymentButton_Click(object sender, EventArgs e)
        {
            var personalAccount = PersonalAccountTextBox.Text;
            var cardNumber = CardNumberLabel.Text;
            var cardCVV = CardCVVLabel.Text;
            var cardDate = CardDateLabel.Text; 
            Decimal sum = Convert.ToDecimal(SumTextBox.Text);

            if (!isCorrectPersonalAccount(personalAccount))
            {
                MessageBox.Show("Пожалуйста, введите корректный номер вашего лицевого счёта", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PersonalAccountTextBox.Select();
                return;
            }

            var cardInfo = BankService.GetBankCardInfo(cardNumber);
            string cardCVVCheck = cardInfo["bank_card_cvv_code"].Trim();
            string cardDateCheck = cardInfo["date"].Trim();
            string cardCurrency = cardInfo["bank_card_currency"].Trim();
            Decimal cardBalanceCheck = Convert.ToDecimal(cardInfo["bank_card_balance"].Trim());

            var error = checkCorrectOptions(
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
                        "Интернет и ТВ", InternetTVServiceComboBox.GetItemText(InternetTVServiceComboBox.SelectedItem),
                        "Internet", sum, cardNumber, personalAccount, DataStorage.idClient
                        );
                    Close();
                }
            }
        }

        private bool isCorrectPersonalAccount(string personalAccount)
        {
            string IsCorrectPersonalAcoount = "^[0-9]{10}$";
            return Regex.IsMatch(personalAccount, IsCorrectPersonalAcoount);
        }

        private bool checkCorrectOptions(string cardCurrency, string cardCVV, string cardCVVCheck,
            string cardDate, string cardDateCheck, Decimal sum, Decimal cardBalanceCheck)
        {
            bool error = false;
            if (CurrencyHelper.GetCurrencyTypeFromString(cardCurrency) != BankOptions.CurrencyByDefault)
            {
                MessageBox.Show($"Оплата может производиться только в {BankOptions.CurrencyByDefault}", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (cardCVV != cardCVVCheck)
            {
                MessageBox.Show("Ошибка. Некорректно введен CVV-код", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (cardDate != cardDateCheck)
            {
                MessageBox.Show("Ошибка. Некорректно введена дата карты", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (sum > cardBalanceCheck)
            {
                MessageBox.Show("Ошибка. Недостаточно средств для совершения операции", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }
            return error;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InternetAndTVPaymentForm_Load(object sender, EventArgs e)
        {
            CardNumberLabel.Text = DataStorage.cardNumber;

            var operators = BankService.GetBankServiceByType("Internet");
            InternetTVServiceComboBox.DataSource = operators;
            InternetTVServiceComboBox.ValueMember = "id_service";
            InternetTVServiceComboBox.DisplayMember = "service_name";
        }

        private void InternetAndTVPaymentForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
