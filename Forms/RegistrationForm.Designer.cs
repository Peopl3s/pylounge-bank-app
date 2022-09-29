namespace BankApp.Forms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.CloseRegistrationButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordConfirmLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNamberLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordConfirmTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrationLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegistrationLabel.Location = new System.Drawing.Point(0, 0);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(303, 33);
            this.RegistrationLabel.TabIndex = 0;
            this.RegistrationLabel.Text = "Регистрация";
            this.RegistrationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CloseRegistrationButton
            // 
            this.CloseRegistrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseRegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.CloseRegistrationButton.FlatAppearance.BorderSize = 0;
            this.CloseRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseRegistrationButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseRegistrationButton.Location = new System.Drawing.Point(311, 12);
            this.CloseRegistrationButton.Name = "CloseRegistrationButton";
            this.CloseRegistrationButton.Size = new System.Drawing.Size(22, 23);
            this.CloseRegistrationButton.TabIndex = 1;
            this.CloseRegistrationButton.Text = "X";
            this.CloseRegistrationButton.UseVisualStyleBackColor = false;
            this.CloseRegistrationButton.Click += new System.EventHandler(this.CloseRegistrationButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FirstNameLabel.Location = new System.Drawing.Point(2, 33);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(82, 17);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "Введите имя";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LastNameLabel.Location = new System.Drawing.Point(2, 93);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(116, 17);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Введите фамилию";
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MiddleNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MiddleNameLabel.Location = new System.Drawing.Point(2, 151);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(112, 17);
            this.MiddleNameLabel.TabIndex = 4;
            this.MiddleNameLabel.Text = "Введите отчество";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GenderLabel.Location = new System.Drawing.Point(2, 210);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(89, 17);
            this.GenderLabel.TabIndex = 5;
            this.GenderLabel.Text = "Выберите пол";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(6, 54);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(295, 23);
            this.FirstNameTextBox.TabIndex = 6;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(5, 114);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(296, 23);
            this.LastNameTextBox.TabIndex = 7;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(5, 167);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(296, 23);
            this.MiddleNameTextBox.TabIndex = 8;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Муж",
            "Жен"});
            this.GenderComboBox.Location = new System.Drawing.Point(6, 231);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(295, 23);
            this.GenderComboBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel1.Location = new System.Drawing.Point(6, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 3);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel2.Location = new System.Drawing.Point(6, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 3);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel3.Location = new System.Drawing.Point(6, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 3);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel4.Location = new System.Drawing.Point(6, 253);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 3);
            this.panel4.TabIndex = 13;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.Location = new System.Drawing.Point(2, 281);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(101, 17);
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "Введите пароль";
            // 
            // PasswordConfirmLabel
            // 
            this.PasswordConfirmLabel.AutoSize = true;
            this.PasswordConfirmLabel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordConfirmLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordConfirmLabel.Location = new System.Drawing.Point(1, 345);
            this.PasswordConfirmLabel.Name = "PasswordConfirmLabel";
            this.PasswordConfirmLabel.Size = new System.Drawing.Size(158, 17);
            this.PasswordConfirmLabel.TabIndex = 15;
            this.PasswordConfirmLabel.Text = "Введите пароль повторно";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmailLabel.Location = new System.Drawing.Point(2, 416);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(172, 17);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Введите электронную почту";
            // 
            // PhoneNamberLabel
            // 
            this.PhoneNamberLabel.AutoSize = true;
            this.PhoneNamberLabel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNamberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneNamberLabel.Location = new System.Drawing.Point(1, 471);
            this.PhoneNamberLabel.Name = "PhoneNamberLabel";
            this.PhoneNamberLabel.Size = new System.Drawing.Size(156, 17);
            this.PhoneNamberLabel.TabIndex = 17;
            this.PhoneNamberLabel.Text = "Введите номер телефона";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(3, 302);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(298, 23);
            this.PasswordTextBox.TabIndex = 18;
            // 
            // PasswordConfirmTextBox
            // 
            this.PasswordConfirmTextBox.Location = new System.Drawing.Point(2, 365);
            this.PasswordConfirmTextBox.Name = "PasswordConfirmTextBox";
            this.PasswordConfirmTextBox.Size = new System.Drawing.Size(299, 23);
            this.PasswordConfirmTextBox.TabIndex = 19;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(2, 432);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(297, 23);
            this.EmailTextBox.TabIndex = 20;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(3, 489);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(297, 23);
            this.PhoneNumberTextBox.TabIndex = 21;
            // 
            // PasswordCheckBox
            // 
            this.PasswordCheckBox.AutoSize = true;
            this.PasswordCheckBox.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PasswordCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordCheckBox.Location = new System.Drawing.Point(184, 391);
            this.PasswordCheckBox.Name = "PasswordCheckBox";
            this.PasswordCheckBox.Size = new System.Drawing.Size(113, 20);
            this.PasswordCheckBox.TabIndex = 22;
            this.PasswordCheckBox.Text = "Показать пароль";
            this.PasswordCheckBox.UseVisualStyleBackColor = true;
            this.PasswordCheckBox.CheckedChanged += new System.EventHandler(this.PasswordCheckBox_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel5.Location = new System.Drawing.Point(3, 324);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 3);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel6.Location = new System.Drawing.Point(1, 387);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 3);
            this.panel6.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel7.Location = new System.Drawing.Point(2, 452);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(296, 3);
            this.panel7.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel8.Location = new System.Drawing.Point(4, 509);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(296, 3);
            this.panel8.TabIndex = 26;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(154, 33);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearButton.Location = new System.Drawing.Point(149, 0);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(154, 33);
            this.ClearButton.TabIndex = 28;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.PasswordCheckBox);
            this.panel9.Controls.Add(this.PhoneNumberTextBox);
            this.panel9.Controls.Add(this.EmailTextBox);
            this.panel9.Controls.Add(this.PasswordConfirmTextBox);
            this.panel9.Controls.Add(this.PasswordTextBox);
            this.panel9.Controls.Add(this.PhoneNamberLabel);
            this.panel9.Controls.Add(this.EmailLabel);
            this.panel9.Controls.Add(this.PasswordConfirmLabel);
            this.panel9.Controls.Add(this.PasswordLabel);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.GenderComboBox);
            this.panel9.Controls.Add(this.MiddleNameTextBox);
            this.panel9.Controls.Add(this.LastNameTextBox);
            this.panel9.Controls.Add(this.FirstNameTextBox);
            this.panel9.Controls.Add(this.GenderLabel);
            this.panel9.Controls.Add(this.MiddleNameLabel);
            this.panel9.Controls.Add(this.LastNameLabel);
            this.panel9.Controls.Add(this.FirstNameLabel);
            this.panel9.Controls.Add(this.RegistrationLabel);
            this.panel9.Location = new System.Drawing.Point(24, 8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(303, 555);
            this.panel9.TabIndex = 29;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ClearButton);
            this.panel10.Controls.Add(this.SaveButton);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 522);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(303, 33);
            this.panel10.TabIndex = 29;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(345, 609);
            this.Controls.Add(this.CloseRegistrationButton);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label RegistrationLabel;
        private Button CloseRegistrationButton;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label MiddleNameLabel;
        private Label GenderLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox MiddleNameTextBox;
        private ComboBox GenderComboBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label PasswordLabel;
        private Label PasswordConfirmLabel;
        private Label EmailLabel;
        private Label PhoneNamberLabel;
        private TextBox PasswordTextBox;
        private TextBox PasswordConfirmTextBox;
        private TextBox EmailTextBox;
        private TextBox PhoneNumberTextBox;
        private CheckBox PasswordCheckBox;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Button SaveButton;
        private Button ClearButton;
        private Panel panel9;
        private Panel panel10;
    }
}