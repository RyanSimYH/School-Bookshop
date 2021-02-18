<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

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
    <div class="row heading"><b>Membership Registration</b></div>
    <div class="row">
        <b>Please Register Before making a purchase. All Fields need to be filled in
        </b>
    </div>
    <div class="row">
        <b>
        <asp:Label ID="Label1" runat="server" CssClass="label" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server" MaxLength="50"></asp:TextBox>
        <asp:RequiredFieldValidator ID="nameValid" runat="server" ControlToValidate="nameTextBox" ErrorMessage="Please Enter Your Name" ForeColor="Red"></asp:RequiredFieldValidator>
        </b>
    </div>
    <div class="row">
        <b>
        <asp:Label ID="Label2" runat="server" CssClass="label" Text="Address"></asp:Label>
        <asp:TextBox ID="addTextBox" runat="server" MaxLength="150" TextMode="MultiLine"></asp:TextBox>
        </b>
    </div>
    <div class="row">
        <b>
        <asp:Label ID="Label3" runat="server" CssClass="label" Text="Country"></asp:Label>
        <asp:DropDownList ID="countryDropDownList" runat="server">
            <asp:ListItem>Singapore</asp:ListItem>
            <asp:ListItem>Malaysia</asp:ListItem>
            <asp:ListItem>Others</asp:ListItem>
        </asp:DropDownList>
        </b>
    </div>
    <div class="row">
        <b>
        <asp:Label ID="Label4" runat="server" CssClass="label" Text="Contact Number:"></asp:Label>
        <asp:TextBox ID="numTextBox" runat="server" MaxLength="12"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="numTextBox" ErrorMessage="Please Enter A Contact Number" ForeColor="Red"></asp:RequiredFieldValidator>
        </b></div>
    <div class="row">
        <b>
        <asp:Label ID="Label5" runat="server" CssClass="label" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server" MaxLength="50"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailTextBox" ErrorMessage="Please Enter Your Email" ForeColor="Red"></asp:RequiredFieldValidator>
        </b>
    </div>
    <div class="row">
        <b>
        <asp:Label ID="Label6" runat="server" CssClass="label" Text="Password"></asp:Label>
        <asp:TextBox ID="pwdTextBox" runat="server" MaxLength="25" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="pwdTextBox" ErrorMessage="Please Enter Your Password" ForeColor="Red"></asp:RequiredFieldValidator>
        </b>
    </div>
    <div class="row">
        <b>
        <asp:Label ID="Label7" runat="server" CssClass="label" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="cfmTextBox" runat="server" MaxLength="25" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="cfmValid" runat="server" ControlToCompare="pwdTextBox" ControlToValidate="cfmTextBox" ErrorMessage="Password Mismatch" ForeColor="Red"></asp:CompareValidator>
        </b>
    </div>
    <div class="row">
        <center>
            <asp:Button ID="regButton" runat="server" Text="Register" OnClick="regButton_Click" />
            <asp:Label ID="msgLabel" runat="server"></asp:Label>
            </center>
            <asp:Label ID="dispLabel" runat="server" Text="Please Enter The Email  Confirmation Code"></asp:Label>
            <br />
            <asp:TextBox ID="cfmTB" runat="server"></asp:TextBox>
        <asp:Button ID="verifyButton" runat="server" CausesValidation="False" OnClick="verifyButton_Click" Text="Verify" />
            <br />
        
    </div>

   
</asp:Content>

