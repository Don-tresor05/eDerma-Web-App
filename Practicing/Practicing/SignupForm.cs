using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;

namespace Practicing
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox with options
            cmbSex.Items.Add("Male");
            cmbSex.Items.Add("Female");
            cmbSex.Items.Add("Other");
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Don;Initial Catalog=eDerma;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

                string query = "INSERT INTO students (student_ID, fullname, age, sex, telephone, email, password) " +
                               "VALUES (@student_ID, @fullname, @age, @sex, @telephone, @eemail, @password)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@student_ID", Guid.NewGuid().ToString());
                    cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@sex", cmbSex.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@telephone", txtTelephone.Text);
                    cmd.Parameters.AddWithValue("@eemail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Signup successful!");

            // Redirect to SigninForm
            this.Hide();
            SigninForm signinForm = new SigninForm();
            signinForm.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SigninForm signinForm = new SigninForm();
            signinForm.ShowDialog();

        }
    }
}
