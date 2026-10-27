<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="StudentRegistration.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Student Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="Gender:"></asp:Label>
&nbsp;
        <asp:RadioButton ID="rbMale" runat="server" Text="Male" />
&nbsp;&nbsp;
        <asp:RadioButton ID="rbFemale" runat="server" Text="Female" />
&nbsp;<br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Course:"></asp:Label>
&nbsp;
        <asp:DropDownList ID="ddlCourse" runat="server">
            <asp:ListItem>BscIT</asp:ListItem>
            <asp:ListItem>BCA</asp:ListItem>
            <asp:ListItem>MCA</asp:ListItem>
            <asp:ListItem>BA</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:CheckBox ID="chkTerms" runat="server" Text="Accept Terms &amp; Conditions" />
        <br />
        <br />
        <asp:Calendar ID="calDate" runat="server"></asp:Calendar>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="lblOutput" runat="server" Text="Empty"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
