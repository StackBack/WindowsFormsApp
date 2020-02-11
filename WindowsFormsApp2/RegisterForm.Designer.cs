namespace WindowsFormsApp2
{
    partial class RegisterForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.recheckPassField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.linkLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 62);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Mistral", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(532, 62);
            this.label4.TabIndex = 0;
            this.label4.Text = "Регистрация";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonReg
            // 
            this.buttonReg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonReg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReg.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(203, 431);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(146, 41);
            this.buttonReg.TabIndex = 16;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordField.Font = new System.Drawing.Font("Maiandra GD", 21.75F);
            this.passwordField.Location = new System.Drawing.Point(203, 291);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(284, 42);
            this.passwordField.TabIndex = 15;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(59, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 42);
            this.label3.TabIndex = 14;
            this.label3.Text = "Пароль :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(59, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "E-mail :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailField
            // 
            this.emailField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailField.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailField.Location = new System.Drawing.Point(203, 80);
            this.emailField.Multiline = true;
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(284, 39);
            this.emailField.TabIndex = 13;
            // 
            // recheckPassField
            // 
            this.recheckPassField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.recheckPassField.Font = new System.Drawing.Font("Maiandra GD", 21.75F);
            this.recheckPassField.Location = new System.Drawing.Point(203, 361);
            this.recheckPassField.Name = "recheckPassField";
            this.recheckPassField.Size = new System.Drawing.Size(284, 42);
            this.recheckPassField.TabIndex = 17;
            this.recheckPassField.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(34, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Пароль п :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(80, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 42);
            this.label5.TabIndex = 19;
            this.label5.Text = "Имья :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameField.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(203, 156);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(284, 39);
            this.nameField.TabIndex = 20;
            this.nameField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(33, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 42);
            this.label6.TabIndex = 21;
            this.label6.Text = "Фамилия :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surnameField
            // 
            this.surnameField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.surnameField.Font = new System.Drawing.Font("Maiandra GD", 21.75F);
            this.surnameField.Location = new System.Drawing.Point(203, 222);
            this.surnameField.Multiline = true;
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(284, 39);
            this.surnameField.TabIndex = 22;
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLogin.ForeColor = System.Drawing.Color.PaleGreen;
            this.linkLogin.Location = new System.Drawing.Point(368, 436);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(164, 33);
            this.linkLogin.TabIndex = 23;
            this.linkLogin.Text = "Авторизоваться";
            this.linkLogin.Click += new System.EventHandler(this.linkLogin_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(532, 484);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recheckPassField);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox recheckPassField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.Label linkLogin;
    }
}