namespace UserRegistration
{
    partial class FormRegister
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
            this.user_fname = new System.Windows.Forms.TextBox();
            this.user_lname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.user_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reg_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.MaskedTextBox();
            this.user_cpassword = new System.Windows.Forms.MaskedTextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_fname
            // 
            this.user_fname.Location = new System.Drawing.Point(30, 115);
            this.user_fname.Name = "user_fname";
            this.user_fname.Size = new System.Drawing.Size(276, 20);
            this.user_fname.TabIndex = 0;
            // 
            // user_lname
            // 
            this.user_lname.Location = new System.Drawing.Point(30, 162);
            this.user_lname.Name = "user_lname";
            this.user_lname.Size = new System.Drawing.Size(276, 20);
            this.user_lname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // user_username
            // 
            this.user_username.Location = new System.Drawing.Point(30, 208);
            this.user_username.Name = "user_username";
            this.user_username.Size = new System.Drawing.Size(276, 20);
            this.user_username.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // user_email
            // 
            this.user_email.Location = new System.Drawing.Point(30, 255);
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(276, 20);
            this.user_email.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirm Password";
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(205, 386);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(101, 27);
            this.reg_btn.TabIndex = 7;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Register";
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(30, 300);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '*';
            this.user_password.Size = new System.Drawing.Size(276, 20);
            this.user_password.TabIndex = 5;
            // 
            // user_cpassword
            // 
            this.user_cpassword.Location = new System.Drawing.Point(30, 349);
            this.user_cpassword.Name = "user_cpassword";
            this.user_cpassword.PasswordChar = '*';
            this.user_cpassword.Size = new System.Drawing.Size(276, 20);
            this.user_cpassword.TabIndex = 6;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(98, 386);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(101, 27);
            this.login_btn.TabIndex = 14;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 439);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.user_cpassword);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_lname);
            this.Controls.Add(this.user_fname);
            this.Name = "FormRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_fname;
        private System.Windows.Forms.TextBox user_lname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox user_password;
        private System.Windows.Forms.MaskedTextBox user_cpassword;
        private System.Windows.Forms.Button login_btn;
    }
}

