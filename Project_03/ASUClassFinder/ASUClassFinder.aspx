<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASUClassFinder.aspx.cs" Inherits="ASUClassFinder.ASUClassFinder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="53px" ImageUrl="ASU.png" Width="230px" />
            <br />
			<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="ASU Class Finder: Find Seats avaliable for a class"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="This application allows you to test the WCF service of an ASU class finder. &lt;br /&gt;Service URL: http://webstrar63.fulton.asu.edu/page4/Service1.svc&lt;br /&gt;&lt;br /&gt;This service can get the class information by entering the class subject and the class number. The results are from the Class Search system of Arizona State University. &lt;br /&gt;&lt;br /&gt;The service offers one operation in URI: &lt;br /&gt;string ASUClassFinder(string classCode, string classNum, string status); which returns a string that contains most of the details of the input class." Width="871px"></asp:Label>
            <br />
            <br />
			<br />
			<asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Notice: The semester of the searching results has been locked as Fall 2020"></asp:Label>
            <br />
			<br />
            <asp:Label ID="Label3" runat="server" Text="Enter the class subject: "></asp:Label>
            <asp:TextBox ID="subject" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Enter the class number: "></asp:Label>
            <asp:TextBox ID="num" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Select the class status: "></asp:Label>
            <asp:DropDownList ID="status" runat="server">
                <asp:ListItem>Open Classes</asp:ListItem>
                <asp:ListItem>All Classes</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="search" runat="server" OnClick="search_Click" Text="Search Class" Height="32px" Width="126px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="aLabel" runat="server" Font-Size="Medium" Text="Total Amount of Results: "></asp:Label>
            &nbsp;
            <asp:Label ID="amountLabel" runat="server" Font-Size="Medium"></asp:Label>
            <br />
            <br />
            <asp:Table ID="resultTable" runat="server" Height="26px" Width="931px">
                <asp:TableRow runat="server" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" VerticalAlign="Middle">
                    <asp:TableCell ID="name" runat="server" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle">Class Name</asp:TableCell>
                    <asp:TableCell ID="number" runat="server" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle">Class Number</asp:TableCell>
                    <asp:TableCell ID="instructor" runat="server" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle">Instructor</asp:TableCell>
                    <asp:TableCell ID="date" runat="server" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle">Days</asp:TableCell>
                    <asp:TableCell ID="start" runat="server" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle">Start Time</asp:TableCell>
                    <asp:TableCell ID="end" runat="server" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle">End Time</asp:TableCell>
                    <asp:TableCell ID="seats" runat="server" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle">Seats Open</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <br />
            <br />
            <br />
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="noData" runat="server" Font-Bold="True" Font-Size="Large" Text="No searching result found for the current course!" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://webstrar63.fulton.asu.edu/index.html">Back to main page</asp:HyperLink>
    </form>
</body>
</html>
