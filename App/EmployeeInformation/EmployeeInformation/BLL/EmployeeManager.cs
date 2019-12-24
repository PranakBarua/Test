using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeInformation.DAL.Gateway;
using EmployeeInformation.DAL.Model;

namespace EmployeeInformation.BLL
{
    public class EmployeeManager
    {
        EmployeeGateway employeeGateway=new EmployeeGateway();

        public string Save(Employee employee)
        {

            if (employeeGateway.IsEmailExits(employee))
                return "Employee exists";
            int rowAffected = employeeGateway.Save(employee);
            if (rowAffected > 0)
            {
                return "Employee saved successfully";
            }
            return "employee saved failed";
        }

        public List<EmployeeViewModel> GetAllEmployees()
        {
            return employeeGateway.GetAllEmployees();
        }

        public Employee Search(string email)
        {
            return employeeGateway.Search(email);
        }

        public string Update(Employee employee)
        {
            if (employeeGateway.IsEmailExits(employee))
                return "Employee exists";
            int rowAffected = employeeGateway.Update(employee);
            if (rowAffected > 0)
            {
                return "Employee updated successfully";
            }
            return "employee updated failed";
        }

        public string Delete(int id)
        {
            int rowAffected = employeeGateway.Delete(id);
            if (rowAffected > 0)
                return "Employee deleted";
            return "Employee deleted failed";
        }
    }
}