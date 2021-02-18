<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type ="text/css">
    .heading{
        text-align:center;
        font-size:large;
    }
    .row{
        border-bottom:1px solid #efefef;
        margin: 5px;
        padding-bottom:5px;
        width:376px; 
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
    <div class="row heading">Login</div>
    <div class="row">
        <asp:Label ID="label1" runat="server" Text="Email:" CssClass="label"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" MaxLength="100" Width="147px"></asp:TextBox>
    </div>
    <div class="row">
        <asp:Label ID="label2" runat="server" Text="Password:" CssClass="label"></asp:Label>
        <asp:TextBox ID="txtPwd" runat="server" MaxLength="25" TextMode="Password"></asp:TextBox>
    </div>
    <div class="row">        
   <asp:Label ID="label3" runat="server" Text="&amp;nbsp"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" Text="Submit" OnClick="btnLogin_Click" />
    </div>
    <div class="row">

        <asp:Label ID="lblMsg" runat="server" Text="Please Register if you do not have an account"></asp:Label>

    </div>
</asp:Content>

