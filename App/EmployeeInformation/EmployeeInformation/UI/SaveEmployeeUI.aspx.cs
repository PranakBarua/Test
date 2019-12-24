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
    public partial class SaveEmployeeUI : System.Web.UI.Page
    {
        EmployeeManager employeeManager=new EmployeeManager();
        DepartmentManager departmentManager=new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Department> departments = departmentManager.GetAllDepartments();
                departmentDropDownList.DataSource = departments;
                departmentDropDownList.DataValueField = "Id";
                departmentDropDownList.DataTextField = "Name";
                departmentDropDownList.DataBind();
            }
           
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            List<EmployeeViewModel> employees = employeeManager.GetAllEmployees();
            employeeGridView.DataSource = employees;
            employeeGridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Employee employee=new Employee();
            employee.Name = nameTextBox.Text;
            employee.Email = emailTextBox.Text;
            employee.ContactNo = contactNoTextBox.Text;
            employee.DepartmentId = Convert.ToInt32(departmentDropDownList.SelectedValue);
            employee.BloodGroup = bloodGroupDropDownList.Text;
            employee.Address = addressTextBox.Text;
            messageLabel.Text = employeeManager.Save(employee);
            PopulateGridView();
        }
    }
}