<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PersonClass_HandIn2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Dentist's patients" Font-Bold="True" Font-Names="Verdana" Font-Size="Larger"></asp:Label>
        <br />
        <br />
        <br />
        Name&nbsp;<asp:TextBox ID="TextBoxFname" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Age"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBoxPass" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="Submit" />
        &nbsp;<asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete last person" />
&nbsp;<asp:Button ID="ButtonDeleteSelected" runat="server" OnClick="ButtonDeleteSelected_Click" Text="Delete selected person" />
&nbsp;</p>
        <asp:ListBox ID="ListBox1" runat="server" Height="181px" Width="328px" AutoPostBack="True"></asp:ListBox>
    &nbsp;
        <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" Height="180px" style="margin-right: 0px; margin-top: 0px" Width="330px"></asp:ListBox>
&nbsp;<asp:ListBox ID="ListBox3" runat="server" AutoPostBack="True" Height="182px" Width="329px"></asp:ListBox>
        <br />
    </form>
</body>
</html>
