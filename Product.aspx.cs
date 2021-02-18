using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Connect to the database
        Database dBobj = new Database();
        

        string strSqlCmd;
        // System.Data.OleDb.OleDbDataReader objDataReader;
        System.Data.SqlClient.SqlDataReader dR;

        double curOringalPrice;

        // Retrieve the details of product of a given product ID
        // from the database
        int intProductId;
        intProductId = Convert.ToInt32(Request.QueryString["ProductId"]);
        strSqlCmd = "SELECT * FROM Product WHERE ProductId=" + intProductId;
        dR = dBobj.ExecuteReader(strSqlCmd);

        // Read the only record retrieved
        if (dR.Read())
        {
            // Display the product title
            lblProductTitle.Text = (string)dR["ProductTitle"];

            // Display the product description
            if (dR["ProductDesc"] != DBNull.Value)
                lblProductDesc.Text = (string)dR["ProductDesc"];

            // Display the product image
            imgProduct.ImageUrl = "images/products/" + (string)dR["ProductImage"];

            // Display the product price
            // Format to display two decimals
            curOringalPrice = Convert.ToDouble(dR["Price"]);
            lblProductPrice.Text = "$" + string.Format(Convert.ToString(curOringalPrice), "0.00");
            dR.Close();
        }
        // Retrieve the dynamic attributes of a given product
        strSqlCmd = "SELECT an.AttributeName, pa.AttributeVal FROM AttributeName an INNER JOIN ProductAttribute pa ON an.AttributeNameID=pa.AttributeNameID WHERE pa.ProductID=" + intProductId;

        dR = dBobj.ExecuteReader(strSqlCmd);

        // Bind the records to the data grid control
        dgAttribute.DataSource = dR;
        dgAttribute.DataBind();

        dR.Close();
        

    }
    protected void btnAddCart_Click(object sender, EventArgs e)
    {
        // Set the Session Variables:
        // ProductID, ProductName, ProductPrice and Quantity
        //===================================================
        Session["Quantity"] = txtQty.Text;
        Session["ProductName"] = lblProductTitle.Text;
        Session["ProductPrice"] = lblProductPrice.Text;
        Session["ProductID"] = Request["ProductId"];

        // Re-direct to AddItem page to add the
        // selected item to the shopping cart
        Response.Redirect("AddItem.aspx");
    }
}