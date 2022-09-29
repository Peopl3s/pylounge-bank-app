namespace BankApp.Forms
{
    partial class TopUpMobileForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.FlagPictureBox = new System.Windows.Forms.PictureBox();
            this.PhoneNumberPrefixLabel = new System.Windows.Forms.Label();
            this.TopUpMobileLabel = new System.Windows.Forms.Label();
            this.TopUpMobileLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TopUpModileDescLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TopUpMobileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OperatorsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComissionLabel = new System.Windows.Forms.Label();
            this.ComissionCurrencyLabel = new System.Windows.Forms.Label();
            this.ToBePaidCuncurrencyLabel = new System.Windows.Forms.Label();
            this.ToBePaidLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToUpAccountButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CardCVVLabel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CardDateLabel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FlagPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopUpMobileLogoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(400, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FlagPictureBox
            // 
            this.FlagPictureBox.Image = global::BankApp.Properties.Resources.rightarrow_theaction_6342;
            this.FlagPictureBox.Location = new System.Drawing.Point(0, 4);
            this.FlagPictureBox.Name = "FlagPictureBox";
            this.FlagPictureBox.Size = new System.Drawing.Size(41, 29);
            this.FlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlagPictureBox.TabIndex = 21;
            this.FlagPictureBox.TabStop = false;
            // 
            // PhoneNumberPrefixLabel
            // 
            this.PhoneNumberPrefixLabel.AutoSize = true;
            this.PhoneNumberPrefixLabel.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberPrefixLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneNumberPrefixLabel.Location = new System.Drawing.Point(50, 8);
            this.PhoneNumberPrefixLabel.Name = "PhoneNumberPrefixLabel";
            this.PhoneNumberPrefixLabel.Size = new System.Drawing.Size(18, 16);
            this.PhoneNumberPrefixLabel.TabIndex = 20;
            this.PhoneNumberPrefixLabel.Text = "+7";
            // 
            // TopUpMobileLabel
            // 
            this.TopUpMobileLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopUpMobileLabel.AutoSize = true;
            this.TopUpMobileLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopUpMobileLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopUpMobileLabel.Location = new System.Drawing.Point(73, 13);
            this.TopUpMobileLabel.Name = "TopUpMobileLabel";
            this.TopUpMobileLabel.Size = new System.Drawing.Size(325, 36);
            this.TopUpMobileLabel.TabIndex = 19;
            this.TopUpMobileLabel.Text = "Пополнение мобильного";
            this.TopUpMobileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TopUpMobileLogoPictureBox
            // 
            this.TopUpMobileLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TopUpMobileLogoPictureBox.Image = global::BankApp.Properties.Resources.SIPphone_phone_6016;
            this.TopUpMobileLogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.TopUpMobileLogoPictureBox.Name = "TopUpMobileLogoPictureBox";
            this.TopUpMobileLogoPictureBox.Size = new System.Drawing.Size(59, 60);
            this.TopUpMobileLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopUpMobileLogoPictureBox.TabIndex = 18;
            this.TopUpMobileLogoPictureBox.TabStop = false;
            // 
            // TopUpModileDescLabel
            // 
            this.TopUpModileDescLabel.AutoSize = true;
            this.TopUpModileDescLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TopUpModileDescLabel.Font = new System.Drawing.Font("Impact", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopUpModileDescLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopUpModileDescLabel.Location = new System.Drawing.Point(0, 31);
            this.TopUpModileDescLabel.Name = "TopUpModileDescLabel";
            this.TopUpModileDescLabel.Size = new System.Drawing.Size(182, 13);
            this.TopUpModileDescLabel.TabIndex = 17;
            this.TopUpModileDescLabel.Text = "Пополнение только на российские номера";
            this.TopUpModileDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel3.Location = new System.Drawing.Point(73, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 3);
            this.panel3.TabIndex = 15;
            // 
            // TopUpMobileTextBox
            // 
            this.TopUpMobileTextBox.Location = new System.Drawing.Point(73, 4);
            this.TopUpMobileTextBox.Name = "TopUpMobileTextBox";
            this.TopUpMobileTextBox.Size = new System.Drawing.Size(213, 23);
            this.TopUpMobileTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Номер";
            // 
            // OperatorsComboBox
            // 
            this.OperatorsComboBox.FormattingEnabled = true;
            this.OperatorsComboBox.Location = new System.Drawing.Point(10, 83);
            this.OperatorsComboBox.Name = "OperatorsComboBox";
            this.OperatorsComboBox.Size = new System.Drawing.Size(276, 23);
            this.OperatorsComboBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Сумма";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(8, 138);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(204, 23);
            this.SumTextBox.TabIndex = 25;
            this.SumTextBox.TextChanged += new System.EventHandler(this.SumTextBox_TextChanged);
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrencyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CurrencyLabel.Location = new System.Drawing.Point(218, 141);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(36, 20);
            this.CurrencyLabel.TabIndex = 26;
            this.CurrencyLabel.Text = "RUB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(8, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Комиссия";
            // 
            // ComissionLabel
            // 
            this.ComissionLabel.AutoSize = true;
            this.ComissionLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComissionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComissionLabel.Location = new System.Drawing.Point(186, 171);
            this.ComissionLabel.Name = "ComissionLabel";
            this.ComissionLabel.Size = new System.Drawing.Size(18, 20);
            this.ComissionLabel.TabIndex = 28;
            this.ComissionLabel.Text = "0";
            // 
            // ComissionCurrencyLabel
            // 
            this.ComissionCurrencyLabel.AutoSize = true;
            this.ComissionCurrencyLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComissionCurrencyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComissionCurrencyLabel.Location = new System.Drawing.Point(218, 172);
            this.ComissionCurrencyLabel.Name = "ComissionCurrencyLabel";
            this.ComissionCurrencyLabel.Size = new System.Drawing.Size(36, 20);
            this.ComissionCurrencyLabel.TabIndex = 29;
            this.ComissionCurrencyLabel.Text = "RUB";
            // 
            // ToBePaidCuncurrencyLabel
            // 
            this.ToBePaidCuncurrencyLabel.AutoSize = true;
            this.ToBePaidCuncurrencyLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToBePaidCuncurrencyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToBePaidCuncurrencyLabel.Location = new System.Drawing.Point(218, 196);
            this.ToBePaidCuncurrencyLabel.Name = "ToBePaidCuncurrencyLabel";
            this.ToBePaidCuncurrencyLabel.Size = new System.Drawing.Size(36, 20);
            this.ToBePaidCuncurrencyLabel.TabIndex = 32;
            this.ToBePaidCuncurrencyLabel.Text = "RUB";
            // 
            // ToBePaidLabel
            // 
            this.ToBePaidLabel.AutoSize = true;
            this.ToBePaidLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToBePaidLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToBePaidLabel.Location = new System.Drawing.Point(186, 195);
            this.ToBePaidLabel.Name = "ToBePaidLabel";
            this.ToBePaidLabel.Size = new System.Drawing.Size(18, 20);
            this.ToBePaidLabel.TabIndex = 31;
            this.ToBePaidLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(8, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "К оплате";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "С карты";
            // 
            // ToUpAccountButton
            // 
            this.ToUpAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ToUpAccountButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToUpAccountButton.FlatAppearance.BorderSize = 0;
            this.ToUpAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToUpAccountButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToUpAccountButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToUpAccountButton.Location = new System.Drawing.Point(0, 147);
            this.ToUpAccountButton.Name = "ToUpAccountButton";
            this.ToUpAccountButton.Size = new System.Drawing.Size(291, 42);
            this.ToUpAccountButton.TabIndex = 34;
            this.ToUpAccountButton.Text = "Пополнить счёт";
            this.ToUpAccountButton.UseVisualStyleBackColor = false;
            this.ToUpAccountButton.Click += new System.EventHandler(this.ToUpAccountButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.CardCVVLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CardDateLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CardNumberLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 149);
            this.panel1.TabIndex = 35;
            // 
            // CardCVVLabel
            // 
            this.CardCVVLabel.Location = new System.Drawing.Point(140, 110);
            this.CardCVVLabel.Name = "CardCVVLabel";
            this.CardCVVLabel.Size = new System.Drawing.Size(71, 23);
            this.CardCVVLabel.TabIndex = 37;
            this.CardCVVLabel.Text = "***";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(139, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "CVV-Код";
            // 
            // CardDateLabel
            // 
            this.CardDateLabel.Location = new System.Drawing.Point(18, 110);
            this.CardDateLabel.Name = "CardDateLabel";
            this.CardDateLabel.Size = new System.Drawing.Size(83, 23);
            this.CardDateLabel.TabIndex = 36;
            this.CardDateLabel.Text = "X/XX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(18, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Срок действия ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(18, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 3);
            this.panel2.TabIndex = 2;
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardNumberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CardNumberLabel.Location = new System.Drawing.Point(18, 52);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(123, 20);
            this.CardNumberLabel.TabIndex = 1;
            this.CardNumberLabel.Text = "0000 0000 0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Номер карты";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel4.Controls.Add(this.TopUpMobileLabel);
            this.panel4.Controls.Add(this.TopUpMobileLogoPictureBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 60);
            this.panel4.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.ToBePaidCuncurrencyLabel);
            this.panel5.Controls.Add(this.ToBePaidLabel);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.ComissionCurrencyLabel);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.ComissionLabel);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.CurrencyLabel);
            this.panel5.Controls.Add(this.SumTextBox);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.OperatorsComboBox);
            this.panel5.Location = new System.Drawing.Point(62, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(291, 225);
            this.panel5.TabIndex = 37;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.FlagPictureBox);
            this.panel9.Controls.Add(this.PhoneNumberPrefixLabel);
            this.panel9.Controls.Add(this.TopUpModileDescLabel);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.TopUpMobileTextBox);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 28);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(291, 44);
            this.panel9.TabIndex = 33;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel8.Location = new System.Drawing.Point(7, 158);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(204, 3);
            this.panel8.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel7.Location = new System.Drawing.Point(10, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(276, 3);
            this.panel7.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.ToUpAccountButton);
            this.panel6.Location = new System.Drawing.Point(62, 299);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(291, 189);
            this.panel6.TabIndex = 38;
            // 
            // TopUpMobileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(433, 520);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopUpMobileForm";
            this.Text = "TopUpMobileForm";
            this.Load += new System.EventHandler(this.TopUpMobileForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopUpMobileForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.FlagPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopUpMobileLogoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button CloseButton;
        private PictureBox FlagPictureBox;
        private Label PhoneNumberPrefixLabel;
        private Label TopUpMobileLabel;
        private PictureBox TopUpMobileLogoPictureBox;
        private Label TopUpModileDescLabel;
        private Panel panel3;
        private TextBox TopUpMobileTextBox;
        private Label label1;
        private ComboBox OperatorsComboBox;
        private Label label2;
        private TextBox SumTextBox;
        private Label CurrencyLabel;
        private Label label3;
        private Label ComissionLabel;
        private Label ComissionCurrencyLabel;
        private Label ToBePaidCuncurrencyLabel;
        private Label ToBePaidLabel;
        private Label label6;
        private Label label4;
        private Button ToUpAccountButton;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Panel panel2;
        private Label CardNumberLabel;
        private Label label5;
        private TextBox CardCVVLabel;
        private TextBox CardDateLabel;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
    }
}