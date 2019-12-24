using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using EmployeeInformation.DAL.Model;

namespace EmployeeInformation.DAL.Gateway
{
    public class DepartmentGateway:Gateway
    {
        
        public List<Department> GetAllDepartments()
        {
            Query = "SELECT * FROM Departments";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader=Command.ExecuteReader();
            List<Department> departments=new List<Department>();
            while (Reader.Read())
            {
                Department department=new Department();
                department.Id = (int) Reader["Id"];
                department.Name = Reader["Name"].ToString();
                department.Location = Reader["Location"].ToString();
                departments.Add(department);
            }
            return departments;
        } 

    }
}