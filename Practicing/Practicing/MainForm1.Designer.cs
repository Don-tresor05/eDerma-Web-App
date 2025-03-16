namespace Practicing
{
    partial class MainForm1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem patientsMenu;
        private System.Windows.Forms.ToolStripMenuItem doctorsMenu;
        private System.Windows.Forms.ToolStripMenuItem managersMenu;
        private System.Windows.Forms.Panel contentPanel;

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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.patientsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.managersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsMenu,
            this.doctorsMenu,
            this.managersMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // patientsMenu
            // 
            this.patientsMenu.Name = "patientsMenu";
            this.patientsMenu.Size = new System.Drawing.Size(74, 24);
            this.patientsMenu.Text = "Students";
            this.patientsMenu.Click += new System.EventHandler(this.patientsMenu_Click);
            // 
            // doctorsMenu
            // 
            this.doctorsMenu.Name = "doctorsMenu";
            this.doctorsMenu.Size = new System.Drawing.Size(75, 24);
            this.doctorsMenu.Text = "Lecturer";
            this.doctorsMenu.Click += new System.EventHandler(this.doctorsMenu_Click);
            // 
            // managersMenu
            // 
            this.managersMenu.Name = "managersMenu";
            this.managersMenu.Size = new System.Drawing.Size(88, 24);
            this.managersMenu.Text = "HOD";
            this.managersMenu.Click += new System.EventHandler(this.managersMenu_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 28);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(800, 422);
            this.contentPanel.TabIndex = 1;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm1";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
