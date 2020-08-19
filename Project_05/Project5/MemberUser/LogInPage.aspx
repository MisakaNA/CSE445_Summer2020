<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogInPage.aspx.cs" Inherits="Project5.LogInPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Welcome to the ASU Class Search Helper!"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="If you are a member,"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="User Name: "></asp:Label>
        <asp:TextBox ID="userName" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
        &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
        <asp:Label ID="Label7" runat="server" Text="or"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="../MemberUser/RegisterPage.aspx" Font-Size="Medium">Register</asp:HyperLink>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="password" TextMode="Password" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label6" runat="server" Text="To check you are a human user:"></asp:Label>
        &nbsp;
        <asp:ImageButton ID="CaptchaImg" runat="server" Height="38px" Width="131px" ImageUrl="init.png" OnClick="CaptchaImg_Click" autoPostback="false"/>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Please enter the captcha:"></asp:Label>
&nbsp;<asp:TextBox ID="captchaInput" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:CheckBox ID="Remember" runat="server" Text=" Remember Me" OnCheckedChanged="Remember_CheckedChanged" />
        <br />
        <br />
        <asp:Button ID="LogInBut" runat="server" Height="40px" Text="Log In" Width="95px" OnClick="LogInBut_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LogInErr" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
        <br />
        <br />
    </form>
</body>
</html>
