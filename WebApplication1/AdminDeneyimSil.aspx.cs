using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdminDeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            DataSetTableAdapters.TBLDENEYİMTableAdapter dt = new DataSetTableAdapters.TBLDENEYİMTableAdapter();
            dt.DeneyimSil(Convert.ToInt16(id));
            Response.Redirect("AdminDeneyimler.Aspx");
        }
    }
}