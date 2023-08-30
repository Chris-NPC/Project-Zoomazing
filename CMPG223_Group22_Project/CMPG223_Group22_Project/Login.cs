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

namespace CMPG223_Group22_Project
{
    public partial class Login : Form
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataAdapter adpater;
        SqlDataReader reader;

        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angelina Ramsunar\OneDrive\Documents\GitHub\Project-Zoomazing\CMPG223_Group22_Project\CMPG223_Group22_Project\Database1.mdf;Integrated Security=True";
        
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LoginName, LoginPassWord;
            LoginName = txtUsername.Text;
            LoginPassWord = txtPassword.Text;
            try
            {
                // SQL query to retrieve the user with the provided ID and password
                string query = "SELECT COUNT(*) FROM login WHERE Username= @LoginName AND Password = @LoginPassword";

                using (SqlConnection connect = new SqlConnection(connectString))
                {
                    connect.Open();

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@LoginName", LoginName);
                        command.Parameters.AddWithValue("@LoginPassword", LoginPassWord);

                        // Execute the query
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            // User exists and password is correct
                           
                        }
                        else
                        {
                            // User does not exist or password is incorrect
                            MessageBox.Show("Incorrect name and password as been entered");// Handle the error or display a message to the user
                        }
                    }
                    //Closing the connection to the database
                    connect.Close();
                }


            }
            catch (Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = '*';//does not show what the user is typing
        }
    }
}
