namespace BankApp.Forms
{
    partial class AddBankCardForm
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
            this.CreateCardButton = new System.Windows.Forms.Button();
            this.CardTypeLabel = new System.Windows.Forms.Label();
            this.CardCurrencyLabel = new System.Windows.Forms.Label();
            this.CardPaymentSystemLabel = new System.Windows.Forms.Label();
            this.CardPinCodeLabel = new System.Windows.Forms.Label();
            this.CardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CardCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.CardPaymentSystemComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CardPinCodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CardPinCodeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(328, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CreateCardButton
            // 
            this.CreateCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.CreateCardButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateCardButton.FlatAppearance.BorderSize = 0;
            this.CreateCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCardButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCardButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateCardButton.Location = new System.Drawing.Point(0, 270);
            this.CreateCardButton.Name = "CreateCardButton";
            this.CreateCardButton.Size = new System.Drawing.Size(331, 45);
            this.CreateCardButton.TabIndex = 1;
            this.CreateCardButton.Text = "Создать";
            this.CreateCardButton.UseVisualStyleBackColor = false;
            this.CreateCardButton.Click += new System.EventHandler(this.CreateCardButton_Click);
            // 
            // CardTypeLabel
            // 
            this.CardTypeLabel.AutoSize = true;
            this.CardTypeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardTypeLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardTypeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CardTypeLabel.Location = new System.Drawing.Point(0, 0);
            this.CardTypeLabel.Name = "CardTypeLabel";
            this.CardTypeLabel.Size = new System.Drawing.Size(81, 20);
            this.CardTypeLabel.TabIndex = 2;
            this.CardTypeLabel.Text = "Тип карты";
            // 
            // CardCurrencyLabel
            // 
            this.CardCurrencyLabel.AutoSize = true;
            this.CardCurrencyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardCurrencyLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardCurrencyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CardCurrencyLabel.Location = new System.Drawing.Point(0, 0);
            this.CardCurrencyLabel.Name = "CardCurrencyLabel";
            this.CardCurrencyLabel.Size = new System.Drawing.Size(62, 20);
            this.CardCurrencyLabel.TabIndex = 3;
            this.CardCurrencyLabel.Text = "Валюта";
            this.CardCurrencyLabel.Click += new System.EventHandler(this.CardCurrencyLabel_Click);
            // 
            // CardPaymentSystemLabel
            // 
            this.CardPaymentSystemLabel.AutoSize = true;
            this.CardPaymentSystemLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardPaymentSystemLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardPaymentSystemLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CardPaymentSystemLabel.Location = new System.Drawing.Point(0, 0);
            this.CardPaymentSystemLabel.Name = "CardPaymentSystemLabel";
            this.CardPaymentSystemLabel.Size = new System.Drawing.Size(149, 20);
            this.CardPaymentSystemLabel.TabIndex = 4;
            this.CardPaymentSystemLabel.Text = "Платёжная система";
            this.CardPaymentSystemLabel.Click += new System.EventHandler(this.CardPaymentSystemLabel_Click);
            // 
            // CardPinCodeLabel
            // 
            this.CardPinCodeLabel.AutoSize = true;
            this.CardPinCodeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardPinCodeLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardPinCodeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CardPinCodeLabel.Location = new System.Drawing.Point(0, 0);
            this.CardPinCodeLabel.Name = "CardPinCodeLabel";
            this.CardPinCodeLabel.Size = new System.Drawing.Size(62, 20);
            this.CardPinCodeLabel.TabIndex = 5;
            this.CardPinCodeLabel.Text = "PIN-код";
            this.CardPinCodeLabel.Click += new System.EventHandler(this.CardPinCodeLabel_Click);
            // 
            // CardTypeComboBox
            // 
            this.CardTypeComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardTypeComboBox.FormattingEnabled = true;
            this.CardTypeComboBox.Items.AddRange(new object[] {
            "Дебетовая",
            "Кредитная"});
            this.CardTypeComboBox.Location = new System.Drawing.Point(0, 20);
            this.CardTypeComboBox.Name = "CardTypeComboBox";
            this.CardTypeComboBox.Size = new System.Drawing.Size(331, 23);
            this.CardTypeComboBox.TabIndex = 6;
            // 
            // CardCurrencyComboBox
            // 
            this.CardCurrencyComboBox.FormattingEnabled = true;
            this.CardCurrencyComboBox.Items.AddRange(new object[] {
            "RUB",
            "EUR",
            "USD"});
            this.CardCurrencyComboBox.Location = new System.Drawing.Point(0, 23);
            this.CardCurrencyComboBox.Name = "CardCurrencyComboBox";
            this.CardCurrencyComboBox.Size = new System.Drawing.Size(331, 23);
            this.CardCurrencyComboBox.TabIndex = 7;
            this.CardCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.CardCurrencyComboBox_SelectedIndexChanged);
            // 
            // CardPaymentSystemComboBox
            // 
            this.CardPaymentSystemComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardPaymentSystemComboBox.FormattingEnabled = true;
            this.CardPaymentSystemComboBox.Items.AddRange(new object[] {
            "VISA",
            "MasterCard",
            "МИР"});
            this.CardPaymentSystemComboBox.Location = new System.Drawing.Point(0, 20);
            this.CardPaymentSystemComboBox.Name = "CardPaymentSystemComboBox";
            this.CardPaymentSystemComboBox.Size = new System.Drawing.Size(331, 23);
            this.CardPaymentSystemComboBox.TabIndex = 8;
            this.CardPaymentSystemComboBox.SelectedIndexChanged += new System.EventHandler(this.CardPaymentSystemComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 3);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 3);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 3);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel4.Location = new System.Drawing.Point(1, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 3);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // CardPinCodeNumericUpDown
            // 
            this.CardPinCodeNumericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardPinCodeNumericUpDown.Location = new System.Drawing.Point(0, 20);
            this.CardPinCodeNumericUpDown.Name = "CardPinCodeNumericUpDown";
            this.CardPinCodeNumericUpDown.Size = new System.Drawing.Size(333, 23);
            this.CardPinCodeNumericUpDown.TabIndex = 14;
            this.CardPinCodeNumericUpDown.ValueChanged += new System.EventHandler(this.CardPinCodeNumericUpDown_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::BankApp.Properties.Resources._8544767;
            this.pictureBox1.Location = new System.Drawing.Point(161, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.CardTypeComboBox);
            this.panel5.Controls.Add(this.CardTypeLabel);
            this.panel5.Controls.Add(this.CreateCardButton);
            this.panel5.Location = new System.Drawing.Point(17, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 315);
            this.panel5.TabIndex = 16;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.CardCurrencyComboBox);
            this.panel6.Controls.Add(this.CardCurrencyLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 46);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(331, 68);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.CardPaymentSystemComboBox);
            this.panel7.Controls.Add(this.CardPaymentSystemLabel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 114);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(331, 52);
            this.panel7.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.Controls.Add(this.CardPinCodeNumericUpDown);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.CardPinCodeLabel);
            this.panel8.Location = new System.Drawing.Point(15, 257);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(333, 72);
            this.panel8.TabIndex = 17;
            // 
            // AddBankCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(366, 418);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBankCardForm";
            this.Text = "AddBankCardForm";
            this.Load += new System.EventHandler(this.AddBankCardForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddBankCardForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CardPinCodeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button CloseButton;
        private Button CreateCardButton;
        private Label CardTypeLabel;
        private Label CardCurrencyLabel;
        private Label CardPaymentSystemLabel;
        private Label CardPinCodeLabel;
        private ComboBox CardTypeComboBox;
        private ComboBox CardCurrencyComboBox;
        private ComboBox CardPaymentSystemComboBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown CardPinCodeNumericUpDown;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panel8;
    }
}