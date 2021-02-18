<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ShopCart.aspx.cs" Inherits="ShopCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <asp:Label ID="lblEmptyShopCart" runat="server" Text="Your Shopping Cart Is Empty"></asp:Label>
        <asp:DataGrid ID="dgShopCart" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="500px">
            <AlternatingItemStyle BackColor="White" />
            <Columns>
                <asp:BoundColumn DataField="ProductID" HeaderText="Item Code"></asp:BoundColumn>
                <asp:BoundColumn DataField="Name" HeaderText="Name" ReadOnly="True"></asp:BoundColumn>
                <asp:TemplateColumn HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="qtyTextBox" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Quantity") %>' Width="50px"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:BoundColumn DataField="Price" DataFormatString="{0:c}" HeaderText="Price" ReadOnly="True"></asp:BoundColumn>
                <asp:BoundColumn DataField="Total" DataFormatString="{0:c}" HeaderText="Total" ReadOnly="True"></asp:BoundColumn>
                <asp:HyperLinkColumn DataNavigateUrlField="ProductID" DataNavigateUrlFormatString="DeleteItem.aspx?ProductId={0}" Text="Remove"></asp:HyperLinkColumn>
            </Columns>
            <EditItemStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#E3EAEB" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        </asp:DataGrid>
    </p>
    <p>
        <asp:Label ID="lblSubTotal" runat="server"></asp:Label>
    </p>
    <p>
        <center>
        <asp:Button ID="btnUpdateCart" runat="server" Text="Update Cart" Width="84px" />
            <asp:Button ID="btnCheckOut" runat="server" Text="Check Out" Width="85px" />
            </center>
    </p>
</asp:Content>

