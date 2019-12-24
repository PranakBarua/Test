using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeInformation.BLL;
using EmployeeInformation.DAL.Model;

namespace EmployeeInformation.UI
{
    public partial class SearchEmployeeUI : System.Web.UI.Page
    {
        EmployeeManager employeeManager=new EmployeeManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            clear();
            string email = emailTextBox.Text;
            Employee employee = employeeManager.Search(email);
            if (employee == null)
            {
                messageLabel.Text = "No employee found";
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            else
            {
                messageLabel.Text = "Employee found";
                idHiddenField.Value = employee.Id.ToString();               
                nameTextBox.Text = employee.Name;
                contactNoTextBox.Text = employee.ContactNo;
                bloodGroupDropDownList.Text = employee.BloodGroup;
                addressTextBox.Text = employee.Address;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void clear()
        {
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            contactNoTextBox.Text = "";
            bloodGroupDropDownList.Text = "";
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Employee employee=new Employee();
            employee.Id = Convert.ToInt32(idHiddenField.Value);
            employee.Name = nameTextBox.Text;
            employee.Email = emailTextBox.Text;
            employee.ContactNo = contactNoTextBox.Text;
            employee.BloodGroup = bloodGroupDropDownList.Text;
            employee.Address = addressTextBox.Text;
            messageLabel.Text=employeeManager.Update(employee);
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idHiddenField.Value);
            messageLabel.Text = employeeManager.Delete(id);
        }
        

    }
}