<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MiniInTheBox.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Gebruikersnaam: <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox><br />
    Wachtwoord: <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox><br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" Width="128px" OnClick="btnLogin_Click" />
    <asp:Label ID="lblLogin" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>
