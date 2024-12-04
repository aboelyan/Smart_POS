using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_POS.Classes
{
    public class ClassLoading
    {
        private SqlCommand cmd;
        private SqlDataReader dr;
        public void loadSystemOptions()
        {
            cmd = new SqlCommand("Select Top 1 *from tbl_Option", adoClass.sqlCon);
            dr = null;
            try
            {
                if (adoClass.sqlCon.State != ConnectionState.Open) adoClass.sqlCon.Open();
                dr = cmd.ExecuteReader();
                declerationClass.systemOptions = new Dictionary<string, object>();
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        declerationClass.systemOptions.Add(dr.GetName(i), dr[dr.GetName(i)]);
                    }

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { adoClass.sqlCon.Close(); }

        }

    }
}
