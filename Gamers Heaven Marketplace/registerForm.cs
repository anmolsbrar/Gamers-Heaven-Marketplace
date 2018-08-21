using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gamers_Heaven_Marketplace
{
    public partial class registerForm : Form
    {
        private SqlConnection connection = new SqlConnection(@"workstation id=gamersHeaven.mssql.somee.com;packet size=4096;user id=anmolsbrar_SQLLogin_1;pwd=bfpxou5b3u;data source=gamersHeaven.mssql.somee.com;persist security info=False;initial catalog=gamersHeaven");
        private String registerQuery = "INSERT INTO [dbo].[login] (username, password, fName, lName, email, secQues) VALUES (@user, @pass, @fn, @ln, @email, @sec)";
        private string username = "SELECT COUNT (*) FROM [dbo].[login] WHERE username = @user";
        private string email = "SELECT COUNT (*) FROM [dbo].[login] WHERE email = @email";

        private string tick = "../images/tick.png";
        private string cross = "../images/cross.png";

        private bool isValidUser = false;
        private bool isValidEmail = false;

        public registerForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand register = new SqlCommand(registerQuery, connection);
            register.Parameters.AddWithValue("@user", usernameTextbox.Text);
            register.Parameters.AddWithValue("@pass", pass1Textbox.Text);
            register.Parameters.AddWithValue("@fn", fNameTextbox.Text);
            register.Parameters.AddWithValue("@ln", lNameTextBox.Text);
            register.Parameters.AddWithValue("@email", emailTextbox.Text);
            register.Parameters.AddWithValue("@sec", securityTextbox.Text);
            register.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            registerButton.Enabled = false;
            resizeImage(this);
            takenUserText.Visible = false;
            takenEmail.Visible = false;
        }

        private bool emptyTextCheck()
        {
            if (string.IsNullOrEmpty(fNameTextbox.Text) || string.IsNullOrEmpty(lNameTextBox.Text) || !isValidEmail ||
                !isValidUser || string.IsNullOrEmpty(pass1Textbox.Text) || string.IsNullOrEmpty(pass2TextBox.Text) || string.IsNullOrWhiteSpace(securityTextbox.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void resizeImage(registerForm reg)
        {
            foreach(Control c in reg.Controls)
            {
                if(c is PictureBox)
                {
                    PictureBox img = c as PictureBox;
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void termsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (emptyTextCheck() && termsCheckbox.Checked == true)
            {
                registerButton.Enabled = true;
            }
            else
            {
                registerButton.Enabled = false;
            }
        }

        private void pass2TextBox_TextChanged(object sender, EventArgs e)
        {
            if(pass2TextBox.Text != pass1Textbox.Text)
            {
                password2Tick.Load(cross);
            }
            else
            {
                password2Tick.Load(tick);
            }
        }

        private void fNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if(fNameTextbox.Text == "")
            {
                fnametick.Load(cross);
            }
            else
            {
                fnametick.Load(tick);
            }
        }

        private void pass1Textbox_TextChanged(object sender, EventArgs e)
        {
            if(pass1Textbox.Text == "")
            {
                passwordTick.Load(cross);
            }
            else
            {
                passwordTick.Load(tick);
            }
        }

        private void lNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(lNameTextBox.Text == "")
            {
                lnameTick.Load(cross);
            }
            else
            {
                lnameTick.Load(tick);
            }
        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand checkemail = new SqlCommand(email, connection);
            checkemail.Parameters.AddWithValue("@email", emailTextbox.Text);
            if (checkemail.ExecuteScalar().ToString() == "1")
            {
                isValidEmail = false;
                emailTick.Load(cross);
                takenEmail.Visible = true;
            }
            else
            {
                isValidEmail = true;
                emailTick.Load(tick);
            }
            connection.Close();
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand checkuser = new SqlCommand(username, connection);
            checkuser.Parameters.AddWithValue("@user", usernameTextbox.Text);
            if(checkuser.ExecuteScalar().ToString() == "1")
            {
                isValidUser = false;
                usernameTick.Load(cross);
                takenUserText.Visible = true;
            }
            else
            {
                isValidUser = true;
                usernameTick.Load(tick);
            }
            connection.Close();
        }
    }
}
