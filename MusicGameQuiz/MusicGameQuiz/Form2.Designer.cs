namespace MusicGameQuiz
{
    partial class Form2
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
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnSubmitLogin = new System.Windows.Forms.Button();
            this.lblUname = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblLoginDetailIncorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(64, 75);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(262, 22);
            this.txtUname.TabIndex = 0;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(64, 145);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(262, 22);
            this.txtPwd.TabIndex = 1;
            // 
            // btnSubmitLogin
            // 
            this.btnSubmitLogin.Location = new System.Drawing.Point(154, 240);
            this.btnSubmitLogin.Name = "btnSubmitLogin";
            this.btnSubmitLogin.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitLogin.TabIndex = 2;
            this.btnSubmitLogin.Text = "Submit";
            this.btnSubmitLogin.UseVisualStyleBackColor = true;
            this.btnSubmitLogin.Click += new System.EventHandler(this.btnSubmitLogin_Click);
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Location = new System.Drawing.Point(61, 29);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(73, 17);
            this.lblUname.TabIndex = 3;
            this.lblUname.Text = "Username";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(61, 113);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(69, 17);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "Password";
            // 
            // lblLoginDetailIncorrect
            // 
            this.lblLoginDetailIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginDetailIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblLoginDetailIncorrect.Location = new System.Drawing.Point(46, 191);
            this.lblLoginDetailIncorrect.Name = "lblLoginDetailIncorrect";
            this.lblLoginDetailIncorrect.Size = new System.Drawing.Size(300, 20);
            this.lblLoginDetailIncorrect.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 321);
            this.Controls.Add(this.lblLoginDetailIncorrect);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.btnSubmitLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUname);
            this.Name = "Form2";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnSubmitLogin;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblLoginDetailIncorrect;
    }
}