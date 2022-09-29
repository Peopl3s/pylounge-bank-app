using BankApp.Classes;
using System.Text.RegularExpressions;

namespace BankApp.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            FirstNameTextBox.Select();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            checkCorrectFormFields();

            if (ClientService.IsClientAleadyCreated(PhoneNumberTextBox.Text))
            {
                MessageBox.Show("Телефон уже существует. Невозможно зарегистрировать аккаунт!", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PhoneNumberTextBox.SelectAll();
                return;
            }

            DialogResult result = MessageBox.Show("Вы хотите сохранить запись?", "Сохранение данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int countAffectedRows = ClientService.SaveClient(
                    FirstNameTextBox.Text, LastNameTextBox.Text, MiddleNameTextBox.Text,
                    GenderComboBox.SelectedItem.ToString(), PasswordTextBox.Text, EmailTextBox.Text, PhoneNumberTextBox.Text
                    );
                if (countAffectedRows > 0)
                {
                    MessageBox.Show("Запись успешно сохранена", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearControls();
                }
                else
                {
                    MessageBox.Show("Запись не завершена", "Отклонено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();
            }
        }

        private void checkCorrectFormFields()
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            if (!isCorrectName(FirstNameTextBox.Text))
            {
                MessageBox.Show("Введите имя повторно!", caption, btn, icon);
                FirstNameTextBox.Select();
                return;
            }

            if (!isCorrectLastName(LastNameTextBox.Text))
            {
                MessageBox.Show("Введите фамилию повторно!", caption, btn, icon);
                LastNameTextBox.Select();
                return;
            }

            if (!isCorrectMiddleName(MiddleNameTextBox.Text))
            {
                MessageBox.Show("Введите отчество повторно!", caption, btn, icon);
                MiddleNameTextBox.Select();
                return;
            }

            if (!isCorrectGender(GenderComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Пожалуйста, выберите пол!", caption, btn, icon);
                GenderComboBox.Select();
                return;
            }

            if (!isCorrectPassword(PasswordTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите пароль!", caption, btn, icon);
                PasswordTextBox.Select();
                return;
            }

            if (!isCorrectPassword(PasswordConfirmTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите подствержденый пароль!", caption, btn, icon);
                PasswordConfirmTextBox.Select();
                return;
            }

            if (PasswordTextBox.Text != PasswordConfirmTextBox.Text)
            {
                MessageBox.Show("Ваш пароль и пароль подтверждения не совпадают!", caption, btn, icon);
                PasswordConfirmTextBox.SelectAll();
                return;
            }

            if (!isCorrectEmail(EmailTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите вашу почту!", caption, btn, icon);
                EmailTextBox.Select();
                return;
            }

            if (!isCorrectPhoneNumber(PhoneNumberTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите вашу номер телефона!", caption, btn, icon);
                PhoneNumberTextBox.Select();
                return;
            }
        }

        private bool isCorrectName(string name)
        {
            const string IsCorrectNameSurnameMiddlenameRegex = "[A-Za-zА-Яа-я]+$";
            return Regex.IsMatch(name, IsCorrectNameSurnameMiddlenameRegex);
        }

        private bool isCorrectLastName(string lastName)
        {
            const string IsCorrectNameSurnameMiddlenameRegex = "[A-Za-zА-Яа-я]+$";
            return Regex.IsMatch(lastName, IsCorrectNameSurnameMiddlenameRegex);
        }

        private bool isCorrectMiddleName(string middleName)
        {
            const string IsCorrectNameSurnameMiddlenameRegex = "[A-Za-zА-Яа-я]+$";
            return Regex.IsMatch(middleName, IsCorrectNameSurnameMiddlenameRegex);
        }

        private bool isCorrectGender(string gender)
        {
            return !string.IsNullOrEmpty(gender);
        }

        private bool isCorrectPassword(string password)
        {
            const string IsCorrectPasswordRegex = "(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#!?@$%^&*-_]).{8,}";
            return Regex.IsMatch(password, IsCorrectPasswordRegex);
        }

        private bool isCorrectEmail(string email)
        {
            const string IsCorrectEmailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(email, IsCorrectEmailRegex);
        }

        private bool isCorrectPhoneNumber(string phoneNumber)
        {
            const string IsCorrectPhoneNumberRegex = @"^((\+7|7|8)+([0-9]){10})$";
            return Regex.IsMatch(phoneNumber, IsCorrectPhoneNumberRegex);
        }

        private void clearControls()
        {
            foreach(TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }

            foreach(ComboBox comboBox in Controls.OfType<ComboBox>())
            {
                comboBox.SelectedItem = null;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Select();
            clearControls();
        }

        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                PasswordConfirmTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                PasswordConfirmTextBox.UseSystemPasswordChar = true;
            }
        }

        private void CloseRegistrationButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
