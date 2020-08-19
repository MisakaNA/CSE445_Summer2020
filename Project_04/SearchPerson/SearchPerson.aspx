<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPerson.aspx.cs" Inherits="WebApp.SearchPerson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Search Person"></asp:Label>
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Enter the XML URL: " Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="xmlURL" runat="server" Font-Size="Small" Width="301px">http://webstrar63.fulton.asu.edu/page9/Persons.xml</asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="(Default set as my XML file)"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter the person's first name: " Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="firstName" runat="server" Font-Size="Medium"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Enter the person's last name: " Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="lastName" runat="server" Font-Size="Medium"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Search" runat="server" OnClick="Search_Click" Text="Search" Font-Size="Medium" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="error" runat="server" Font-Bold="True" ForeColor="Red" Font-Size="Medium"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Searching Result:" Font-Size="Medium"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Result" runat="server" Font-Size="Medium"></asp:Label>
    </form>
</body>
</html>
