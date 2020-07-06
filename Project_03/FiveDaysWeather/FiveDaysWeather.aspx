<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FiveDaysWeather.aspx.cs" Inherits="FiveDaysWeather.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Get The Five Days Weather"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label84" runat="server" Font-Size="Large" Text="This application allows you to test the WCF service of  information about five days weather"></asp:Label>
        <br />
        <asp:Label ID="Label87" runat="server" Font-Size="Large" Text="Service URL: http://webstrar63.fulton.asu.edu/page1/Service1.svc "></asp:Label>
        <br />
		<br />
        <asp:Label ID="Label85" runat="server" Font-Size="Large" Text="The service offers one operation in the URI:"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label86" runat="server" Font-Size="Large" Text="string Weather5Days(string city, string state, string unit); which return a string contains 5 days weather information with seven sub elements "></asp:Label>
        <br />
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="City:"></asp:Label>
            <asp:TextBox ID="cityInput" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="State:"></asp:Label>
            <asp:TextBox ID="stateInput" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Weather Units:"></asp:Label>
            <asp:DropDownList ID="unitSelect" runat="server">
                <asp:ListItem>Metric (Celcius, m/s)</asp:ListItem>
                <asp:ListItem>Fahrenheit (F, mph)</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="searchBut" runat="server" Font-Bold="True" OnClick="searchBut_Click" Text="Get Weather" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="error" runat="server" Font-Bold="True" Font-Size="Larger" Text="No Weather Infomation Avaliable!!" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Date:"></asp:Label>
&nbsp;<asp:Label ID="date1" runat="server" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label7" runat="server" Text="Highest Temperature: "></asp:Label>
            <asp:Label ID="highT1" runat="server" ForeColor="#FF6600"></asp:Label>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Lowest Temperature: "></asp:Label>
            <asp:Label ID="lowT1" runat="server" ForeColor="Blue"></asp:Label>
            <br />
            <asp:Label ID="Label11" runat="server" Text="Weather Description: "></asp:Label>
            <asp:Label ID="desc1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label13" runat="server" Text="Wind Direction:"></asp:Label>
            &nbsp;<asp:Label ID="dir1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label15" runat="server" Text="Wind Speed:"></asp:Label>
            &nbsp;<asp:Label ID="spd1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label25" runat="server" Text="Relative humidity (%): "></asp:Label>
            <asp:Label ID="rh1" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label29" runat="server" Text="Date:"></asp:Label>
&nbsp;<asp:Label ID="date2" runat="server" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label31" runat="server" Text="Highest Temperature: "></asp:Label>
            <asp:Label ID="highT2" runat="server" ForeColor="#FF6600"></asp:Label>
            <br />
            <asp:Label ID="Label33" runat="server" Text="Lowest Temperature: "></asp:Label>
            <asp:Label ID="lowT2" runat="server" ForeColor="Blue"></asp:Label>
            <br />
            <asp:Label ID="Label35" runat="server" Text="Weather Description: "></asp:Label>
            <asp:Label ID="desc2" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label37" runat="server" Text="Wind Direction:"></asp:Label>
            &nbsp;<asp:Label ID="dir2" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label39" runat="server" Text="Wind Speed:"></asp:Label>
            &nbsp;<asp:Label ID="spd2" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label41" runat="server" Text="Relative humidity (%): "></asp:Label>
            <asp:Label ID="rh2" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label43" runat="server" Text="Date:"></asp:Label>
&nbsp;<asp:Label ID="date3" runat="server" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label45" runat="server" Text="Highest Temperature: "></asp:Label>
            <asp:Label ID="highT3" runat="server" ForeColor="#FF6600"></asp:Label>
            <br />
            <asp:Label ID="Label47" runat="server" Text="Lowest Temperature: "></asp:Label>
            <asp:Label ID="lowT3" runat="server" ForeColor="Blue"></asp:Label>
            <br />
            <asp:Label ID="Label49" runat="server" Text="Weather Description: "></asp:Label>
            <asp:Label ID="desc3" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label51" runat="server" Text="Wind Direction:"></asp:Label>
            &nbsp;<asp:Label ID="dir3" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label53" runat="server" Text="Wind Speed:"></asp:Label>
            &nbsp;<asp:Label ID="spd3" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label55" runat="server" Text="Relative humidity (%): "></asp:Label>
            <asp:Label ID="rh3" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label57" runat="server" Text="Date:"></asp:Label>
&nbsp;<asp:Label ID="date4" runat="server" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label59" runat="server" Text="Highest Temperature: "></asp:Label>
            <asp:Label ID="highT4" runat="server" ForeColor="#FF6600"></asp:Label>
            <br />
            <asp:Label ID="Label61" runat="server" Text="Lowest Temperature: "></asp:Label>
            <asp:Label ID="lowT4" runat="server" ForeColor="Blue"></asp:Label>
            <br />
            <asp:Label ID="Label63" runat="server" Text="Weather Description: "></asp:Label>
            <asp:Label ID="desc4" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label65" runat="server" Text="Wind Direction:"></asp:Label>
            &nbsp;<asp:Label ID="dir4" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label67" runat="server" Text="Wind Speed:"></asp:Label>
            &nbsp;<asp:Label ID="spd4" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label69" runat="server" Text="Relative humidity (%): "></asp:Label>
            <asp:Label ID="rh4" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label71" runat="server" Text="Date:"></asp:Label>
&nbsp;<asp:Label ID="date5" runat="server" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label73" runat="server" Text="Highest Temperature: "></asp:Label>
            <asp:Label ID="highT5" runat="server" ForeColor="#FF6600"></asp:Label>
            <br />
            <asp:Label ID="Label75" runat="server" Text="Lowest Temperature: "></asp:Label>
            <asp:Label ID="lowT5" runat="server" ForeColor="Blue"></asp:Label>
            <br />
            <asp:Label ID="Label77" runat="server" Text="Weather Description: "></asp:Label>
            <asp:Label ID="desc5" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label79" runat="server" Text="Wind Direction:"></asp:Label>
            &nbsp;<asp:Label ID="dir5" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label81" runat="server" Text="Wind Speed:"></asp:Label>
            &nbsp;<asp:Label ID="spd5" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label83" runat="server" Text="Relative humidity (%): "></asp:Label>
            <asp:Label ID="rh5" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://webstrar63.fulton.asu.edu/index.html">Back to main page</asp:HyperLink>
        </div>
    </form>
</body>
</html>
