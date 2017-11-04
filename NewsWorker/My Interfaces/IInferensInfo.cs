using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace NewsWorker
{
    interface IInferensInfo//набор методов для вывода информации
    {
        void outputInferention(Label lb);
        void outputInferention(ListBox lb);
        void outputInferention(WebControl[] ItemsArray);


    }
}
