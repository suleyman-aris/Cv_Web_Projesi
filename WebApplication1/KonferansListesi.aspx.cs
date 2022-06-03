using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class KonferansListesi : System.Web.UI.Page
    {
        DataSetTableAdapters.TBLODULLERTableAdapter dt = new DataSetTableAdapters.TBLODULLERTableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = dt.OdulListesi();
            Repeater1.DataBind();
        }

        protected void HyperLink4_DataBinding(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}