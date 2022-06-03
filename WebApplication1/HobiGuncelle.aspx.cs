using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class HobiGuncelle : System.Web.UI.Page
    {
        DataSetTableAdapters.TBLHOBILERTableAdapter dt = new DataSetTableAdapters.TBLHOBILERTableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Text = x.ToString();
            TxtID.Enabled = false;

            if (Page.IsPostBack == false)
            {
                TxtHobi.Text = dt.HobiGetir(Convert.ToInt16(TxtID.Text))[0].HOBI;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dt.HobiGuncelle(TxtHobi.Text, Convert.ToInt16(TxtID.Text));
            Response.Redirect("HobiListesi.aspx");
        }
    }
}