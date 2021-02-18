<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SMSCfm.aspx.cs" Inherits="SMSCfm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Please Enter Your Code"></asp:Label>
    <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="vButton" runat="server" OnClick="vButton_Click" Text="Verify" />
    <br />
    <br />
    <asp:Label ID="msgLabel" runat="server"></asp:Label>
    <br />
</asp:Content>

