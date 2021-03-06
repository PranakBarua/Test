﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInformation.DAL.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public int DepartmentId { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
    }
}