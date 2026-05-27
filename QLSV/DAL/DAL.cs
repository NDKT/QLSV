using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace QLSV.DAL
{
    public class DAL
    {
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=QuanLySinhVien;Integrated Security=True;Trust Server Certificate=True";
        private static DAL? instance;

        public static DAL Instance {
            get 
            {
                if (instance == null) instance = new DAL();
                return instance;
            } 
            private set => instance = value; 
        }
        public DAL() { }
        public DataTable excuteQuery(string query, params object[] parameter)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query,connection);
               
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (var item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public bool excuteNonQuery(string query, params object[] parameter)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (var item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
                
                data = command.ExecuteNonQuery();
               
            }
            return data > 0;
        }
    }
}
