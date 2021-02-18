using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SMSCfm : System.Web.UI.Page
{
    string strTemp1;
    bool TFA;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void vButton_Click(object sender, EventArgs e)
    {
        Authenicate TfaCheck = new Authenicate((int)Session["ShopperCount"]);
        strTemp1 = codeTextBox.Text;
        TFA = TfaCheck.Check(strTemp1, (int)Session["ShopperCount"]);
        if(TFA==true)
        {
            Session["TFA"] = true;
            Response.Redirect("Login.aspx");
        }
        else
        {
            msgLabel.Text = "Please Try Again";
        }
    }
}