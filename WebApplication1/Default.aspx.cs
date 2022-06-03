using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLHAKKIMDATableAdapter dt = new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkımdaListele();
            Repeater1.DataBind();

            DataSetTableAdapters.TBLDENEYİMTableAdapter dt2 = new DataSetTableAdapters.TBLDENEYİMTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListesi();
            Repeater2.DataBind();

            DataSetTableAdapters.TBLEGITIMTableAdapter dt3 = new DataSetTableAdapters.TBLEGITIMTableAdapter();
            Repeater3.DataSource = dt3.EgitimListesi();
            Repeater3.DataBind();

            DataSetTableAdapters.TBLYETENEKLERTableAdapter dt4 = new DataSetTableAdapters.TBLYETENEKLERTableAdapter();
            Repeater4.DataSource = dt4.YetenekListesi();
            Repeater4.DataBind();

            DataSetTableAdapters.TBLHOBILERTableAdapter dt5 = new DataSetTableAdapters.TBLHOBILERTableAdapter();
            Repeater5.DataSource = dt5.GetDataHobiListesi();
            Repeater5.DataBind();

            DataSetTableAdapters.TBLODULLERTableAdapter dt6 = new DataSetTableAdapters.TBLODULLERTableAdapter();
            Repeater6.DataSource = dt6.OdulListesi();
            Repeater6.DataBind();

            DataSetTableAdapters.TBLHAKKIMDATableAdapter dt7 = new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
            Repeater7.DataSource = dt7.HakkımdaListele();
            Repeater7.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("GirisYap.aspx");
        }
    }
}