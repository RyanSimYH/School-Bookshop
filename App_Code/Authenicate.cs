using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

/// <summary>
/// Summary description for Authenicate
/// </summary>
public class Authenicate
{
    public static string[] strNum = new string[1000];
    public int ShopperID;
   public void emailCfm(string stremail)
    {
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
        mail.From = new MailAddress("OOPGBookshop@outlook.com");
        mail.To.Add(stremail);
        mail.Subject = "E Bookshop 2FA";
        mail.Body = "This Is Your 2FA Code. Please Enter it in the web browser \n" + strNum[ShopperID];
       SmtpServer.Port = 587;
       SmtpServer.Credentials = new System.Net.NetworkCredential("OOPGBookshop@outlook.com", "");
       SmtpServer.EnableSsl = true;
       SmtpServer.Send(mail);

    }

    public bool Check(string strTemp, int ShopperID)
   {
        if(strTemp == strNum[ShopperID])
        {
            return true;
        }
        else
        {
            return false;
        }
   }
	public Authenicate(int ID)
	{
        strNum[ID] = new Random().Next().ToString();
        ShopperID = ID;
	}
}
