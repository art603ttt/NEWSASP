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
    public partial class Default1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            //вывод информации о пользователях
            DBUsersWorker DBU = new DBUsersWorker("DefaultConnection");
            DBU.outputInferention(ListBox1);
            
           
        }

        //переход на форму регистрации
        protected void Button_registr_Click(object sender, EventArgs e)
        {
            Server.Transfer("Registr.aspx", true);
        }
    }
}