using System;
using System.Windows.Forms;

namespace Practicing
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            // Initialization code if necessary
        }

        private void patientsMenu_Click(object sender, EventArgs e)
        {
            LoadPatientsForm();
        }

        private void doctorsMenu_Click(object sender, EventArgs e)
        {
            LoadDoctorsForm();
        }

        private void managersMenu_Click(object sender, EventArgs e)
        {
            LoadManagersForm();
        }

        private void LoadPatientsForm()
        {
            contentPanel.Controls.Clear();

            PatientsForm patientsForm = new PatientsForm();
            patientsForm.TopLevel = false;
            patientsForm.FormBorderStyle = FormBorderStyle.None;
            patientsForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(patientsForm);
            patientsForm.Show();
        }

        private void LoadDoctorsForm()
        {
            contentPanel.Controls.Clear();

            DoctorsForm doctorsForm = new DoctorsForm(); // Ensure you have created this form
            doctorsForm.TopLevel = false;
            doctorsForm.FormBorderStyle = FormBorderStyle.None;
            doctorsForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(doctorsForm);
            doctorsForm.Show();
        }

        private void LoadManagersForm()
        {
            contentPanel.Controls.Clear();

            ManagersForm managersForm = new ManagersForm(); // Ensure you have created this form
            managersForm.TopLevel = false;
            managersForm.FormBorderStyle = FormBorderStyle.None;
            managersForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(managersForm);
            managersForm.Show();
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
