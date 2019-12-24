using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementSystem.DAL.Model;

namespace StockManagementSystem.DAL.Gateway
{
    public class CategoryGateway:CommonGateway
    {
        public int Save(Category category)
        {
            Query = "INSERT INTO Category VALUES(@name)";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.Add("name",SqlDbType.VarChar);
            Command.Parameters["name"].Value = category.Name;
            //Command.Parameters["name"].Value = category.Name;
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool IsNameExists(string name)
        {
            Query = "SELECT * FROM Category WHERE Name='"+name+"'";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            //Command.Parameters.Clear();
            //Command.Parameters.Add("name", SqlDbType.VarChar);
            //Command.Parameters["name"].Value = name;
            Reader = Command.ExecuteReader();
            bool hasRows = false;
            if (Reader.HasRows)
            {
                hasRows = true;
            }
            Connection.Close();
            return hasRows;

        }

        public List<Category> GetAllCategory()
        {
            Query = "SELECT * FROM Category";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader=Command.ExecuteReader();
            List<Category>categories=new List<Category>();
            while (Reader.Read())
            {
                Category category=new Category();
                category.Id = (int) Reader["Id"];
                category.Name = Reader["Name"].ToString();
                categories.Add(category);
            }
            Connection.Close();
            return categories;
        } 
    }
}