using BankApp.Classes;

namespace BankApp.Forms
{
    public partial class ValidationForm : Form
    {
        public ValidationForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ValidationForm_MouseDown(object sender, MouseEventArgs e)
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

        private void OkButton_Click(object sender, EventArgs e)
        {
            int attempts = 3;

            int cardPinInput = Convert.ToInt32(PinCodeNumericUpDown.Value);
            int pin = BankService.GetBankCardPinCode(DataStorage.bankCard);

            DataStorage.attempts = checkAttempts(cardPinInput, pin, attempts);
       
            Close();
        }

        private int checkAttempts(int cardPinInput, int pin, int attempts)
        {
            if (cardPinInput == pin)
            {
                MessageBox.Show("Операция подтверждена", "ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataStorage.attempts = 3;
                return attempts;
            }
            else
            {
                MessageBox.Show("Ошибка. Неверный PIN", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (attempts > 0)
                {
                    attempts--;
                }
                else
                {
                    MessageBox.Show("У вас закончились попытки", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return attempts;

                }
            }
            return attempts;
        }

        private void ValidationForm_Load(object sender, EventArgs e)
        {
        }
    }
}
