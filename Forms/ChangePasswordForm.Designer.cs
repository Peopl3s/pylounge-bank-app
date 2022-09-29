namespace BankApp.Forms
{
    partial class ChangePasswordForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptChangePasswordButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 3);
            this.panel1.TabIndex = 14;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewPasswordTextBox.Location = new System.Drawing.Point(0, 34);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(425, 23);
            this.NewPasswordTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите новый пароль:";
            // 
            // AcceptChangePasswordButton
            // 
            this.AcceptChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.AcceptChangePasswordButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AcceptChangePasswordButton.FlatAppearance.BorderSize = 0;
            this.AcceptChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptChangePasswordButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptChangePasswordButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AcceptChangePasswordButton.Location = new System.Drawing.Point(0, 68);
            this.AcceptChangePasswordButton.Name = "AcceptChangePasswordButton";
            this.AcceptChangePasswordButton.Size = new System.Drawing.Size(425, 58);
            this.AcceptChangePasswordButton.TabIndex = 11;
            this.AcceptChangePasswordButton.Text = "Изменить пароль";
            this.AcceptChangePasswordButton.UseVisualStyleBackColor = false;
            this.AcceptChangePasswordButton.Click += new System.EventHandler(this.AcceptChangePasswordButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(411, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 30);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.NewPasswordTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.AcceptChangePasswordButton);
            this.panel2.Location = new System.Drawing.Point(23, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 126);
            this.panel2.TabIndex = 15;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(473, 226);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.Text = "1";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePasswordForm_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox NewPasswordTextBox;
        private Label label1;
        private Button AcceptChangePasswordButton;
        private Button CloseButton;
        private Panel panel2;
    }
}