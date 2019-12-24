using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystem.DAL.Gateway;
using StockManagementSystem.DAL.Model;

namespace StockManagementSystem.BLL
{
    public class CompanyManager
    {
        CompanyGateway companyGateway=new CompanyGateway();

        public string Save(Company company)
        {
            if (companyGateway.IsNameExists(company.Name))
            {
                return "Company Exists";
            }
            int rowAffected = companyGateway.Save(company);
            if (rowAffected > 0)
                return "Saved Successfully";
            return "Saved failed";
        }

        public List<Company> GetAllCompanies()
        {
            return companyGateway.GetAllCompany();
        } 
    }
}