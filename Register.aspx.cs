using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;

public partial class Register : System.Web.UI.Page
{
    int intShopperID = 0;
    string strName, strAddress, strCountry, strPhone, strEmail, strPwd;
    string strCode;
    SqlDataReader dR;
    Database dBobj = new Database();
    protected void Page_Load(object sender, EventArgs e)
    {
        dispLabel.Visible = false;
        cfmTB.Visible = false;
        verifyButton.Visible = false;
    }
    protected void regButton_Click(object sender, EventArgs e)
    {
        if(Page.IsValid)
        {

            int returnVal;
            
            

            strName = nameTextBox.Text;
            strAddress = addTextBox.Text;
            strCountry = countryDropDownList.SelectedValue;
            strPhone = numTextBox.Text;
            strEmail = emailTextBox.Text.Trim().ToLower();
            strPwd = pwdTextBox.Text;

            string sqlStr = "Select ShopperID" + " From Shopper" + " Where Email = '" + strEmail + "'";
            dR=dBobj.ExecuteReader(sqlStr);


            if (dR.Read())
            {
                msgLabel.Text = "Account is Registered. Please Login";
               
            }
            else
            {
                dR.Close();
                
                dispLabel.Visible = true;
        cfmTB.Visible = true;
        verifyButton.Visible = true;

                strCode = new Random().Next().ToString();
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
                mail.From = new MailAddress("OOPGBookshop@outlook.com");
                mail.To.Add(strEmail);
                mail.Subject = "Email Confimation";
                mail.Body = "Please Confirm your email by entering this code \n" + strCode;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("OOPGBookshop@outlook.com", "ckyaBlyat");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            

        }
        
    }
    protected void verifyButton_Click(object sender, EventArgs e)
    {
        if(strCode == cfmTB.Text)
        {
            string sqlInsert = "Insert Into Shopper (Name,Address,Country,Phone,Email,Passwd)" + "Values('" + strName + "','" + strAddress + "','" + strCountry + "','" + strPhone + "','" + strEmail + "','" + strPwd + "')";
            dBobj.ExecuteNonQuery(sqlInsert);
            string sqlStr = "Select ShopperID" + " From Shopper" + " Where Email = '" + strEmail + "'";
            dR = dBobj.ExecuteReader(sqlStr);
            intShopperID = int.Parse(dR["ShopperID"].ToString());
            Session["ShopperID"] = intShopperID;
            Session["ShipName"] = strName;
            Session["BillName"] = strName;
            Session["ShipAddress"] = strAddress;
            Session["BillAddress"] = strAddress;
            Session["ShipPhone"] = strPhone;
            Session["BillPhone"] = strPhone;
            Session["ShipEmail"] = strEmail;
            Session["BillEmail"] = strEmail;
            Session["ShipCountry"] = strCountry;
            Session["ProfileRetrived"] = 1;
            msgLabel.Text = "Registration Successful";
            msgLabel.ForeColor = System.Drawing.Color.Red;

            //Response.Redirect("Default.aspx");
        }
        else
        {
            dispLabel.Text = "Please re enter the code";
        }
    }
}