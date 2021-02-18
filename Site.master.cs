using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ShopperID"] != null)
        {
            logoutButton.Visible = true;
            loginButton.Visible = false;
            regButton.Visible = false;
            lblWelcome.Text = "Welcome " + Session["Name"].ToString();
        }
        else
        {
            logoutButton.Visible = false;
            loginButton.Visible = true;
            regButton.Visible = true;
            lblWelcome.Text = "";
        }
    }
    protected void regButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void loginButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void logoutButton_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}
