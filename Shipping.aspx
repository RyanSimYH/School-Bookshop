<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Shipping.aspx.cs" Inherits="CheckOut" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style type="text/css">
        .heading {
            text-align:center;
            font-size:large;
        }
        .row{
            border-bottom: 1px solid #efefef;
            margin: 5px;
            padding-bottom:5px;
            width:500px;
        }
        .label{
            float:left;
            width:100px;
            text-align:right;
            padding-right:10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <Center>
           <h1> Shipping Information</h1>
        </Center>
        <div>

            <asp:Label ID="Label1" runat="server" Text="Reciplent:" CssClass="label"></asp:Label>

            <asp:TextBox ID="nameTextBox" runat="server" style="margin-bottom: 0px"></asp:TextBox>

    </div>
    <div>
        <asp:Label ID="Label2" runat="server" CssClass="label">Address</asp:Label>
        <asp:TextBox ID="addTextBox" runat="server" style="margin-bottom: 0px" TextMode="MultiLine"></asp:TextBox>
    </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Country" CssClass="label"></asp:Label>
            <asp:TextBox ID="countryTextBox" runat="server"></asp:TextBox>
</div>

        <div>
            <asp:Label ID="Label4" runat="server" Text="Phone" CssClass="label"></asp:Label>
        <b>
        <asp:TextBox ID="numTextBox" runat="server" MaxLength="12"></asp:TextBox>
        </b>
</div>

        <div>
            <asp:Label ID="Label5" runat="server" Text="Email" CssClass="label"></asp:Label>
        <b>
        <asp:TextBox ID="emailTextBox" runat="server" MaxLength="50"></asp:TextBox>
        </b>
</div>
        <div>
                <asp:Button ID="cfmButton" runat="server" OnClick="cfmButton_Click" Text="Confirm Your Order" Width="134px" />
        </div>

        <div>
            <center>
            <asp:Label ID="dispLabel" runat="server" CssClass="heading"></asp:Label>
                </center>
    </div>

        </p>
</asp:Content>

