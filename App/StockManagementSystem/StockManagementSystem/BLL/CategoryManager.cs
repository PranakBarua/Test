using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystem.DAL.Gateway;
using StockManagementSystem.DAL.Model;

namespace StockManagementSystem.BLL
{
    public class CategoryManager
    {
        CategoryGateway categoryGateway=new CategoryGateway();
        public string Save(Category category)
        {
            if (categoryGateway.IsNameExists(category.Name))
            {
                return "Name Exists";
            }
            int rowAffectd = categoryGateway.Save(category);
            if (rowAffectd > 0)
                return "Category saved successfully";
            return "Category saved failed";
        }

        public List<Category> GetAllCategory()
        {
            return categoryGateway.GetAllCategory();
        } 
    }
}