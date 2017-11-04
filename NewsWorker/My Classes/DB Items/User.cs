using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsWorker
{
    public class User:Item
    {
       public string login { get; set; }
       public string password { get; set; }


        //not active
        string email;
        bool confirmed_email;
        string city;
        //--//

    }
}