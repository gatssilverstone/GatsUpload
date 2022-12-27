using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sondeneme1
{
    internal class SqlBaglanti
    {
        public static SqlConnection connect = new SqlConnection("Data Source=176.53.65.202\\MSSQLSERVER2019; Initial Catalog=zenokodc_IstocPosProtoype; Persist Security Info=True;User ID=zenokodc_IstocPosProtoype;Password=Yusuf2013.");

        public static void CheckConnection(SqlConnection tempConnection) {
            if (tempConnection.State==ConnectionState.Closed)
            {
                tempConnection.Open();
            }

            
        }
    }
}
