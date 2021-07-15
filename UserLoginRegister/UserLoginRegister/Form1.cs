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
    public partial class Form1 : Form, ICheckTextBoxIsEmpty
    {
        string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = "datasource = 127.0.0.1; port = 3306; username = app; password = limo65; database = app;";
        }
        public void checkTextBoxIsEmpty(TextBox textBox)
        {
            if (textBox.TextLength == 0)
            {
                throw new EmptyTextBoxException(textBox.Name + " is empty! Cannot make registration!");
            }
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                checkTextBoxIsEmpty(userNameBox);
                checkTextBoxIsEmpty(emailBox);
                checkTextBoxIsEmpty(passwordBox);
                createUser();
                
            }
            catch(EmptyTextBoxException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void createUser()
        {
            string query = "INSERT INTO `users`(`id`, `username`, `email`, `password`) VALUES (NULL," +
                " '" + userNameBox.Text + "', '" + emailBox.Text + "', '" + passwordBox.Text + "')";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("User succesfully registered!");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void alreadyHaveAnAccLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
            
        }
    }
}
