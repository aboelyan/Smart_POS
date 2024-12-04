using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_POS.Classes
{
    public class adoClass
    {
        public static SqlConnection sqlCon;
        public static SqlCommandBuilder builder;
        public static void setConnection()
        {
            sqlCon = new SqlConnection(Properties.Settings.Default.connection);
        }
    }
}
