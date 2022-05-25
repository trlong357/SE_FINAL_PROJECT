using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class ConnectSQL
    {
        internal static SqlConnection SQLconnect()
        {
            string servername = ".";
            string database = "DailyBanHang";

            string connectionString = "Server=" + servername + "; Database=" + database + "; Integrated Security=True;";

            SqlConnection conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}
