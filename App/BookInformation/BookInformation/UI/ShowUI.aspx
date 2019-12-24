<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowUI.aspx.cs" Inherits="BookInformation.UI.ShowUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
            <legend>Show</legend>
            <table>
                <tr>
                    <td>
                        
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
                    </td>
                </tr>

            </table>
        </fieldset>
        <tr>
                <td>
                    <a href="Index.aspx">Index</a>
                </td>
                <td>
                    <a href="AddBookUI.aspx">Add</a>
                </td>
            </tr>
        <asp:GridView ID="bookGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="SL#">
                   <ItemTemplate><%# Container.DataItemIndex+1 %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ISBN">
                   <ItemTemplate><%# Eval("isbn") %></ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Name">
                   <ItemTemplate><%# Eval("Name") %></ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Author">
                   <ItemTemplate><%# Eval("Author") %></ItemTemplate>
                </asp:TemplateField>
            </Columns>

        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
