using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenda
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSourceUsuarios_Inserting(object sender, SqlDataSourceCommandEventArgs e)
        {

        }
        protected void SqlDataSourceUsuarios_Inserted(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                e.ExceptionHandled = true;
            }
        }
    }
}