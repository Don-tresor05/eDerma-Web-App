using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;

namespace Practicing
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
        }

        private void SigninForm_Load(object sender, EventArgs e)
        {
            // Initialization code if necessary
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Signin button clicked!");

            string connectionString = "Data Source=Don;Initial Catalog=eDerma;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                MessageBox.Show("Connected to the database!");

                string query = "SELECT password FROM students WHERE email = @eemail";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eemail", txtEmail.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Email found!");
                        string storedHashedPassword = reader.GetString(0);
                        if (BCrypt.Net.BCrypt.Verify(txtPassword.Text, storedHashedPassword))
                        {
                            MessageBox.Show("Signin successful!");

                            // Hide the SigninForm and show the MainForm
                            this.Hide();
                            MainForm1 mainForm1 = new MainForm1();
                            mainForm1.Closed += (s, args) => this.Close();  // Ensure SigninForm closes when MainForm is closed
                            mainForm1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
            this.Close();
        }
    }
}
