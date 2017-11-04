using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
//----
using System.Configuration;
using System.Data.SqlClient;

namespace NewsWorker
{
    public class DBUsersWorker:DataBaseWorker //класс для работы с БД пользователями
    {
        public DBUsersWorker(string Name_connection)
        {
            ConnectionString = ConfigurationManager.ConnectionStrings[Name_connection].ConnectionString;
        }

        //реализация DataBaseWorker
        public override void AddItemToDB(Item item)
        {
            
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {         
                string sqlcomm = "INSERT INTO Clients (Login, Password) " + "VALUES (@Login, @Password)";
                    
                SqlCommand command = new SqlCommand(sqlcomm,Connection);

                Connection.Open();      
                
                command.Parameters.AddWithValue("@Login", ((User)item).login);
                command.Parameters.AddWithValue("@Password", ((User)item).password);
                command.ExecuteNonQuery();

                Connection.Close();
            }
        }
        public override void DelItemFromDB(string name)
        {
            

        }
        public override bool SearcItemInDB(string name)//поиск пользователя по логину
        {
            string queryString = "SELECT * FROM Clients WHERE CONVERT(VARCHAR, Login)='" + name + "';";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                if (reader.Read())
                {

                    return false;

                }
                else return true;
                
               
            }

        }
        //--//--//--//

        //реализация IInferensInfo
        public override void outputInferention(Label lb)
        {

        }
        public override void outputInferention(ListBox lb)//вывод всех пользователей
        {
            string queryString = "SELECT * FROM Clients;";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    lb.Items.Add(reader[1].ToString());
                }

                // Call Close when done reading.
                reader.Close();
            }

        }
        public override void outputInferention(WebControl[] ItemsArray)
        {

        }
        //--//--//--//



    }
}