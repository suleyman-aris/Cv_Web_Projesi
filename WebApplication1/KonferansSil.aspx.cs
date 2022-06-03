using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class KonferansSil : System.Web.UI.Page
    {
        DataSetTableAdapters.TBLODULLERTableAdapter dt = new DataSetTableAdapters.TBLODULLERTableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);

            dt.KonferansSil(Convert.ToInt16(x));
            Response.Redirect("KonferansListesi.Aspx");
        }
    }
}