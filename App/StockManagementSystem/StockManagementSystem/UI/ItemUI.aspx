<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemUI.aspx.cs" Inherits="StockManagementSystem.UI.ItemUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
            <legend>Item Setup</legend>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Category"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="categoryDropDownList" runat="server" Width="128px"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Company"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="companyDropDownList" runat="server" Width="127px"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Item Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="itemTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                     <td>
                        <asp:Label ID="Label4" runat="server" Text="Reorder Level"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="reorderLevelTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </fieldset>
    
    </div>
    </form>
</body>
</html>
