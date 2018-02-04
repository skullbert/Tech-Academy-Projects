<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge6.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="epic-spies-logo.jpg" />
        <br />
        <br />
        Spy New Assignment Form</div>
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <div>
            End Date of Previous Assignment:<br />
            <asp:Calendar ID="prevCalendar" runat="server" SelectedDate="2018-01-15"></asp:Calendar>
        </div>
    <div>
        <br />
        Start Date of New Assignment:<br />
        <asp:Calendar ID="startCalendar" runat="server" SelectedDate="2018-01-29"></asp:Calendar>
        </div>
    <div>
        <br />
        Projected End Date of New Assignment:<asp:Calendar ID="endCalendar" runat="server" SelectedDate="2018-02-05"></asp:Calendar>
        <br />
        </div>
        <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
    </body>
</html>
