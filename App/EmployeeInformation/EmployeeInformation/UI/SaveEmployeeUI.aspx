<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SaveEmployeeUI.aspx.cs" Inherits="EmployeeInformation.UI.SaveEmployeeUI" %>

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
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                   </td>
               </tr>
                <tr>
                   <td>
                        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
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
                       <asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>
                   </td>
                   <td>
                       <asp:DropDownList ID="departmentDropDownList" runat="server" Height="16px" Width="129px"></asp:DropDownList>
                   </td>
               </tr>
               <tr>
                   <td>
                        <asp:Label ID="Label6" runat="server" Text="BloodGroup"></asp:Label>
                   </td>
                   <td>
                       <asp:DropDownList ID="bloodGroupDropDownList" runat="server" Width="130px" Height="17px">
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
                   <td></td>
                   <td>
                       <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
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
                      <a href="SearchEmployeeUI.aspx">Search Employee</a>
                   </td>
               </tr>
           </table>
       </fieldset>
        <asp:GridView ID="employeeGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Employee Name">
                    <ItemTemplate>
                        <asp:Label runat="server"><%#Eval("EmpName") %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:Label runat="server"><%#Eval("Email") %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField >
                 <asp:TemplateField HeaderText="Contact No">
                    <ItemTemplate>
                        <asp:Label runat="server"><%#Eval("ContactNo") %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Blood Group">
                    <ItemTemplate>
                        <asp:Label runat="server"><%#Eval("BloodGroup") %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Address" HeaderText="Address"/>
                 <asp:BoundField DataField="DeptName" HeaderText="Department Name"/>
                 <asp:BoundField DataField="Location" HeaderText="Location"/>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
