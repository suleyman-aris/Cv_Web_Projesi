using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class KonferensEkle : System.Web.UI.Page
    {
        DataSetTableAdapters.TBLODULLERTableAdapter dt = new DataSetTableAdapters.TBLODULLERTableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dt.KonferansEkle(TxtOdul.Text);
            Response.Redirect("KonferansListesi.aspx");
        }
    }
}