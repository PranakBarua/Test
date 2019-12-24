using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using EmployeeInformation.DAL.Model;

namespace EmployeeInformation.DAL.Gateway
{
    public class EmployeeGateway:Gateway
    {


        public int Save(Employee employee)
        {
            Query = "INSERT INTO Employees VALUES('"+employee.Name+"'," +
                           "'"+employee.Email+"'," +
                           "'"+employee.ContactNo+"'," +
                           "'"+employee.BloodGroup+"'," +
                           "'"+employee.Address+"'," +
                           "'"+employee.DepartmentId+"')";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            int rowAffected=Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool IsEmailExits(Employee employee)
        {
            Query = "SELECT * FROM Employees WHERE Email='"+employee.Email+"' AND Id <>"+employee.Id;
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader=Command.ExecuteReader();
            bool hasRows = false;
            if (Reader.HasRows)
            {
                hasRows = true;
            }
            Connection.Close();
            return hasRows;

        }

        public List<EmployeeViewModel> GetAllEmployees()
        {
            Query = "SELECT * FROM GetEmployeeWithDepartment";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<EmployeeViewModel> employees = new List<EmployeeViewModel>();
            while (Reader.Read())
            {
                EmployeeViewModel employee = new EmployeeViewModel();
                employee.EmpId = Convert.ToInt32(Reader["EmpId"]);
                employee.EmpName = Reader["EmpName"].ToString();
                employee.Email = Reader["Email"].ToString();
                employee.ContactNo = Reader["ContactNo"].ToString();
                employee.DepartmentId = Convert.ToInt32(Reader["DeptId"]);
                employee.BloodGroup = Reader["BloodGroup"].ToString();
                employee.Address = Reader["Address"].ToString();
                employee.DeptName = Reader["DeptName"].ToString();
                employee.Location = Reader["Location"].ToString();
                employees.Add(employee);
            }
            Reader.Close();
            Connection.Close();
            return employees;
        }

        public Employee Search(string email)
        {
            Query = "SELECT * FROM Employees WHERE Email='"+email+"'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Employee employee = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                employee=new Employee();
                employee.Id = (int) Reader["Id"];
                employee.Name = Reader["Name"].ToString();
                employee.ContactNo = Reader["ContactNo"].ToString();
                employee.BloodGroup = Reader["BloodGroup"].ToString();
                employee.Address = Reader["Address"].ToString();
            }
            Reader.Close();
            Connection.Close();
            return employee;
        }


        public int Update(Employee employee)
        {
            Query = "UPDATE Employees SET Name='"+employee.Name+"'," +
                           "Email='"+employee.Email+"',ContactNo='"+employee.ContactNo+"'," +
                           "BloodGroup='"+employee.BloodGroup+"',Address='"+employee.Address+"'" +
                           "WHERE Id="+employee.Id;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public int Delete(int id)
        {
            Query = "DELETE FROM Employees WHERE Id="+id;
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            int rowAffected=Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}