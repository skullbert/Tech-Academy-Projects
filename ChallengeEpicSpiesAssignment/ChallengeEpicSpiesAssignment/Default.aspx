<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 242px;
            height: 300px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="Logo" class="auto-style1" src="epic-spies-logo.jpg" /></div>
        <h2 class="auto-style2">Spy New Assignment Form</h2>
        
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="nameBox" runat="server" OnTextChanged="nameBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:&nbsp;
            <asp:TextBox ID="assignmentBox" runat="server"></asp:TextBox>
        </p>
        <div>
            End Date of Previous Assignment:<br />
            <asp:Calendar ID="prevCalendar" runat="server"></asp:Calendar>
        </div>
    <div>
        Start Date of New Assignment:<br />
        <asp:Calendar ID="startCalendar" runat="server"></asp:Calendar>
        </div>
    <div>
        &nbsp;Projected End Date of New Assignment:<br />
        <asp:Calendar ID="projCalendar" runat="server"></asp:Calendar>
        </div>
        <p>
            <asp:Button ID="assignButton" runat="server" Text="Assign Spy" OnClick="assignButton_Click" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
    </body>
</html>
