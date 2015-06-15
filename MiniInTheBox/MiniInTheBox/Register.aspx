<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MiniInTheBox.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Gebruikersnaam: <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox><br />
    Wachtwoord: <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox><br />
    Herhaal Wachtwoord: <asp:TextBox ID="tbPassword2" runat="server" TextMode="Password"></asp:TextBox>
    <asp:CompareValidator ID="ValidatorPasswords" runat="server" ErrorMessage="Wachtwoorden komen niet overeen!" ControlToValidate="tbPassword2" ControlToCompare="tbPassword" Operator="Equal" Type="String" ForeColor="Red"></asp:CompareValidator>
    <br />
    <asp:Button ID="btnRegister" runat="server" Text="Register" Width="131px" />
</asp:Content>
