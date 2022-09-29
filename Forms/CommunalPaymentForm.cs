using BankApp.Classes;
using System.Text.RegularExpressions;

namespace BankApp.Forms
{
    public partial class CommunalPaymentForm : Form
    {
        public CommunalPaymentForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CommunalPaymentForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CommunalPaymentForm_Load(object sender, EventArgs e)
        {
            CardNumberLabel.Text = DataStorage.cardNumber;

            var operators = BankService.GetBankServiceByType("Communal");

            CommunalServicesComboBox.DataSource = operators;
            CommunalServicesComboBox.ValueMember = "id_service";
            CommunalServicesComboBox.DisplayMember = "service_name";
        }

        private void CommunalPaymentButton_Click(object sender, EventArgs e)
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

            var error = isCorrectCardOptions(
                cardCurrency, cardCVV, cardCVVCheck, cardDate, cardDateCheck, sum, cardBalanceCheck
                );
            if (error == false)
            {
                DataStorage.bankCard = CardNumberLabel.Text;

                ValidationForm validation = new ();
                validation.ShowDialog();

                if (DataStorage.attempts > 0)
                {
                    BankService.MakeTransactionToBankService(
                        "Коммунальные услуги", CommunalServicesComboBox.GetItemText(CommunalServicesComboBox.SelectedItem),
                        "Communal", sum, cardNumber, personalAccount, DataStorage.idClient
                        );
                    Close();
                }
            }
        }

        private bool isCorrectPersonalAccount(string personalAccount)
        {
            const string IsCorrectPersonalAccountRegex = "^[0-9]{10}$";
            return Regex.IsMatch(personalAccount, IsCorrectPersonalAccountRegex);
        }

        private bool isCorrectCardOptions(string cardCurrency, string cardCVV, string cardCVVCheck,
            string cardDate, string cardDateCheck, Decimal sum, Decimal cardBalanceCheck)
        {
            var btn = MessageBoxButtons.OK;
            var ico = MessageBoxIcon.Information;
            bool error = false;

            if (CurrencyHelper.GetCurrencyTypeFromString(cardCurrency) != BankOptions.CurrencyByDefault)
            {
                MessageBox.Show($"Пополнение может происходить только в {BankOptions.CurrencyByDefault}", "Отмена", btn, ico);
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
                MessageBox.Show("Ошибка. Минимальная сумма пополнения 1 р.", "Отмена", btn, ico);
                error = true;
            }

            if (sum > cardBalanceCheck)
            {
                MessageBox.Show("Ошибка. Недостаточно средств для совершения операции", "Отмена", btn, ico);
                error = true;
            }
            return error;
        }
    }
}
