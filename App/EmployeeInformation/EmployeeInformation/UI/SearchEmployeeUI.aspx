<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchEmployeeUI.aspx.cs" Inherits="EmployeeInformation.UI.SearchEmployeeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
           <legend>Save Employee</legend>
           <table>
                <tr>
                   <td>
                        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                   </td>
                     <td>
                         <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
                   </td>
               </tr>
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
                        <asp:Label ID="Label3" runat="server" Text="ContactNo"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="contactNoTextBox" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                        <asp:Label ID="Label6" runat="server" Text="BloodGroup"></asp:Label>
                   </td>
                   <td>
                       <asp:DropDownList ID="bloodGroupDropDownList" runat="server" Width="126px">
                           <asp:ListItem>A+</asp:ListItem>
                           <asp:ListItem>A-</asp:ListItem>
                           <asp:ListItem>B+</asp:ListItem>
                           <asp:ListItem>B-</asp:ListItem>
                           <asp:ListItem>AB+</asp:ListItem>
                           <asp:ListItem>AB-</asp:ListItem>
                           <asp:ListItem>O+</asp:ListItem>
                           <asp:ListItem>O-</asp:ListItem>
                       </asp:DropDownList>
                   </td>
               </tr>
                <tr>
                   <td>
                        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:Button ID="deleteButton" runat="server" Text="Delete" OnClick="deleteButton_Click" />
                   </td>
                   <td>
                       <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:HiddenField ID="idHiddenField" runat="server" />
                   </td>
                   <td>
                       <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
                <tr>
                   <td>
                      <a href="IndexUI.aspx">Index</a>
                   </td>
                   <td>
                      <a href="SaveEmployeeUI.aspx">Save Employee</a>
                   </td>
               </tr>
           </table>
       </fieldset>
    </div>
    </form>
</body>
</html>
