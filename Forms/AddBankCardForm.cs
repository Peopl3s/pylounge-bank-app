using BankApp.Classes;

namespace BankApp.Forms
{
    public partial class AddBankCardForm : Form
    {
        public AddBankCardForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AddBankCardForm_MouseDown(object sender, MouseEventArgs e)
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

        private void CreateCardButton_Click(object sender, EventArgs e)
        {
            var cardType = CardTypeComboBox.GetItemText(CardTypeComboBox.SelectedItem);
            var cardCurrency = CardCurrencyComboBox.GetItemText(CardCurrencyComboBox.SelectedItem);
            var cardPaymentSystem = CardPaymentSystemComboBox.GetItemText(CardPaymentSystemComboBox.SelectedItem);
            var cardPinCode = CardPinCodeNumericUpDown.Value;

            int countAffectedRows = BankService.CreateNewCard(
                cardPaymentSystem, cardType, cardCurrency, cardPinCode, DataStorage.idClient
                );
            if (countAffectedRows > 0)
            {
                MessageBox.Show("Карта успешно создана", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Карта не создана", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void AddBankCardForm_Load(object sender, EventArgs e)
        {
            CardTypeComboBox.SelectedIndex = 0;
            CardCurrencyComboBox.SelectedIndex = 0;
            CardPaymentSystemComboBox.SelectedIndex = 0;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CardCurrencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CardPaymentSystemLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CardPaymentSystemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CardPinCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void CardCurrencyLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CardPinCodeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
