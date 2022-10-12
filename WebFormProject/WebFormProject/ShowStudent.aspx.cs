using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using DataAccessLayer;

namespace WebFormProject
{
    public partial class ShowStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            schooldetails b = new schooldetails();
            List<students> products = new List<students>();
            products = b.GetProducts2();

            GridView1.DataSource = products;
            GridView1.DataBind();

        }
    }
}