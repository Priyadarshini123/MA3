<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="feedback.aspx.cs" Inherits="WebApplication3.feedback" %>
<style>
body {
    background-image:url("tq1.jpg");
    background-repeat:no-repeat;
    background-attachment:fixed;
}
    </style>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <div>
   <form id="feedback" method="post" runat="server">
	<p><asp:Label ID="lblFname" runat="server">First Name:</asp:Label>
	<asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
	</p>
	<p>Is this your first visit to the site?<br />
	<asp:RadioButton ID="btnfirstvisitYes" GroupName="firstvisit" Text="Yes" runat="server" />
	<asp:RadioButton ID="btnfirstvisitNo" GroupName="firstvisit" Text="No" runat="server" />
	</p>
	<p>How did you hear about our site? (Check all that apply)
	<asp:CheckBoxList ID="cbxlHeard" runat="server">
        <asp:ListItem>Advertisement</asp:ListItem>
        <asp:ListItem>Search Engine</asp:ListItem>
        <asp:ListItem>Another Site (specify below)</asp:ListItem>
        <asp:ListItem>Family</asp:ListItem>
        <asp:ListItem>Friend</asp:ListItem>
        <asp:ListItem>Other (specify below)</asp:ListItem>
    </asp:CheckBoxList>
	</p>
	<p>
	<asp:Label ID="lblspecify" runat="server">Specify the previous answer here: (be brief)</asp:Label>
	<asp:TextBox ID="txtspecify" runat="server"></asp:TextBox>
	</p>
	<p><asp:Label ID="lblopinion" runat="server">What do you think about the site layout?</asp:Label>
	<asp:DropDownList ID="ddlopinion" runat="server">
	<asp:ListItem Selected="True">--=Select=--</asp:ListItem>
	<asp:ListItem>5 - Very Well Done!</asp:ListItem>
	<asp:ListItem>4 - Quite Nice</asp:ListItem>
	<asp:ListItem>3 - It's okay</asp:ListItem>
	<asp:ListItem>2 - Could be better</asp:ListItem>
	<asp:ListItem>1 - Not good</asp:ListItem>
	</asp:DropDownList>
	</p>
	

	<p>Please let us know how we can improve our services and/or our website!
        <br>
        <p> Enter text here....</p>
	<asp:TextBox ID="txtcomments" Height="150px" Width="300px" runat="server"></asp:TextBox>
	</p>
	<asp:Button runat="server" ID="Submit" Text="Submit" OnClick="doSubmit" />
	<asp:Button runat="server" ID="Reset" Text="Clear Form" OnClick="Reset_Click"  />
	</form>
</body>
</html>
