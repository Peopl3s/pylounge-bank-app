using BankApp.Classes;

namespace BankApp.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
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

        private void UserForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            RefreshData(DataStorage.idClient);
        }

        private void RefreshData(string idClient)
        {
            var clientInfo = ClientService.GetClientInfo(idClient);
            SNMLabel.Text = clientInfo["snm"].Trim();
            PhoneNumberLabel.Text = clientInfo["client_phone_number"].Trim();
            EmailLabel.Text = clientInfo["client_email"].Trim();   
        }

        private void ClearFields()
        {
            SNMLabel.Text = string.Empty;
            PhoneNumberLabel.Text = string.Empty;
            EmailLabel.Text = string.Empty;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            RefreshData(DataStorage.idClient);
        }

        private void ChangePhoneButton_Click(object sender, EventArgs e)
        {
            ChangePhoneNumberForm changePhoneNumberForm = new ChangePhoneNumberForm();
            changePhoneNumberForm.Show();
        }

        private void ChangeEmailButton_Click(object sender, EventArgs e)
        {
            ChangeEmailForm changeEmailForm = new ChangeEmailForm();
            changeEmailForm.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.Show();
        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
