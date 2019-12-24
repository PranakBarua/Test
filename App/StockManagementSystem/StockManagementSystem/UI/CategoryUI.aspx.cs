using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementSystem.BLL;
using StockManagementSystem.DAL.Model;

namespace StockManagementSystem.UI
{
    public partial class CategoryUI : System.Web.UI.Page
    {
        CategoryManager categoryManager=new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            List<Category> categories = categoryManager.GetAllCategory();
            categoryGridView.DataSource = categories;
            categoryGridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Category category=new Category();
            category.Name = nameTextBox.Text;
            messageLabel.Text=categoryManager.Save(category);
            PopulateGridView();
        }

    }
}