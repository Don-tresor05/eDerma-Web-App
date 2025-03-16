namespace Practicing
{
    partial class DoctorsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewAppointments;
        private System.Windows.Forms.Button btnApproveAppointment;
        private System.Windows.Forms.Button btnDenyAppointment;

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
            this.btnApproveAppointment = new System.Windows.Forms.Button();
            this.btnDenyAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAppointments
            // 
            this.listViewAppointments.Location = new System.Drawing.Point(20, 20);
            this.listViewAppointments.Name = "listViewAppointments";
            this.listViewAppointments.Size = new System.Drawing.Size(510, 140);
            this.listViewAppointments.TabIndex = 0;
            this.listViewAppointments.UseCompatibleStateImageBehavior = false;
            this.listViewAppointments.View = System.Windows.Forms.View.Details;
            // Add columns to the ListView
            this.listViewAppointments.Columns.Add("Date/Time", 150);
            this.listViewAppointments.Columns.Add("Patient", 150);
            this.listViewAppointments.Columns.Add("Service", 150);
            this.listViewAppointments.Columns.Add("Status", 60);
            // 
            // btnApproveAppointment
            // 
            this.btnApproveAppointment.Location = new System.Drawing.Point(20, 180);
            this.btnApproveAppointment.Name = "btnApproveAppointment";
            this.btnApproveAppointment.Size = new System.Drawing.Size(150, 30);
            this.btnApproveAppointment.TabIndex = 1;
            this.btnApproveAppointment.Text = "Approve Appointment";
            this.btnApproveAppointment.UseVisualStyleBackColor = true;
            this.btnApproveAppointment.Click += new System.EventHandler(this.btnApproveAppointment_Click);
            // 
            // btnDenyAppointment
            // 
            this.btnDenyAppointment.Location = new System.Drawing.Point(200, 180);
            this.btnDenyAppointment.Name = "btnDenyAppointment";
            this.btnDenyAppointment.Size = new System.Drawing.Size(150, 30);
            this.btnDenyAppointment.TabIndex = 2;
            this.btnDenyAppointment.Text = "Deny Appointment";
            this.btnDenyAppointment.UseVisualStyleBackColor = true;
            this.btnDenyAppointment.Click += new System.EventHandler(this.btnDenyAppointment_Click);
            // 
            // DoctorsForm
            // 
            this.ClientSize = new System.Drawing.Size(850, 280);
            this.Controls.Add(this.listViewAppointments);
            this.Controls.Add(this.btnApproveAppointment);
            this.Controls.Add(this.btnDenyAppointment);
            this.Name = "DoctorsForm";
            this.Text = "Doctors Panel";
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
