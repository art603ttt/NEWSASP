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
    public abstract class DataBaseWorker:IInferensInfo//Абстрактный класс для работы с БД
    {
        public SqlConnection Connection;
        public string ConnectionString;

        public abstract void AddItemToDB(Item obj);//добавление записи с абстр элементом в таблицу БД
        public abstract void DelItemFromDB(string name);//добавление записи с абстр элементом в таблицу БД
        public abstract bool SearcItemInDB(string name);//поиск записи

        //"реализация" методов IInferensInfo
        public abstract void outputInferention(Label lb);
        public abstract void outputInferention(ListBox lb);
        public abstract void outputInferention(WebControl[] ItemsArray);
        //


        public void ViewAllUsers(ListBox LB)//СТАРЫЙ СПОСОБ - ЗАПОМНИТЬ
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
           
        }

    }
}