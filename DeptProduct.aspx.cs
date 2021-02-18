using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class DeptProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // Set Session Variable "LastDeptID"
       //==================================
       // Store last department ID in session variable so \t
       // that user can come back again after putting an item \t
       // into the shopping cart. 
       Session["LastDeptID"] = Request["DeptID"];

       // Connect to the database
       Database dBobj = new Database();
       //objdbMgmt.Connect();

       // Retrieve details of a given department ID 
       // from the database
       string strSqlCmd;
       // System.Data.OleDb.OleDbDataReader objDataReader;
       System.Data.SqlClient.SqlDataReader dR;

       strSqlCmd = "SELECT DeptName, DeptDesc FROM Department WHERE DepartmentID=" + Request.QueryString["DeptID"];

       dR = dBobj.ExecuteReader(strSqlCmd);

       // Use data reader object to read the record retrieved.  
       if (dR.Read())
       {
          // Display the department name
          lblDeptName.Text = (string)dR["DeptName"];
          // Display the department description
          lblDeptDescription.Text = (string)dR["DeptDesc"];
       }

       // Close the data reader
       dR.Close();

       // Retrieve products that belonged to the selected 
       // department from the database. 
       strSqlCmd = "SELECT p.ProductID, p.ProductTitle, p.ProductImage, p.Price, p.Quantity FROM DepartmentProduct dp INNER JOIN Product p ON dp.ProductID=p.ProductID" + " WHERE dp.DepartmentID=" + Request.QueryString["DeptID"];
       dR = dBobj.ExecuteReader(strSqlCmd);
       dgDeptProduct.DataSource = dR;

       // Bind the data to the data list control for display
       dgDeptProduct.DataBind();

       // Close the connection object
       dR.Close();
       // Iterate through all rows within the dat grid to check of out of stock item
       int i;

       for (i = 0; i <= dgDeptProduct.Items.Count - 1; i++)
       {
          // Obtain references to row's controls
          Label lblQty;
          Image imgNew;
          Label lblProductId;
          Label lblPrice;
//          Label lblSPrice;
          HyperLink lnkItem1;
          HyperLink lnkItem2;

          lblProductId = (Label)dgDeptProduct.Items[i].FindControl("lblProductId");
          lblPrice = (Label)dgDeptProduct.Items[i].FindControl("lblProductPrice");
//          lblSPrice = (Label)dgDeptProduct.Items[i].FindControl("lblSalesPrice");

          imgNew= (Image)dgDeptProduct.Items[i].FindControl("imgNew");
          lblQty = (Label)dgDeptProduct.Items[i].FindControl("lblOutOfStock");
          lnkItem1 = (HyperLink)dgDeptProduct.Items[i].FindControl("lnkProductName");
          lnkItem2 = (HyperLink)dgDeptProduct.Items[i].FindControl("imgLnkProduct");
          // Get the quantity value from label and convert to integer
          int intQty;
          intQty = Convert.ToInt32(lblQty.Text);

          int intProductId = Convert.ToInt32(lblProductId.Text);

          

          // strSqlCmd = "SELECT ProductID FROM Product WHERE ProductID=" + intProductId + " AND DateDiff('m',[DateEntered],Now())=0;";
          strSqlCmd = "SELECT ProductID FROM Product WHERE ProductID=" + intProductId + " AND DateDiff(month,[DateEntered],getdate())=0;";

         SqlDataReader returnVal;
         returnVal = dBobj.ExecuteReader(strSqlCmd);
         if (returnVal != null)
         {
            imgNew.Visible=true;
            returnVal.Close();
         }

          // if quantity is less than one, display the out of stock label.
          if (intQty < 1)
          {
             lblQty.Text = "Out of Stock!";
             lblQty.Visible = true;
             lnkItem1.Enabled = false;
             lnkItem2.Enabled = false;
          }
       }
       dR.Close();
    }
}
