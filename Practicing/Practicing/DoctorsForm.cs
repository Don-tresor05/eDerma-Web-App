using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Practicing
{
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            string connectionString = "Data Source=Don;Initial Catalog=eDerma;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT [date-time], students.fullname, service.service_Name, status " +
                               "FROM appointment " +
                               "JOIN students ON appointment.student = students.student_ID " +
                               "JOIN service ON appointment.service = service.service_ID " +
                               "WHERE appointment.doctor = @doctorId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@doctorId", "001"); // Replace with actual doctor ID
                    SqlDataReader reader = cmd.ExecuteReader();
                    listViewAppointments.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["date-time"].ToString());
                        item.SubItems.Add(reader["fullname"].ToString());
                        item.SubItems.Add(reader["service_Name"].ToString());
                        item.SubItems.Add(reader["status"].ToString());
                        listViewAppointments.Items.Add(item);
                    }
                }
            }
        }

        private void btnApproveAppointment_Click(object sender, EventArgs e)
        {
            UpdateAppointmentStatus("Approved");
        }

        private void btnDenyAppointment_Click(object sender, EventArgs e)
        {
            UpdateAppointmentStatus("Denied");
        }

        private void UpdateAppointmentStatus(string status)
        {
            if (listViewAppointments.SelectedItems.Count > 0)
            {
                string appointmentId = listViewAppointments.SelectedItems[0].Tag.ToString();
                string connectionString = "Data Source=Don;Initial Catalog=eDerma;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE appointment SET status = @status WHERE appointment_ID = @appointmentId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Appointment status updated!");
                LoadAppointments();
            }
            else
            {
                MessageBox.Show("Please select an appointment to update.");
            }
        }
    }
}
