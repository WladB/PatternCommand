
namespace UkrainianLanguage_VirtualSimulator
{
    partial class Reestration
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
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmPasswordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(116, 47);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(201, 20);
            this.LoginTB.TabIndex = 0;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(116, 105);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '•';
            this.PasswordTB.Size = new System.Drawing.Size(201, 20);
            this.PasswordTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логін";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Придумайте пароль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Зареєструватися";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReestrationButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Повторіть пароль";
            // 
            // ConfirmPasswordTB
            // 
            this.ConfirmPasswordTB.Location = new System.Drawing.Point(116, 144);
            this.ConfirmPasswordTB.Name = "ConfirmPasswordTB";
            this.ConfirmPasswordTB.PasswordChar = '•';
            this.ConfirmPasswordTB.Size = new System.Drawing.Size(201, 20);
            this.ConfirmPasswordTB.TabIndex = 2;
            // 
            // Reestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 254);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConfirmPasswordTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reestration";
            this.Text = "Реєстрація";
            this.Load += new System.EventHandler(this.Reestration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConfirmPasswordTB;
    }
}