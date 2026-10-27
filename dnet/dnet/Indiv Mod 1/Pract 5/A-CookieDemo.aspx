<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieDemo.aspx.cs" Inherits="CookieDemo.CookieDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="User Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save Cookie" />
        <p>
            <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show Cookie" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblOutput" runat="server" Text="Output"></asp:Label>
        </p>
    </form>
</body>
</html>
