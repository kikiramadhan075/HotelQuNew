using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penginapan
{
    public partial class FrmPreviewReport : Form
    {
        List<Report> reports;
        int bulan, tahun;

        public FrmPreviewReport(List<Report> reports, int bulan, int tahun)
        {
            InitializeComponent();

            this.reports = reports;
            this.bulan = bulan;
            this.tahun = tahun;
        }

        private void loadReport()
        {
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("month", this.bulan.ToString());
            parameters[1] = new ReportParameter("year", this.tahun.ToString());

            ReportDataSource rds = new ReportDataSource("DataSet1", reports.ToArray());
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.RefreshReport();
        }

        private void FrmPreviewReport_Load(object sender, EventArgs e)
        {
            loadReport();
        }
    }
}
