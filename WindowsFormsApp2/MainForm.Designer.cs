namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.helloText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloText
            // 
            this.helloText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helloText.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.helloText.Location = new System.Drawing.Point(0, 0);
            this.helloText.Name = "helloText";
            this.helloText.Size = new System.Drawing.Size(770, 356);
            this.helloText.TabIndex = 0;
            this.helloText.Text = "Hello, World!!!";
            this.helloText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(170, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello, World!!!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(770, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helloText);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloText;
        private System.Windows.Forms.Label label1;
    }
}