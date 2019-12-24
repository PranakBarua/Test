using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementSystem.DAL.Model;

namespace StockManagementSystem.DAL.Gateway
{
    public class ItemGateway:CommonGateway
    {
        public int Save(Item item)
        {
            Query = "INSERT INTO Item VALUES(@name,@categoryId,@companyId,@reorderlevel)";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.Add("name", SqlDbType.VarChar);
            Command.Parameters["name"].Value = item.Name;
            Command.Parameters.Add("categoryId", SqlDbType.Int);
            Command.Parameters["categoryId"].Value = item.CategoryId;
            Command.Parameters.Add("companyId", SqlDbType.Int);
            Command.Parameters["companyId"].Value = item.CompanyId;
            Command.Parameters.Add("reorderlevel", SqlDbType.Int);
            Command.Parameters["reorderlevel"].Value = item.ReorderLevel;
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool IsNameExists(string name)
        {
            Query = "SELECT * FROM Item WHERE Name=@name";
            Command = new SqlCommand(Query, Connection);
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
    }
}