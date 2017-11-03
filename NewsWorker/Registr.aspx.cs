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



        //СДЕЛАТЬ ПРОВЕРКУ СИМВОЛОВ JAVASCRIPT
        //регистрация
        protected void Button_registr_Click(object sender, EventArgs e)
        {

            //СДЕЛАТЬ ПРОВЕРКА В БД



        }
    }
}