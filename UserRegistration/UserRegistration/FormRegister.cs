using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCryptNet = BCrypt.Net.BCrypt;

namespace UserRegistration
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        DBConnectionCenter dbCon = new DBConnectionCenter();
        

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if(user_fname.Text.Equals("") )
            {
                MessageBox.Show("Please input your first name", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user_lname.Text.Equals(""))
            {
                MessageBox.Show("Please input your last name", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user_username.Text.Equals(""))
            {
                MessageBox.Show("Please input your desired username", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user_email.Text.Equals(""))
            {
                MessageBox.Show("Please input your email", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user_password.Text.Equals(""))
            {
                MessageBox.Show("Please input your desired password", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user_cpassword.Text.Equals(""))
            {
                MessageBox.Show("Please confirm your password", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user_cpassword.Text != user_password.Text)
            {
                MessageBox.Show("Password mismatched confirmation", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataSet dsAction = new DataSet("UserData");
            string sqlSaveQuery = "SELECT * FROM tbl_users WHERE user_email = '" + user_email.Text +"'";
            dsAction = dbCon.ShowData(sqlSaveQuery, "tbl_users", dsAction);

            if(dsAction.Tables["tbl_users"].Rows.Count <= 0)
            {
                DataRow dr = dsAction.Tables["tbl_users"].NewRow();
                dr["user_fname"] = user_fname.Text;
                dr["user_lname"] = user_lname.Text;
                dr["user_email"] = user_email.Text;
                dr["user_name"] = user_username.Text;
                dr["user_password"] = BCryptNet.HashPassword(user_password.Text);

                dsAction.Tables["tbl_users"].Rows.Add(dr);

                dbCon.ReturnAda.Update(dsAction, "tbl_users");

                MessageBox.Show("Registration sucess!", "Form Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTexts();
                ShowLoginForm();
            }

            if (dsAction.Tables["tbl_users"].Rows.Count > 0) {
                MessageBox.Show("Email already used", "Form Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void ClearTexts()
        {
            user_fname.Text = "";
            user_lname.Text = "";
            user_email.Text = "";
            user_username.Text = "";
            user_password.Text = "";
            user_cpassword.Text = "";
        }

        private void ShowLoginForm()
        {
            Form loginForm = new Form();
            loginForm.ShowDialog();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            dbCon.ConnectDB();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
        }
    }
}
