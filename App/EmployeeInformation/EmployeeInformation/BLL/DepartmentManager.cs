using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeInformation.DAL.Gateway;
using EmployeeInformation.DAL.Model;

namespace EmployeeInformation.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway departmentGateway=new DepartmentGateway();

        public List<Department> GetAllDepartments()
        {
            return departmentGateway.GetAllDepartments();
        } 
    }
}