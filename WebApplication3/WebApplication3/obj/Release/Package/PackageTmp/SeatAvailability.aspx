<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeatAvailability.aspx.cs" Inherits="WebApplication3.SeatAvailability" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4> Enter the seat No You want to choose:</h4>
       


        <input type="text" value="Username" class="input-text autoclear" 
   runat="server" id="seatno" />
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    </form>
</body>
</html>
