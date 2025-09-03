namespace DoAnCSharp
{
    partial class frmNV_InPhieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNV_InPhieu));
            rpHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            label1 = new Label();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // rpHoaDon
            // 
            rpHoaDon.Location = new Point(12, 51);
            rpHoaDon.Name = "rpHoaDon";
            rpHoaDon.ServerReport.BearerToken = null;
            rpHoaDon.Size = new Size(795, 574);
            rpHoaDon.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold);
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 31);
            label1.TabIndex = 1;
            label1.Text = "IN HÓA ĐƠN";
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(943, 664);
            reportViewer1.TabIndex = 0;
            // 
            // frmInHoaDon
            // 
            ClientSize = new Size(943, 664);
            Controls.Add(reportViewer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInHoaDon";
            Text = "IN HÓA ĐƠN";
            Load += frmInHoaDon_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpHoaDon;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}