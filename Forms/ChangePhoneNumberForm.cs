using BankApp.Classes;
using System.Text.RegularExpressions;

namespace BankApp.Forms
{
    public partial class ChangePhoneNumberForm : Form
    {
        public ChangePhoneNumberForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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

        private void ChangePhoneNumberForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AcceptChangePhoneNumberButton_Click(object sender, EventArgs e)
        {
            var phoneNumber = NewPhoneNumberTextBox.Text;
            if (!isCorrectPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Пожалуйста, введите номер телефона", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewPhoneNumberTextBox.Select();
                return;
            }

            int affectedRows = ClientService.ChangePhoneNumber(phoneNumber, DataStorage.idClient);
            if (affectedRows == 1)
            {
                MessageBox.Show("Номер телефона успешно изменён!");
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private bool isCorrectPhoneNumber(string password)
        {
            const string IsCorrectPhoneNumberRegex = @"^(\+7|7|8)?[\s\-]?\(?[489][0-9]{2}\)?[\s\-]?[0-9]{3}[\s\-]?[0-9]{2}[\s\-]?[0-9]{2}$";
            return Regex.IsMatch(password, IsCorrectPhoneNumberRegex);
        }

        private void ChangePhoneNumberForm_Load(object sender, EventArgs e)
        {
        }
    }
}
