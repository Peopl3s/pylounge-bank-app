namespace BankApp.Forms
{
    partial class SendToForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransferButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FromCardPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FromCardCvvCodeTextBox = new System.Windows.Forms.TextBox();
            this.FromCardDateTextBox = new System.Windows.Forms.TextBox();
            this.FromCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ToCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.TransferAmountTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.FromCardPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(514, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "С карты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Карта получателя";
            // 
            // TransferButton
            // 
            this.TransferButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.TransferButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TransferButton.FlatAppearance.BorderSize = 0;
            this.TransferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TransferButton.Location = new System.Drawing.Point(0, 351);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(454, 68);
            this.TransferButton.TabIndex = 3;
            this.TransferButton.Text = "Перевести";
            this.TransferButton.UseVisualStyleBackColor = false;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сумма";
            // 
            // FromCardPanel
            // 
            this.FromCardPanel.Controls.Add(this.panel10);
            this.FromCardPanel.Controls.Add(this.panel2);
            this.FromCardPanel.Controls.Add(this.panel1);
            this.FromCardPanel.Controls.Add(this.FromCardCvvCodeTextBox);
            this.FromCardPanel.Controls.Add(this.FromCardDateTextBox);
            this.FromCardPanel.Controls.Add(this.FromCardNumberTextBox);
            this.FromCardPanel.Controls.Add(this.label6);
            this.FromCardPanel.Controls.Add(this.label5);
            this.FromCardPanel.Controls.Add(this.label4);
            this.FromCardPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FromCardPanel.Location = new System.Drawing.Point(0, 34);
            this.FromCardPanel.Name = "FromCardPanel";
            this.FromCardPanel.Size = new System.Drawing.Size(454, 152);
            this.FromCardPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel2.Location = new System.Drawing.Point(11, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 3);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel1.Location = new System.Drawing.Point(11, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 3);
            this.panel1.TabIndex = 6;
            // 
            // FromCardCvvCodeTextBox
            // 
            this.FromCardCvvCodeTextBox.Location = new System.Drawing.Point(162, 101);
            this.FromCardCvvCodeTextBox.Name = "FromCardCvvCodeTextBox";
            this.FromCardCvvCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.FromCardCvvCodeTextBox.TabIndex = 5;
            this.FromCardCvvCodeTextBox.Text = "***";
            // 
            // FromCardDateTextBox
            // 
            this.FromCardDateTextBox.Location = new System.Drawing.Point(11, 102);
            this.FromCardDateTextBox.Name = "FromCardDateTextBox";
            this.FromCardDateTextBox.Size = new System.Drawing.Size(100, 23);
            this.FromCardDateTextBox.TabIndex = 4;
            this.FromCardDateTextBox.Text = "XX/XX";
            // 
            // FromCardNumberTextBox
            // 
            this.FromCardNumberTextBox.Location = new System.Drawing.Point(11, 32);
            this.FromCardNumberTextBox.Name = "FromCardNumberTextBox";
            this.FromCardNumberTextBox.Size = new System.Drawing.Size(440, 23);
            this.FromCardNumberTextBox.TabIndex = 3;
            this.FromCardNumberTextBox.Text = "0000 0000 0000 0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(163, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "CVV-код";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Срок действия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Номер карты";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(448, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Номер карты";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.ToCardNumberTextBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 70);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel4.Location = new System.Drawing.Point(3, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 3);
            this.panel4.TabIndex = 10;
            // 
            // ToCardNumberTextBox
            // 
            this.ToCardNumberTextBox.Location = new System.Drawing.Point(3, 27);
            this.ToCardNumberTextBox.Name = "ToCardNumberTextBox";
            this.ToCardNumberTextBox.Size = new System.Drawing.Size(448, 23);
            this.ToCardNumberTextBox.TabIndex = 9;
            // 
            // TransferAmountTextBox
            // 
            this.TransferAmountTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransferAmountTextBox.Location = new System.Drawing.Point(0, 22);
            this.TransferAmountTextBox.Name = "TransferAmountTextBox";
            this.TransferAmountTextBox.Size = new System.Drawing.Size(454, 23);
            this.TransferAmountTextBox.TabIndex = 10;
            this.TransferAmountTextBox.Text = "00.00";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(454, 3);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.FromCardPanel);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(454, 183);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 183);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(454, 106);
            this.panel7.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.TransferAmountTextBox);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 289);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(454, 51);
            this.panel8.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.TransferButton);
            this.panel9.Location = new System.Drawing.Point(47, 42);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(454, 419);
            this.panel9.TabIndex = 15;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel10.Location = new System.Drawing.Point(162, 124);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 3);
            this.panel10.TabIndex = 7;
            // 
            // SendToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(549, 498);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendToForm";
            this.Text = "SendToForm";
            this.Load += new System.EventHandler(this.SendToForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SendToForm_MouseDown);
            this.FromCardPanel.ResumeLayout(false);
            this.FromCardPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button CloseButton;
        private Label label1;
        private Label label2;
        private Button TransferButton;
        private Label label3;
        private Panel FromCardPanel;
        private Panel panel2;
        private Panel panel1;
        private TextBox FromCardCvvCodeTextBox;
        private TextBox FromCardDateTextBox;
        private TextBox FromCardNumberTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Panel panel3;
        private Panel panel4;
        private TextBox ToCardNumberTextBox;
        private TextBox TransferAmountTextBox;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
    }
}