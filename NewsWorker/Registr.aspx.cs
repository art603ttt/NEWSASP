using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using System.Configuration;
using System.Data.SqlClient;

namespace NewsWorker
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection Connection;
        string ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {

            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }



        //СДЕЛАТЬ ПРОВЕРКУ СИМВОЛОВ JVS
        //регистрация
        protected void Button_registr_Click(object sender, EventArgs e)
        {

            //поиск логина в БД
            DBUsersWorker dbu = new DBUsersWorker("DefaultConnection");

           if( !dbu.SearcItemInDB(TextBox_registr_login.Text))
            {
                Label4.Text = "Логин занят!";

            }
           else
            {
                User us = new User();

                us.login = TextBox_registr_login.Text;
                us.password = TextBox_register_psswrd.Text;

                dbu.AddItemToDB((Item)us);

              
            }


        }

        //на главную
        protected void Button_toamain_Click(object sender, EventArgs e)
        {
            Server.Transfer("Default.aspx", true);
        }
    }
}