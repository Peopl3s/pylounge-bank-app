using BankApp.Classes;
using System.Configuration;
using System.Text.RegularExpressions;


namespace BankApp.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
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

        private void ChangePasswordForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AcceptChangePasswordButton_Click(object sender, EventArgs e)
        {
            var password = NewPasswordTextBox.Text;
            if (!isCorrectPassword(password))
            {
                MessageBox.Show("Пожалуйста, введите пароль", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewPasswordTextBox.Select();
                return;
            }

            int affectedRows = ClientService.ChangePassword(password, DataStorage.idClient);
            if (affectedRows == 1)
            {
                MessageBox.Show("Пароль успешно изменён!");
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private bool isCorrectPassword(string password)
        {
            const string IsCorrectPasswordRegex = @"(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#!?@$%^&*-_]).{8,}";
            return Regex.IsMatch(password, IsCorrectPasswordRegex);
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
        }
    }
}
