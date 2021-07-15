using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UserLoginRegister
{
    public partial class LoginForm : Form, ICheckTextBoxIsEmpty
    {
        string connectionString;
        public LoginForm()
        {
            InitializeComponent();
            connectionString = "datasource = 127.0.0.1; port = 3306; username = app; password = limo65; database = app;";
        }
       
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                checkTextBoxIsEmpty(emailBox);
                checkTextBoxIsEmpty(passwordBox);
                loginUser();

            }catch(EmptyTextBoxException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void loginUser()
        {
            string query = "SELECT * FROM users WHERE email='" + emailBox.Text + "' AND password='" + passwordBox.Text + "'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                string result = Convert.ToString(command.ExecuteScalar());
                if (String.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Incorrect email or password!");
                }
                else
                {
                    MessageBox.Show("You are successfully logged in!");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void checkTextBoxIsEmpty(TextBox textBox)
        {
            if(textBox.TextLength == 0)
            {
                throw new EmptyTextBoxException(textBox.Name + " is empty! Cannot make login!");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
