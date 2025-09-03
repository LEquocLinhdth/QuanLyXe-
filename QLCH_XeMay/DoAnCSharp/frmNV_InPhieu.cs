using Microsoft.Reporting.WinForms;
using System.Data;

namespace DoAnCSharp
{
    public partial class frmNV_InPhieu : Form
    {
        Modify modify = new Modify();
        
        string maphieu;
        int loaiphieu;

        public frmNV_InPhieu()
        {
            InitializeComponent();
        }
        public frmNV_InPhieu(int loaiphieu, string maphieu)  //1 là hóa đơn, 2 là phiếu nhập
        {
            InitializeComponent();
            this.maphieu = maphieu;
            this.loaiphieu = loaiphieu;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            if (loaiphieu == 1)
            {
                reportViewer1.LocalReport.ReportPath = "MauHoaDon.rdlc";

                DataSet1TableAdapters.HoaDonTableTableAdapter adapter = new DataSet1TableAdapters.HoaDonTableTableAdapter();
                DataSet1.HoaDonTableDataTable datatable = new DataSet1.HoaDonTableDataTable();
                adapter.Fill(datatable);
                string sqlFilter = "MAHD = '" + this.maphieu + "'";

                DataRow[] filteredRows = datatable.Select(sqlFilter);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", filteredRows));

                reportViewer1.RefreshReport();
            }
            else if (loaiphieu == 2)
            {
                reportViewer1.LocalReport.ReportPath = "MauPhieuNhap.rdlc";

                DataSet1TableAdapters.PhieuNhapTableTableAdapter adapter = new DataSet1TableAdapters.PhieuNhapTableTableAdapter();
                DataSet1.PhieuNhapTableDataTable datatable = new DataSet1.PhieuNhapTableDataTable();
                adapter.Fill(datatable);
                string sqlFilter = "MAPN = '" + this.maphieu + "'";

                DataRow[] filteredRows = datatable.Select(sqlFilter);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", filteredRows));

                reportViewer1.RefreshReport();
            }    
        }

    }
}
