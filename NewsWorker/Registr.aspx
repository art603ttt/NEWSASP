<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registr.aspx.cs" Inherits="NewsWorker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Регистрация"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Придумайте логин"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_registr_login" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Придумайте пароль"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox_register_psswrd" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button_registr" runat="server" OnClick="Button_registr_Click" Text="Зарегистрироваться" />
            <br />
        </div>
    </form>
</body>
</html>
