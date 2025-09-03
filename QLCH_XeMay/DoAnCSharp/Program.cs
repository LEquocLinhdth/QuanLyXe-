using System;
using System.Data.SqlClient;
using System.Data;

namespace DoAnCSharp
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmHeThong());
        }

        public static int loadIndex(string filePath)
        {
            if (File.Exists(filePath))
            {
                // Đọc giá trị từ file nếu file tồn tại
                string content = File.ReadAllText(filePath);
                if (int.TryParse(content, out int value))
                {
                    return value;
                }
            }

            // Giá trị mặc định nếu file không tồn tại
            return 1;
        }

        public static void saveIndex(string filePath, int value)
        {
            // Lưu giá trị vào file
            File.WriteAllText(filePath, value.ToString());
        }

        public static string filePathIndex(string styleIndex)
        {
            string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..", "DoAnCSharp"));
            return projectDirectory+"\\Index\\" + styleIndex;
        }

        public static void transmitDataToTable(string tableName, DataTable dtable, SqlConnection conn) // Truyền dữ liệu vào bảng trong sql
        {
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
            {
                bulkCopy.DestinationTableName = tableName;
                bulkCopy.WriteToServer(dtable);
            }
        }

    }
}