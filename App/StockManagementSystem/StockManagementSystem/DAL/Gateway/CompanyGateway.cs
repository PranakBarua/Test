using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using StockManagementSystem.DAL.Model;

namespace StockManagementSystem.DAL.Gateway
{
    public class CompanyGateway:CommonGateway
    {
        public int Save(Company company)
        {
            Query = "INSERT INTO Company VALUES(@name)";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.Add("name", SqlDbType.VarChar);
            Command.Parameters["name"].Value = company.Name;
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }

        public bool IsNameExists(string name)
        {
            Query = "SELECT * FROM Company WHERE Name=@name";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.Add("name", SqlDbType.VarChar);
            Command.Parameters["name"].Value = name;
            Reader = Command.ExecuteReader();
            bool hasRows = false;
            if (Reader.HasRows)
            {
                hasRows = true;
            }
            Reader.Close();
            Connection.Close();
            return hasRows;

        }

        public List<Company> GetAllCompany()
        {
            Query = "SELECT * FROM Company";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Company>companies=new List<Company>();
            while (Reader.Read())
            {
                Company company=new Company();
                company.Id = (int) Reader["Id"];
                company.Name = Reader["Name"].ToString();
                companies.Add(company);
            }
            Reader.Close();
            Connection.Close();
            return companies;
        }
    }
}