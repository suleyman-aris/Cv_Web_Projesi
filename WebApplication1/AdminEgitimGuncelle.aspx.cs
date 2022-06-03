﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            Txtid.Enabled = false;
            Txtid.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSetTableAdapters.TBLEGITIMTableAdapter dt = new DataSetTableAdapters.TBLEGITIMTableAdapter();
                TxtBaslık.Text = dt.EgitimGetir (Convert.ToInt16(x))[0].BASLIK;
                TxtAltBaslık.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                TxtAciklama.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                TxtTarih.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].TARIH;
                TxtGenelNot.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].GNOT;
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLEGITIMTableAdapter dt = new DataSetTableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimGuncelle(TxtBaslık.Text, TxtAltBaslık.Text, TxtAciklama.Text, TxtGenelNot.Text, TxtTarih.Text, Convert.ToInt16(Txtid.Text));
            Response.Redirect("AdminEgitimler.Aspx");
        }
    }
}