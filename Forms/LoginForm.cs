using BankApp.Classes;

namespace BankApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PhoneNumberTextBox.Select();
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = (ShowPasswordCheckBox.Checked == true) ? false : true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var phoneNumber = PhoneNumberTextBox.Text;
            var password = PasswordTextBox.Text;
            if (!string.IsNullOrEmpty(phoneNumber) && !string.IsNullOrEmpty(password))
            {
                var (isSignIn, idClient) = ClientService.SignIn(phoneNumber, password);
                if (isSignIn)
                {
                    DataStorage.idClient = idClient;

                    PhoneNumberTextBox.Clear();
                    PasswordTextBox.Clear();
                    ShowPasswordCheckBox.Checked = false;

                    Hide();

                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    mainForm = null;

                    Show();

                    PhoneNumberTextBox.Select();
                }
                else
                {
                    MessageBox.Show("Номер телефона или пароль неверны. Попробуйте ещё раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    PhoneNumberTextBox.Focus();
                    PhoneNumberTextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста введите номер пользователя и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                PhoneNumberTextBox.Select();
            }
        }

        private void LoginCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
