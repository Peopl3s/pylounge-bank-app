using BankApp.Classes;
using System.Text.RegularExpressions;

namespace BankApp.Forms
{
    public partial class ChangeEmailForm : Form
    {
        public ChangeEmailForm()
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

        private void ChangeEmailForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AcceptChangeEmailButton_Click(object sender, EventArgs e)
        {
            var email = NewEmailTextBox.Text;
            if (!isCorrectEmail(email))
            {
                MessageBox.Show("Пожалуйста, введите вашу почту", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewEmailTextBox.Select();
                return;
            }

            int affectedRows = ClientService.ChangeEmail(email, DataStorage.idClient);
            if (affectedRows == 1)
            {
                MessageBox.Show("Эл.почта успешно изменёна!");
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private bool isCorrectEmail(string email)
        {
            const string IsCorrectEmailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, IsCorrectEmailRegex);
        }

        private void ChangeEmailForm_Load(object sender, EventArgs e)
        {
        }
    }
}
