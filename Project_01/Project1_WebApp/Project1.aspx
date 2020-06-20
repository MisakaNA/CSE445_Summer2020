<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project1.aspx.cs" Inherits="Project1_WebApp.Project1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 299px;
        }
    </style>
</head>
<body style="height: 240px; width: 434px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Unsorted String  :         "></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Sort" runat="server" Height="31px" OnClick="Sort_Click" Text="Sort !" Width="69px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Sorted String : "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Output" runat="server" Text=" "></asp:Label>
        <asp:Label ID="SortResult" runat="server" Text=" "></asp:Label>
    </form>
</body>
</html>
