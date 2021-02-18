<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            color: #FF0000;
        }
        .style6
        {
            width: 59px;
        }
        .style7
        {
            font-family: Arial;
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" style="height: 298px">
        <tr>
            <td colspan="2">
                <asp:Label ID="lblProductTitle" runat="server" Font-Bold="True" 
                    Font-Size="Larger" ForeColor="#0080FF" style="font-family: Arial"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style6" valign="top">
                <asp:Image ID="imgProduct" runat="server" Height="200px" Width="160px" />
            </td>
            <td valign="top" width="360px">
                <asp:Label ID="lblProductDesc" runat="server" 
                    style="font-family: Arial; font-size: large"></asp:Label>
                <br />
                <asp:GridView ID="dgAttribute" runat="server" AutoGenerateColumns="False" 
                    GridLines="None" ShowHeader="False" 
                    style="font-family: Arial; font-size: medium">
                    <Columns>
                        <asp:BoundField DataField="AttributeName" ReadOnly="True">
                        <ItemStyle Font-Bold="True" />
                        </asp:BoundField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                :
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="AttributeVal" ReadOnly="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td width="360px">
                <strong><span class="style7">Price: <span class="style5">$ </span>
                <asp:Label ID="lblProductPrice" runat="server" ForeColor="Red"></asp:Label>
&nbsp; Quantity:</span> </strong>
                <asp:TextBox ID="txtQty" runat="server" Height="24px" Width="17px">1</asp:TextBox>
                <asp:Button ID="btnAddCart" runat="server" onclick="btnAddCart_Click" 
                    Text="Add to Cart" Width="82px" />
            </td>
        </tr>
    </table>
</asp:Content>

