﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManagerHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["id"] != null)
            {
                lbluser.Text = Session["User"].ToString();

            }
            else
            {
                Response.Redirect("Default.aspx");
            }

        }

    }
}