namespace WindowsFormsApp2
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkRegistration = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Mistral", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginField.Font = new System.Drawing.Font("Maiandra GD", 21.75F);
            this.loginField.Location = new System.Drawing.Point(169, 101);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(284, 39);
            this.loginField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(25, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordField.Font = new System.Drawing.Font("Maiandra GD", 21.75F);
            this.passwordField.Location = new System.Drawing.Point(169, 173);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(284, 42);
            this.passwordField.TabIndex = 3;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(164, 258);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(146, 41);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Ввойти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkRegistration
            // 
            this.linkRegistration.AutoSize = true;
            this.linkRegistration.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkRegistration.ForeColor = System.Drawing.Color.Crimson;
            this.linkRegistration.Location = new System.Drawing.Point(323, 261);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(130, 33);
            this.linkRegistration.TabIndex = 5;
            this.linkRegistration.Text = "Регистрация";
            this.linkRegistration.Click += new System.EventHandler(this.linkRegistration_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(477, 311);
            this.Controls.Add(this.linkRegistration);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label linkRegistration;
    }
}