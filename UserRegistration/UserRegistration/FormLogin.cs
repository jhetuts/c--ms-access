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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        DBConnectionCenter dbCon = new DBConnectionCenter();

        private void Form1_Load(object sender, EventArgs e)
        {
            dbCon.ConnectDB();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (user_email.Text.Equals(""))
            {
                MessageBox.Show("Please input your email", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (user_password.Text.Equals(""))
            {
                MessageBox.Show("Please input your password", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataSet dsAction = new DataSet("UserData");
            string sqlSaveQuery = "SELECT * FROM tbl_users WHERE user_email = '" + user_email.Text + "'";
            dsAction = dbCon.ShowData(sqlSaveQuery, "tbl_users", dsAction);

            if (dsAction.Tables["tbl_users"].Rows.Count > 0)
            {
                bool passwordIsMatch = BCryptNet.Verify(user_password.Text, dsAction.Tables["tbl_users"].Rows[0]["user_password"].ToString());

                if (passwordIsMatch)
                {
                    dbCon.userLastName = dsAction.Tables["tbl_users"].Rows[0]["user_lname"].ToString();
                    dbCon.userFirstName = dsAction.Tables["tbl_users"].Rows[0]["user_fname"].ToString();
                    dbCon.userEmail = dsAction.Tables["tbl_users"].Rows[0]["user_email"].ToString();

                    MessageBox.Show("Password matched!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Password incorrect", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }

            if (dsAction.Tables["tbl_users"].Rows.Count <= 0)
            {
                MessageBox.Show("Email is not yet registered", "Form Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ShowRegisterForm()
        {
            
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            ShowRegisterForm();
        }
    }
}
