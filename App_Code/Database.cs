using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Database
/// This Creates a connection to the DB and allows the code to access the DB by using a DB object.
/// </summary>
public class Database
{

    string connStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\OOPG\Ryan\App_Data\eceBkShop.mdf;Integrated Security=True";
    SqlConnection connObj;
    SqlCommand comdObj;
    SqlDataReader dR;

    public Database()
    {

        connObj = new SqlConnection(connStr);
        connObj.Open();

    }

    public SqlDataReader ExecuteReader(string selStr)
    {
        comdObj = new SqlCommand(selStr, connObj);
        dR = comdObj.ExecuteReader();
        return dR;
    }
    public void ExecuteNonQuery(string sqlStr)
    {
        comdObj = new SqlCommand(sqlStr, connObj);
        comdObj.ExecuteNonQuery();
    }
}
