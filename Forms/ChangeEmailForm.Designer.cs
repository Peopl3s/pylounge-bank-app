namespace BankApp.Forms
{
    partial class ChangeEmailForm
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
            this.NewEmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptChangeEmailButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 3);
            this.panel1.TabIndex = 9;
            // 
            // NewEmailTextBox
            // 
            this.NewEmailTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewEmailTextBox.Location = new System.Drawing.Point(0, 34);
            this.NewEmailTextBox.Name = "NewEmailTextBox";
            this.NewEmailTextBox.Size = new System.Drawing.Size(446, 23);
            this.NewEmailTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите новую эл.почту:";
            // 
            // AcceptChangeEmailButton
            // 
            this.AcceptChangeEmailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.AcceptChangeEmailButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AcceptChangeEmailButton.FlatAppearance.BorderSize = 0;
            this.AcceptChangeEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptChangeEmailButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptChangeEmailButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AcceptChangeEmailButton.Location = new System.Drawing.Point(0, 87);
            this.AcceptChangeEmailButton.Name = "AcceptChangeEmailButton";
            this.AcceptChangeEmailButton.Size = new System.Drawing.Size(446, 42);
            this.AcceptChangeEmailButton.TabIndex = 6;
            this.AcceptChangeEmailButton.Text = "Сменить эл.почту";
            this.AcceptChangeEmailButton.UseVisualStyleBackColor = false;
            this.AcceptChangeEmailButton.Click += new System.EventHandler(this.AcceptChangeEmailButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(427, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.NewEmailTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.AcceptChangeEmailButton);
            this.panel2.Location = new System.Drawing.Point(14, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 129);
            this.panel2.TabIndex = 10;
            // 
            // ChangeEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(66)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(471, 194);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeEmailForm";
            this.Text = "ChangeEmailForm";
            this.Load += new System.EventHandler(this.ChangeEmailForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeEmailForm_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox NewEmailTextBox;
        private Label label1;
        private Button AcceptChangeEmailButton;
        private Button CloseButton;
        private Panel panel2;
    }
}