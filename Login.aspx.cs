using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Login : System.Web.UI.Page
{
    SqlDataReader dR;
    Database dBobj = new Database();
    public Authenicate aObj;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack && Session["ShopperCount"] == null) Session["ShopperCount"] = 0;
        else Session["ShopperCount"] = (int)Session["ShopperCount"] + 1;
        aObj = new Authenicate((int)Session["ShopperCount"]);
        if (Session["tempEmail"] != null && Session["tempPassword"] != null && Session["TFA"] != null && (bool)Session["TFA"] == true)
        {
            int intShopperID;
            intShopperID = 1;
            Session["ShopperID"] = intShopperID;
            Session["Name"] = dR["Name"].ToString();
            Response.Redirect("Default.aspx");
        } 
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
      if(txtEmail.Text=="")
      {
          lblMsg.Text = "Please Enter Your Email";
      }
      else
      {
          if(txtPwd.Text=="")
          {
              lblMsg.Text = "Please Enter Your Password";
          }
          else
          {
              
              string sqlSel = "Select ShopperID,Name,Phone" + " From Shopper" + " Where Email ='" + txtEmail.Text + "'" + " And " + "Passwd ='" + txtPwd.Text + "'";
              dR = dBobj.ExecuteReader(sqlSel);
              if(dR.Read())
              {
                  Session["tempPhone"] = dR["Phone"];
                  Session["tempEmail"] = txtEmail.Text;
                  Session["tempPassword"]= txtPwd.Text;
                  aObj.emailCfm(Session["tempEmail"].ToString());
                  Response.Redirect("SMSCfm.aspx");
              }
              else
              {
                  int intShopperID = 1;
                  intShopperID = 0;
                  lblMsg.Text = "Incorrect Email or Password.";
                  lblMsg.ForeColor = System.Drawing.Color.Red;
              }
          }
      }
      dR.Close();
    }
}

