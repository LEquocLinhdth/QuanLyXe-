using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSharp
{
    class Connection
    {
        //private static string stringConnection = @"Data Source=LAPTOP-3OTUQJ91\TRUONGSQL;Initial Catalog=QLXM;Integrated Security=True";

        private static string stringConnection = @"Data Source=LAPTOP-3OTUQJ91\TRUONGSQL;Initial Catalog=QLXM;Persist Security Info=True;User ID=sa;Password=sql2022;Encrypt=False";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
