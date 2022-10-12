﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using DataAccessLayer;

namespace WebFormProject
{
    public partial class ShowSubject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            schooldetails b = new schooldetails();
            List<subjects> products = new List<subjects>();
            products = b.GetProducts1();

            GridView1.DataSource = products;
            GridView1.DataBind();


        }
    }
}