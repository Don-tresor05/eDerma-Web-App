using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Practicing
{
    public partial class PatientsForm : Form
    {
        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            // Load patient appointments and available doctors/services
            LoadAppointments();
            LoadDoctorsAndServices();
        }

        private void LoadAppointments()
        {
            string connectionString = "Data Source=Don;Initial Catalog=eDerma;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT [date-time], doctor.fullname, service.service_Name, status " +
                               "FROM appointment " +
                               "JOIN doctor ON appointment.doctor = doctor.doctor_ID " +
                               "JOIN service ON appointment.service = service.service_ID " +
                               "WHERE appointment.patient = @patientId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientId", "your_patient_id"); // Replace with actual patient ID
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

        private void LoadDoctorsAndServices()
        {
            string connectionString = "Data Source=Don;Initial Catalog=eDerma;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Load doctors
                string queryDoctors = "SELECT doctor_ID, fullname FROM doctor";
                using (SqlCommand cmdDoctors = new SqlCommand(queryDoctors, conn))
                {
                    SqlDataReader readerDoctors = cmdDoctors.ExecuteReader();
                    cmbDoctors.Items.Clear();
                    while (readerDoctors.Read())
                    {
                        cmbDoctors.Items.Add(new { Text = readerDoctors["fullname"].ToString(), Value = readerDoctors["doctor_ID"].ToString() });
                    }
                    readerDoctors.Close();
                }

                // Load services
                string queryServices = "SELECT service_ID, service_Name FROM service";
                using (SqlCommand cmdServices = new SqlCommand(queryServices, conn))
                {
                    SqlDataReader readerServices = cmdServices.ExecuteReader();
                    cmbServices.Items.Clear();
                    while (readerServices.Read())
                    {
                        cmbServices.Items.Add(new { Text = readerServices["service_Name"].ToString(), Value = readerServices["service_ID"].ToString() });
                    }
                    readerServices.Close();
                }
            }
        }

        private void btnViewAppointments_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void btnSendAppointment_Click(object sender, EventArgs e)
        {
            if (cmbDoctors.SelectedItem == null || cmbServices.SelectedItem == null)
            {
                MessageBox.Show("Please select a doctor and a service.");
                return;
            }

            string connectionString = "Data Source=Don;Initial Catalog=eDerma;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO appointment (patient, doctor, service, [date-time], status) " +
                               "VALUES (@patient, @doctor, @service, @datetime, 'Pending')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patient", "your_patient_id"); // Replace with actual patient ID
                    cmd.Parameters.AddWithValue("@doctor", ((dynamic)cmbDoctors.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@service", ((dynamic)cmbServices.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@datetime", dtpAppointmentDate.Value);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Appointment request sent!");
            LoadAppointments();
        }


        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            if (listViewAppointments.SelectedItems.Count > 0)
            {
                string appointmentId = listViewAppointments.SelectedItems[0].Tag.ToString();
                string connectionString = "Data Source=Don;Initial Catalog=eDerma;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE appointment SET doctor = @doctor, service = @service, [date-time] = @datetime WHERE appointment_ID = @appointmentId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctor", ((dynamic)cmbDoctors.SelectedItem).Value);
                        cmd.Parameters.AddWithValue("@service", ((dynamic)cmbServices.SelectedItem).Value);
                        cmd.Parameters.AddWithValue("@datetime", dtpAppointmentDate.Value);
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Appointment updated!");
                LoadAppointments();
            }
            else
            {
                MessageBox.Show("Please select an appointment to update.");
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (listViewAppointments.SelectedItems.Count > 0)
            {
                string appointmentId = listViewAppointments.SelectedItems[0].Tag.ToString();
                string connectionString = "Data Source=Don;Initial Catalog=eDerma;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM appointment WHERE appointment_ID = @appointmentId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Appointment deleted!");
                LoadAppointments();
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }
        }

        private void listViewAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
