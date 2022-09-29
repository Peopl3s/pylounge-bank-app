namespace BankApp.Forms
{
    partial class ChangePhoneNumberForm
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
            this.AcceptChangePhoneNumberButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(435, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AcceptChangePhoneNumberButton
            // 
            this.AcceptChangePhoneNumberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.AcceptChangePhoneNumberButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AcceptChangePhoneNumberButton.FlatAppearance.BorderSize = 0;
            this.AcceptChangePhoneNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptChangePhoneNumberButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptChangePhoneNumberButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AcceptChangePhoneNumberButton.Location = new System.Drawing.Point(0, 74);
            this.AcceptChangePhoneNumberButton.Name = "AcceptChangePhoneNumberButton";
            this.AcceptChangePhoneNumberButton.Size = new System.Drawing.Size(457, 56);
            this.AcceptChangePhoneNumberButton.TabIndex = 1;
            this.AcceptChangePhoneNumberButton.Text = "Изменить номер телефона";
            this.AcceptChangePhoneNumberButton.UseVisualStyleBackColor = false;
            this.AcceptChangePhoneNumberButton.Click += new System.EventHandler(this.AcceptChangePhoneNumberButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите новый номер телефона:";
            // 
            // NewPhoneNumberTextBox
            // 
            this.NewPhoneNumberTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewPhoneNumberTextBox.Location = new System.Drawing.Point(0, 29);
            this.NewPhoneNumberTextBox.Name = "NewPhoneNumberTextBox";
            this.NewPhoneNumberTextBox.Size = new System.Drawing.Size(457, 23);
            this.NewPhoneNumberTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 3);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.NewPhoneNumberTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.AcceptChangePhoneNumberButton);
            this.panel2.Location = new System.Drawing.Point(11, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 130);
            this.panel2.TabIndex = 5;
            // 
            // ChangePhoneNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(479, 228);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePhoneNumberForm";
            this.Text = "ChangePhoneNumberForm";
            this.Load += new System.EventHandler(this.ChangePhoneNumberForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePhoneNumberForm_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button CloseButton;
        private Button AcceptChangePhoneNumberButton;
        private Label label1;
        private TextBox NewPhoneNumberTextBox;
        private Panel panel1;
        private Panel panel2;
    }
}