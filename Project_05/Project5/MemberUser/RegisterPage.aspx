<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Project5.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Welcome to be a new member!"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Please enter your preferred user name: " Font-Bold="True" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="nameInput" runat="server" Width="156px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="userExist" runat="server" Font-Bold="True" ForeColor="Red" Text="User name has already exist! " Visible="False"></asp:Label>
            <asp:HyperLink ID="toLogin" runat="server" NavigateUrl="../MemberUser/LogInPage.aspx" Visible="False">Log In</asp:HyperLink>
            <br />
            <br />
            <asp:Label ID="UserNameNotice" runat="server" Text="(User name should has a length between 3 - 16, without special characters except &quot;_&quot;)"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Medium" Text="Please Enter your password: "></asp:Label>
            <asp:TextBox ID="password" runat="server" Width="165px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Label ID="pwdInvalid" runat="server" Font-Bold="True" ForeColor="Red" Text="Invalid Password!" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="PwdNotice" runat="server" Text="(Password should has a length between 8 - 16, with at least one capital letter)"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Re-enter your password: " Font-Bold="True" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="passwordReenter" runat="server" Width="165px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="pwdError" runat="server" Font-Bold="True" ForeColor="Red" Text="Password Mismatch!" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="To check you are a human user:"></asp:Label>
&nbsp;<asp:ImageButton ID="CaptchaImg" runat="server" Height="38px" Width="131px" OnClick="CaptchaImg_Click" ImageUrl="init.png" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Please enter the captcha:" Font-Bold="True" Font-Size="Medium"></asp:Label>
&nbsp;<asp:TextBox ID="captchaInput" runat="server"></asp:TextBox>
&nbsp;
            <br />
            <br />
            <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" Font-Size="Medium" />
        &nbsp;&nbsp;&nbsp;
            <asp:Label ID="regError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="* This page will redirect to the Member page automatically after you create an account successfully."></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Public.aspx">Back to main page</asp:HyperLink>
        </div>
    </form>
</body>
</html>
