using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class HangmanDB : IHangmanDB
    {
        private string connectionString = "Data Source=.;Initial Catalog=Hangman;Integrated Security=true";
       

        public bool Delete(string iname)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete From animals where name=@name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", iname);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();

            }
        }

        public bool Insert(string iname)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert Into animals (name) values (@name)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", iname);
                
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectRow(string iname)
        {
            string query = "Select * From animals where name=" + iname;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectAll()
        {
            string query = "Select * From animals";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public int CountOfData()
        {
            string query = "Select * From animals";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data.Rows.Count;
            
            
        }
    }
}
