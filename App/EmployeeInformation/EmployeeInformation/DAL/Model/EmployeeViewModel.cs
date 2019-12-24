using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInformation.DAL.Model
{
    public class EmployeeViewModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public int DepartmentId { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }

    }
}