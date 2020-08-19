<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Project5.Member" %>
<%@ Register TagPrefix = "time" TagName="GetDate" src="GetDate.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label7" runat="server" Text="Welcome back, " Font-Bold="True" Font-Size="Large"></asp:Label>
            <asp:Label ID="userName" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
            <asp:Label ID="Label9" runat="server" Text="!" Font-Bold="True" Font-Size="Large"></asp:Label>
            &nbsp;<time:GetDate runat="server"/>
            <br />
            <br />
            <asp:Button ID="Logout" runat="server" OnClick="Logout_Click" Text="Log out" />
            <br />
            <br />
            <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="Large" Text="Have some secrets? Encrypt your messages! (This feature is developed by DLL)"></asp:Label>
&nbsp;<br />
            <br />
            <asp:TextBox ID="enteredStr" runat="server" Height="89px" style="margin-top: 0px" TextMode="MultiLine" Width="235px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Button ID="Encrypt" runat="server" Text="Encrypt Text" Width="110px" OnClick="Encrypt_Click" Font-Size="Medium" />
&nbsp;
            <asp:Button ID="Decrypt" runat="server" Text="Decrypt Text" Width="113px" OnClick="Decrypt_Click" Font-Size="Medium" />
            <br />
            <br />
            <asp:Label ID="Label22" runat="server" Text="Encrypt/Decrypt Result: " Font-Size="Medium"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="resultStr" runat="server" Height="95px" style="margin-top: 0px" TextMode="MultiLine" Width="237px" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Large" Text="Search for a class:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Enter the class subject: " Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="subject" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Enter the class number: " Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="num" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Select the class status: " Font-Size="Medium"></asp:Label>
            <asp:DropDownList ID="status" runat="server">
                <asp:ListItem>Open Classes</asp:ListItem>
                <asp:ListItem>All Classes</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Search" runat="server" Height="32px" OnClick="Search_Click" Text="Search Class" Width="126px" Font-Size="Medium" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="aLabel" runat="server" Font-Size="Medium" Text="Total Amount of Results: " Font-Bold="True"></asp:Label>
            <asp:Label ID="amountLabel" runat="server" Font-Size="Medium"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label23" runat="server" Text="* Instructor full names will show as tips when holding the mouse above instructor cells"></asp:Label>
            <br />
            <asp:Table style="overflow-y: scroll" ID="resultTable" runat="server" Height="26px" Width="931px" Font-Size="Medium">
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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="noData" runat="server" Font-Bold="True" Font-Size="Large" Text="No searching result found for the current course!" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Large" Text="Get the professor rating infomation: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Enter your school name: "></asp:Label>
            <asp:TextBox ID="schoolInput" runat="server" Font-Size="Medium" Width="184px">Arizona State University</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Font-Size="Medium" Text="Enter your professor's name: "></asp:Label>
            <asp:TextBox ID="nameInput" runat="server" Font-Size="Medium" Width="155px"></asp:TextBox>
            &nbsp;<asp:Label ID="Label24" runat="server" Text="(In order to get accurate results, please enter the full name of the professor)"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="SearchRating" runat="server" Font-Size="Medium" OnClick="SearchRating_Click" Text="Get the rating for him/her" />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="noData0" runat="server" Font-Bold="True" Font-Size="Large" Text="No Rating Result For Current Professor!" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Medium" Text="Searching Result: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label14" runat="server" Font-Size="Medium" Text="Professor Name: "></asp:Label>
            <asp:Label ID="profName" runat="server" Font-Size="Medium"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Font-Size="Medium" Text="Department: "></asp:Label>
            <asp:Label ID="dept" runat="server" Font-Size="Medium"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label15" runat="server" Font-Size="Medium" Text="Overall Rating: "></asp:Label>
            <asp:Label ID="overall" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
            <asp:Label ID="full" runat="server" Font-Size="Medium" Visible="False">/ 5</asp:Label>
            <br />
            <br />
            <asp:Label ID="Label16" runat="server" Font-Size="Medium" Text="Would Take Again: "></asp:Label>
            <asp:Label ID="takeAgain" runat="server" Font-Size="Medium" ForeColor="Green"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label17" runat="server" Font-Size="Medium" Text="Level of Difficulty: "></asp:Label>
            <asp:Label ID="level" runat="server" Font-Size="Medium" ForeColor="Blue"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label18" runat="server" Font-Size="Medium" Text="Top Tags: "></asp:Label>
&nbsp;&nbsp;
            <asp:Label ID="tag1" runat="server" Font-Size="Medium" ForeColor="#FF6600"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="tag2" runat="server" Font-Size="Medium" ForeColor="#FF6600"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="tag3" runat="server" Font-Size="Medium" ForeColor="#FF6600"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label19" runat="server" Font-Size="Medium" Text="Most Helpful Rating or Top Rating: "></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="topRating" runat="server" Font-Size="Medium" Height="159px" ReadOnly="True" TextMode="MultiLine" Width="401px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label20" runat="server" Text="Commented At:"></asp:Label>
&nbsp;<asp:Label ID="time" runat="server"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl=""  >Back to Public page</asp:HyperLink>
        </div>
    </form>
</body>
</html>

<script language="C#" runat="server">
    
</script>
