<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mysql.aspx.cs" Inherits="mysql" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Enabled="False" Text="歡迎來到登陸系統"></asp:Label>
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="帳號:  "></asp:Label>
&nbsp;
    <asp:TextBox ID="textBoxID" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="密碼:"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="textBoxPw" runat="server"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="確定" Width="87px" 
        onclick="Button1_Click" />
&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="EXIT" Width="87px" />
    <p>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;<asp:Label ID="Label6" runat="server" Text="您於資料庫中的ID為:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;<asp:Label ID="Label7" runat="server" Text="您於資料庫中的Password為:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server"></asp:Label>
    </p>
    </form>
</body>
</html>
