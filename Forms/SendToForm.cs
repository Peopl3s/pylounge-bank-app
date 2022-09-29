using BankApp.Classes;

namespace BankApp.Forms
{
    public partial class SendToForm : Form
    {
        public SendToForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TransferButton_Click(object sender, EventArgs e)
        {
            var cardNumber = FromCardNumberTextBox.Text;
            var cardCVV = FromCardCvvCodeTextBox.Text;
            var cardDate = FromCardDateTextBox.Text;
            var destinationCard = ToCardNumberTextBox.Text;
            Decimal sum = Convert.ToDecimal(TransferAmountTextBox.Text);

            var bankCardInfo = BankService.GetBankCardInfo(cardNumber);
            
            var cardCVVCheck = bankCardInfo["bank_card_cvv_code"];
            var cardDateCheck = bankCardInfo["date"];
            var cardBalanceCheck = Convert.ToDecimal(bankCardInfo["bank_card_balance"]);
            var cardCurrency = bankCardInfo["bank_card_currency"];
             
            var destinationCardInfo = BankService.GetBankCardInfo(destinationCard);
            var cardCurrency2 = destinationCardInfo["bank_card_currency"];

            var error = isCorrectCardOptions(
                cardCurrency, cardCVV, cardCVVCheck, cardDate, cardDateCheck, sum, cardBalanceCheck
                );
            if (error == false)
            {
                DataStorage.bankCard = FromCardNumberTextBox.Text;

                ValidationForm validation = new ValidationForm();
                validation.ShowDialog();
            }

            if (DataStorage.attempts > 0)
            {
                var (_, commissionSum) = CurrencyHelper.CalculateCurrencyTransfer(cardCurrency, cardCurrency2, sum);
                sum += commissionSum;

                BankService.MakeTransactionToBankService("Перевод", destinationCard,
                        "Transfer", sum, cardNumber, null, DataStorage.idClient);

                Close();
            }
        }

        private bool isCorrectCardOptions(string cardCurrency, string cardCVV, string cardCVVCheck,
            string cardDate, string cardDateCheck, Decimal sum, Decimal cardBalanceCheck)
        {
            bool error = false;
            var btn = MessageBoxButtons.OK;
            var ico = MessageBoxIcon.Information;

            if (CurrencyHelper.GetCurrencyTypeFromString(cardCurrency) != BankOptions.CurrencyByDefault)
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

        private void SendToForm_MouseDown(object sender, MouseEventArgs e)
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

        private void SendToForm_Load(object sender, EventArgs e)
        {
            ToCardNumberTextBox.Text = DataStorage.bankCard;
            FromCardNumberTextBox.Text = DataStorage.cardNumber;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
