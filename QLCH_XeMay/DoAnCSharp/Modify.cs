using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAnCSharp
{
    class Modify
    {
        public Modify()
        {

        }

        SqlDataAdapter dataAdapter;
        SqlCommand command;
        DataTable dataTable;

        // dùng để trả về table theo lệnh sql
        public DataTable Table(string query)
        {
            using(SqlConnection conn = Connection.GetSqlConnection())
            {
                dataTable = new DataTable();
                conn.Open();
                dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(dataTable);
                conn.Close();
            }
            return dataTable;
        }
        //Connection.GetSqlConnection()

        // dùng để thực thi lệnh sql ví dụ thêm, xóa, sửa...
        public void Command(string query) 
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
