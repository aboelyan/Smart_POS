using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smart_POS.Forms;
using Smart_POS.Tools;

namespace Smart_POS.Classes
{
    public class printChecks
    {
        private SqlCommand cmd;
        private SqlDataReader dr;
        public void runPrintCheck(int checkId)
        {
            cmd = new SqlCommand("Select * from vwChecks where ID = '" + checkId + "'", adoClass.sqlCon);
            dr = null;
            dsChecks checks = new dsChecks();
            try
            {
                if (adoClass.sqlCon.State != ConnectionState.Open) adoClass.sqlCon.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow dro = checks.Tables["dtChecks"].NewRow();
                    dro["Id"] = dr["ID"];
                    dro["CheckDate"] = dr["CheckDate"];
                    dro["CheckTotal"] = dr["TotalCheck"];
                    dro["ItemId"] = dr["ItemID"];
                    dro["ItemName"] = dr["DES"];
                    dro["ItemQTY"] = dr["QTY"];
                    dro["ItemPrice"] = dr["Price"];
                    dro["ItemTotalPrice"] = dr["TotalPrice"];
                    checks.Tables["dtChecks"].Rows.Add(dro);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoClass.sqlCon.Close();
            }
            FormReports formReports = new FormReports();
            formReports.MainRV.LocalReport.ReportEmbeddedResource = "Smart_POS.Reports.rptCheck.rdlc";
            formReports.MainRV.LocalReport.DataSources.Clear();
            formReports.MainRV.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", checks.Tables["dtChecks"]));
            ReportParameter[] reportParameters = new ReportParameter[3];
            reportParameters[1] = new ReportParameter("Line1", declerationClass.systemOptions["ReciptLine2"].ToString());
            reportParameters[2] = new ReportParameter("Line2", declerationClass.systemOptions["ReciptLine2"].ToString());
            reportParameters[3] = new ReportParameter("RestName", declerationClass.systemOptions["RestName"].ToString());
            formReports.MainRV.LocalReport.SetParameters(reportParameters);
            formReports.ShowDialog();
        }
    }
}
