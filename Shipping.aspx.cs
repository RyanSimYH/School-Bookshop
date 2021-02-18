using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        nameTextBox.Text = Session["ShipName"].ToString();
        addTextBox.Text = Session["ShipAddress"].ToString();
        countryTextBox.Text = Session["ShipCountry"].ToString();
        numTextBox.Text = Session["ShipPhone"].ToString();
        emailTextBox.Text = Session["ShipEmail"].ToString();
    }
    protected void cfmButton_Click(object sender, EventArgs e)
    {
        dispLabel.Text = "Thank you and your order will be delivered.";
    }
}