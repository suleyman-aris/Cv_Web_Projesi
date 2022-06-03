using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtId.Enabled = false;
            TxtId.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSetTableAdapters.TBLDENEYİMTableAdapter dt = new DataSetTableAdapters.TBLDENEYİMTableAdapter();
                TxtBaslık.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].BASLIK;
                TxtAltBaslık.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                TxtAcıklama.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].TARIH;
            }

        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLDENEYİMTableAdapter dt = new DataSetTableAdapters.TBLDENEYİMTableAdapter();
            dt.DeneyimGuncelle(TxtBaslık.Text, TxtAltBaslık.Text, TxtAcıklama.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
            Response.Redirect("AdminDeneyimler.Aspx");
        }
    }
}