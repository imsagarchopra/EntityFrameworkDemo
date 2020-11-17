<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TablePerHierarchyInheritanceWithDbFirst.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True"
                OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Text="Load all Employees" Value="All"></asp:ListItem>
                <asp:ListItem Text="Load Permanent Employees" Value="Permanent"></asp:ListItem>
                <asp:ListItem Text="Load Contract Employees" Value="Contract"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
