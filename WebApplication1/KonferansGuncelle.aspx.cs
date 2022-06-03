using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class KonferansGuncelle : System.Web.UI.Page
    {
        DataSetTableAdapters.TBLODULLERTableAdapter dt = new DataSetTableAdapters.TBLODULLERTableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Text = s.ToString();
            TxtID.Enabled = false;

            if(Page.IsPostBack == false)
            {
                TxtOdul.Text = dt.KonferansGetir(Convert.ToInt16(s))[0].ODUL;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dt.KonferansGuncelle(TxtOdul.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("KonferansListesi.aspx");
        }
    }
}