using BankApp.Classes;

namespace BankApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
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

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            AddBankCardForm addBankCardForm = new AddBankCardForm();
            addBankCardForm.ShowDialog();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            HiddenCardNumberLabel.BringToFront();
            HiddenCardCvvLabel.BringToFront();
            HiddenCardCvvNumberLabel.BringToFront();
            HiddenCardValidUntilDateLabel.BringToFront();
            HiddenCardValidUntilLabel.BringToFront();

            HiddenCardNumberLabel.Text = String.Empty;
            CardMasterCardPictureBox.Visible = false;
            CardMirPictureBox.Visible = false;
            CardVisaPictureBox.Visible = false;

            var cards = BankService.GetAllCards(DataStorage.idClient);
            CardsComboBox.DataSource = cards;
            CardsComboBox.ValueMember = "id_bank_card";
            CardsComboBox.DisplayMember = "bank_card_number";

            selectBankCard();
        }


        private void updateCurrencyRate()
        {
            var (usd, euro) = CurrencyHelper.UpdateExchangeRate().Result;
            var rate = $"USD {usd} / EUR {euro}";

            if (InvokeRequired)
            {
                CurrencyLabel.Invoke(() => { CurrencyLabel.Text = rate; });
            }
            else
            {
                CurrencyLabel.Text = rate;
            }
        }

        private void selectBankCard()
        {
            HiddenCardNumberLabel.Text = string.Empty;
            var cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            var bankCardInfo = BankService.GetBankCardInfo(cardNumber);
           
            var paymentSystem = bankCardInfo["bank_card_payment_system"];

            HiddenCardNumberLabel.Text = formatCardNumber(cardNumber);
            HiddenCardCvvNumberLabel.Text = bankCardInfo["bank_card_cvv_code"];
            HiddenCardValidUntilDateLabel.Text = bankCardInfo["date"];
            CardAmountLabel.Text = bankCardInfo["bank_card_balance"];
            CardCurrencyLabel.Text = bankCardInfo["bank_card_currency"];
                     
            DataStorage.cardCVV = HiddenCardCvvNumberLabel.Text ?? "";
            HiddenCardCvvNumberLabel.Text = "***";
                    
            setPaymentSystem(paymentSystem);
        }

        private string formatCardNumber(string cardNumber)
        {
            int step = 4;
            string resultText = string.Empty;

            for(int i = 0; i < cardNumber.Length; i++)
            {
                if (i % step == 0)
                {
                    resultText += " ";
                }
                resultText += cardNumber[i].ToString();
            }
            return resultText;
        }

        private void setPaymentSystem(string paymentSystem)
        {
            if (BankOptions.GetCardVendorTypeFromString(paymentSystem) == BankOptions.CardVendor.VISA)
            {
                CardVisaPictureBox.Visible = true;
                CardMasterCardPictureBox.Visible = false;
                CardMirPictureBox.Visible = false;
            }
            else if (BankOptions.GetCardVendorTypeFromString(paymentSystem) == BankOptions.CardVendor.MasterCard)
            {
                CardVisaPictureBox.Visible = false;
                CardMasterCardPictureBox.Visible = true;
                CardMirPictureBox.Visible = false;
            }
            else if (BankOptions.GetCardVendorTypeFromString(paymentSystem) == BankOptions.CardVendor.MIR)
            {
                CardVisaPictureBox.Visible = false;
                CardMasterCardPictureBox.Visible = false;
                CardMirPictureBox.Visible = true;
            }
        }

        private void HiddenCardCvvNumberLabel_Click(object sender, EventArgs e)
        {
            HiddenCardCvvNumberLabel.Text = (HiddenCardCvvNumberLabel.Text == "***") ? DataStorage.cardCVV : "***";
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            var cards = BankService.GetAllCards(DataStorage.idClient);

            CardsComboBox.DataSource = cards;
            CardsComboBox.ValueMember = "id_bank_card";
            CardsComboBox.DisplayMember = "bank_card_number";

            selectBankCard();
        }

        private void CardsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CardTransferButton_Click(object sender, EventArgs e)
        {
            SendToForm sendToForm = new SendToForm();

            DataStorage.bankCard = CardTransferTextBox.Text;
            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);

            CardsComboBox.Text = string.Empty;

            sendToForm.ShowDialog();
        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void TransactionHistoryPictureBox_Click(object sender, EventArgs e)
        {
            TransactionHistory history = new TransactionHistory();
            history.Show();

        }

        private void TopUpMobileButton_Click(object sender, EventArgs e)
        {
            TopUpMobileForm topUpMobileForm = new TopUpMobileForm();

            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
            DataStorage.phoneNumber = TopUpMobileTextBox.Text;

            TopUpMobileTextBox.Text = string.Empty;

            topUpMobileForm.Show();
        }

        private void CommunalPaymentButton_Click(object sender, EventArgs e)
        {
            CommunalPaymentForm communalPaymentForm = new CommunalPaymentForm();

            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);

            communalPaymentForm.Show();
        }

        private void InternetTVButton_Click(object sender, EventArgs e)
        {
            InternetAndTVPaymentForm internetAndTVPaymentForm = new InternetAndTVPaymentForm();

            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);

            internetAndTVPaymentForm.Show();
        }

        private void CharityButton_Click(object sender, EventArgs e)
        {
            CharityForm charityForm = new CharityForm();

            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);

            charityForm.Show();
        }

        private void CreditButton_Click(object sender, EventArgs e)
        {
            DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);

            var cardCurrency = BankService.GetCardCurrency(DataStorage.cardNumber);
            if (CurrencyHelper.GetCurrencyTypeFromString(cardCurrency) == BankOptions.CurrencyByDefault)
            {
                CreditForm creditForm = new CreditForm();
                creditForm.Show();
            }
            else
            {
                MessageBox.Show("Операции с кредитом могут производиться только в рублях!", 
                                "Отказ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await Task.Run(updateCurrencyRate);
        }

        private void CardsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectBankCard();
        }

        private void HiddenCardValidUntilDateLabel_Click(object sender, EventArgs e)
        {
        }

        private void HiddenCardCvvLabel_Click(object sender, EventArgs e)
        {
        }

        private void HiddenCardValidUntilLabel_Click(object sender, EventArgs e)
        {
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            AddBankCardForm addBankCardForm = new AddBankCardForm();
            addBankCardForm.ShowDialog();
        }
    }
}
