using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//----
using System.Configuration;
using System.Data.SqlClient;

namespace NewsWorker
{
    public class DataBaseWorker//класс работы с БД
    {
        SqlConnection Connection;
        string ConnectionString;

        public DataBaseWorker(string Name_connection)
        {
            ConnectionString = ConfigurationManager.ConnectionStrings[Name_connection].ConnectionString;
        }



        public void ViewAllUsers(ListBox LB)//вывод списка всех пользователей
        {
            /*
          using (Connection = new SqlConnection(ConnectionString))
          {
              using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM LoginPassword;", Connection))
               {
                   System.Data.DataTable rec = new System.Data.DataTable();


                   adapter.Fill(rec);
                   ListBox1.DataSource = rec;

               }

              using (SqlDataReader adapter = new SqlDataReader(Connection))
              {
                  System.Data.DataTable rec = new System.Data.DataTable();


                  adapter.Fill(rec);
                  ListBox1.DataSource = rec;

              }
              }
              */
            string queryString ="SELECT * FROM Clients;";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    LB.Items.Add(reader[1].ToString());
                }

                // Call Close when done reading.
                reader.Close();
            }
        }

        public void AddNewUser()
        {






        }



    }
}