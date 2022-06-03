using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class GirisYap : System.Web.UI.Page
    {
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-0OB8R4Q\SQLEXPRESS;Initial Catalog=BlokWebDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLADmIN where KULLANICI=@P1 AND SIFRE=@P2", baglantı);
            komut.Parameters.AddWithValue("@P1", TextBox1.Text);
            komut.Parameters.AddWithValue("@P2", TextBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("AdminDeneyimler.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı ya da Şifre");
            }
            baglantı.Close();
        }
    }
}