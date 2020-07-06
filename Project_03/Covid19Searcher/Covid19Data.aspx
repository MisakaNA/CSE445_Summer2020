<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Covid19Data.aspx.cs" Inherits="Covid19Searcher.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 105px">
    <form id="form1" runat="server">
        <div>
			<asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Text="COVID-19 Cases Searcher"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label84" runat="server" Font-Size="Large" Text="This application allows you to test the WCF service of  information about Covid-19 "></asp:Label>
            <br />
            <asp:Label ID="Label87" runat="server" Font-Size="Large" Text="Service URL: http://webstrar63.fulton.asu.edu/page1/Service1.svc "></asp:Label>
            <br />
			<br />
            <asp:Label ID="Label85" runat="server" Font-Size="Large" Text="The service offers one operation in the URI:"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label86" runat="server" Font-Size="Large" Text="string Covid19Cases(string country); which returns a string contains three needed data"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Please input the country name: "></asp:Label>
            <asp:TextBox ID="countryInput" runat="server" Width="125px"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Font-Bold="True" Height="30px" OnClick="Button1_Click" Text="Search" Width="90px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="invalid" runat="server" Font-Bold="True" Text=" No data founded in the input country!" Visible="False"></asp:Label>
        </p>
        <asp:Label ID="confirmLabel" runat="server" Font-Bold="True" ForeColor="Red">Confirmed:     </asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="confirm" runat="server" ForeColor="Red"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Recovered:     " ForeColor="Green"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="recover" runat="server" ForeColor="Green"></asp:Label>
        </p>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Deaths:     "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="deaths" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://webstrar63.fulton.asu.edu/index.html">Back to main page</asp:HyperLink>
    </form>
</body>
</html>
