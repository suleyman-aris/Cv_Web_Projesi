using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdminEgitimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLEGITIMTableAdapter dt = new DataSetTableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimEkle(TxtBaslık.Text, TxtAltBaslık.Text, TxtAciklama.Text, TxtGenelNot.Text, TxtTarih.Text);
            Response.Redirect("AdminEgitimler.Aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}