namespace Practicing
{
    partial class ManagersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewAppointments;
        private System.Windows.Forms.Button btnRegisterDoctor;
        private System.Windows.Forms.Button btnRegisterService;
        private System.Windows.Forms.Button btnRefreshAppointments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listViewAppointments = new System.Windows.Forms.ListView();
            this.btnRegisterDoctor = new System.Windows.Forms.Button();
            this.btnRegisterService = new System.Windows.Forms.Button();
            this.btnRefreshAppointments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAppointments
            // 
            this.listViewAppointments.Location = new System.Drawing.Point(20, 20);
            this.listViewAppointments.Name = "listViewAppointments";
            this.listViewAppointments.Size = new System.Drawing.Size(750, 200);
            this.listViewAppointments.TabIndex = 0;
            this.listViewAppointments.UseCompatibleStateImageBehavior = false;
            this.listViewAppointments.View = System.Windows.Forms.View.Details;
            // Add columns to the ListView
            this.listViewAppointments.Columns.Add("Date/Time", 150);
            this.listViewAppointments.Columns.Add("Patient", 150);
            this.listViewAppointments.Columns.Add("Doctor", 150);
            this.listViewAppointments.Columns.Add("Service", 150);
            this.listViewAppointments.Columns.Add("Status", 100);
            // 
            // btnRegisterDoctor
            // 
            this.btnRegisterDoctor.Location = new System.Drawing.Point(20, 240);
            this.btnRegisterDoctor.Name = "btnRegisterDoctor";
            this.btnRegisterDoctor.Size = new System.Drawing.Size(150, 30);
            this.btnRegisterDoctor.TabIndex = 1;
            this.btnRegisterDoctor.Text = "Register Doctor";
            this.btnRegisterDoctor.UseVisualStyleBackColor = true;
            this.btnRegisterDoctor.Click += new System.EventHandler(this.btnRegisterDoctor_Click);
            // 
            // btnRegisterService
            // 
            this.btnRegisterService.Location = new System.Drawing.Point(200, 240);
            this.btnRegisterService.Name = "btnRegisterService";
            this.btnRegisterService.Size = new System.Drawing.Size(150, 30);
            this.btnRegisterService.TabIndex = 2;
            this.btnRegisterService.Text = "Register Service";
            this.btnRegisterService.UseVisualStyleBackColor = true;
            this.btnRegisterService.Click += new System.EventHandler(this.btnRegisterService_Click);
            // 
            // btnRefreshAppointments
            // 
            this.btnRefreshAppointments.Location = new System.Drawing.Point(380, 240);
            this.btnRefreshAppointments.Name = "btnRefreshAppointments";
            this.btnRefreshAppointments.Size = new System.Drawing.Size(150, 30);
            this.btnRefreshAppointments.TabIndex = 3;
            this.btnRefreshAppointments.Text = "Refresh Appointments";
            this.btnRefreshAppointments.UseVisualStyleBackColor = true;
            this.btnRefreshAppointments.Click += new System.EventHandler(this.btnRefreshAppointments_Click);
            // 
            // ManagersForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.listViewAppointments);
            this.Controls.Add(this.btnRegisterDoctor);
            this.Controls.Add(this.btnRegisterService);
            this.Controls.Add(this.btnRefreshAppointments);
            this.Name = "ManagersForm";
            this.Text = "Managers Panel";
            this.Load += new System.EventHandler(this.ManagersForm_Load);
            this.ResumeLayout(false);
        }
    }
}
