using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Practicing
{
    public partial class ManagersForm : Form
    {
        public ManagersForm()
        {
            InitializeComponent();
        }

        private void ManagersForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            string connectionString = "Data Source=Don;Initial Catalog=eDerma;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT [date-time], patient.fullname, doctor.fullname AS doctorName, service.service_Name, status " +
                               "FROM appointment " +
                               "JOIN patient ON appointment.patient = patient.patient_ID " +
                               "JOIN doctor ON appointment.doctor = doctor.doctor_ID " +
                               "JOIN service ON appointment.service = service.service_ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    listViewAppointments.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["date-time"].ToString());
                        item.SubItems.Add(reader["fullname"].ToString());
                        item.SubItems.Add(reader["doctorName"].ToString());
                        item.SubItems.Add(reader["service_Name"].ToString());
                        item.SubItems.Add(reader["status"].ToString());
                        listViewAppointments.Items.Add(item);
                    }
                }
            }
        }

        private void btnRegisterDoctor_Click(object sender, EventArgs e)
        {
            // Implement logic to register a new doctor
            MessageBox.Show("Register Doctor functionality to be implemented.");
        }

        private void btnRegisterService_Click(object sender, EventArgs e)
        {
            // Implement logic to register a new service and assign it to a doctor
            MessageBox.Show("Register Service functionality to be implemented.");
        }

        private void btnRefreshAppointments_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }
    }
}
