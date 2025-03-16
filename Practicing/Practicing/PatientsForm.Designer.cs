namespace Practicing
{
    partial class PatientsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewAppointments;
        private System.Windows.Forms.ComboBox cmbDoctors;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Button btnViewAppointments;
        private System.Windows.Forms.Button btnSendAppointment;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Label lblDoctors;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblAppointmentDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listViewAppointments = new System.Windows.Forms.ListView();
            this.btnViewAppointments = new System.Windows.Forms.Button();
            this.btnSendAppointment = new System.Windows.Forms.Button();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.cmbDoctors = new System.Windows.Forms.ComboBox();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblDoctors = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewAppointments
            // 
            this.listViewAppointments.HideSelection = false;
            this.listViewAppointments.Location = new System.Drawing.Point(61, 145);
            this.listViewAppointments.Name = "listViewAppointments";
            this.listViewAppointments.Size = new System.Drawing.Size(510, 140);
            this.listViewAppointments.TabIndex = 0;
            this.listViewAppointments.UseCompatibleStateImageBehavior = false;
            this.listViewAppointments.View = System.Windows.Forms.View.Details;
            this.listViewAppointments.SelectedIndexChanged += new System.EventHandler(this.listViewAppointments_SelectedIndexChanged);
            // 
            // btnViewAppointments
            // 
            this.btnViewAppointments.Location = new System.Drawing.Point(61, 305);
            this.btnViewAppointments.Name = "btnViewAppointments";
            this.btnViewAppointments.Size = new System.Drawing.Size(150, 30);
            this.btnViewAppointments.TabIndex = 1;
            this.btnViewAppointments.Text = "View Courses";
            this.btnViewAppointments.UseVisualStyleBackColor = true;
            this.btnViewAppointments.Click += new System.EventHandler(this.btnViewAppointments_Click);
            // 
            // btnSendAppointment
            // 
            this.btnSendAppointment.Location = new System.Drawing.Point(268, 305);
            this.btnSendAppointment.Name = "btnSendAppointment";
            this.btnSendAppointment.Size = new System.Drawing.Size(203, 30);
            this.btnSendAppointment.TabIndex = 2;
            this.btnSendAppointment.Text = "Send Request to change group";
            this.btnSendAppointment.UseVisualStyleBackColor = true;
            this.btnSendAppointment.Click += new System.EventHandler(this.btnSendAppointment_Click);
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Location = new System.Drawing.Point(516, 305);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(240, 30);
            this.btnUpdateAppointment.TabIndex = 3;
            this.btnUpdateAppointment.Text = "Update Request of changing a group";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(791, 305);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(250, 30);
            this.btnDeleteAppointment.TabIndex = 4;
            this.btnDeleteAppointment.Text = "Delete Request to changing a group";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // cmbDoctors
            // 
            this.cmbDoctors.FormattingEnabled = true;
            this.cmbDoctors.Location = new System.Drawing.Point(753, 171);
            this.cmbDoctors.Name = "cmbDoctors";
            this.cmbDoctors.Size = new System.Drawing.Size(200, 24);
            this.cmbDoctors.TabIndex = 5;
            // 
            // cmbServices
            // 
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(753, 211);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(200, 24);
            this.cmbServices.TabIndex = 6;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(753, 251);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(200, 22);
            this.dtpAppointmentDate.TabIndex = 7;
            // 
            // lblDoctors
            // 
            this.lblDoctors.AutoSize = true;
            this.lblDoctors.Location = new System.Drawing.Point(673, 171);
            this.lblDoctors.Name = "lblDoctors";
            this.lblDoctors.Size = new System.Drawing.Size(50, 16);
            this.lblDoctors.TabIndex = 8;
            this.lblDoctors.Text = "Course";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Location = new System.Drawing.Point(673, 211);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(44, 16);
            this.lblServices.TabIndex = 9;
            this.lblServices.Text = "Group";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Location = new System.Drawing.Point(673, 251);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(71, 16);
            this.lblAppointmentDate.TabIndex = 10;
            this.lblAppointmentDate.Text = "Date/Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student Form";
            // 
            // PatientsForm
            // 
            this.ClientSize = new System.Drawing.Size(1101, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.lblDoctors);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.cmbServices);
            this.Controls.Add(this.cmbDoctors);
            this.Controls.Add(this.listViewAppointments);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Controls.Add(this.btnUpdateAppointment);
            this.Controls.Add(this.btnSendAppointment);
            this.Controls.Add(this.btnViewAppointments);
            this.Name = "PatientsForm";
            this.Text = "Student Panel";
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}
