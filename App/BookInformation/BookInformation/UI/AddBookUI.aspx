<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBookUI.aspx.cs" Inherits="BookInformation.UI.AddBookUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Add Book</legend>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="ISBN"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="isbnTextBox" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox> 
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
            <tr>
                <td>
                    <a href="Index.aspx">Index</a>
                </td>
                <td>
                    <a href="ShowUI.aspx">Show</a>
                </td>
            </tr>
        </table>
    </fieldset>
    </div>
    </form>
</body>
</html>
