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
    public partial class ItemUI : System.Web.UI.Page
    {
        CategoryManager categoryManager=new CategoryManager();
        CompanyManager companyManager=new CompanyManager();
        ItemManager itemManager=new ItemManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Category> categories = categoryManager.GetAllCategory();
                categoryDropDownList.DataSource = categories;
                categoryDropDownList.DataValueField = "Id";
                categoryDropDownList.DataTextField = "Name";
                categoryDropDownList.DataBind();
                categoryDropDownList.Items.Insert(0, new ListItem("--Select Category--", "0"));

                List<Company> companies = companyManager.GetAllCompanies();
                companyDropDownList.DataSource = companies;
                companyDropDownList.DataValueField = "Id";
                companyDropDownList.DataTextField = "Name";
                companyDropDownList.DataBind();
                companyDropDownList.Items.Insert(0, new ListItem("--Select Category--", "0"));
            }
          
            
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Item item=new Item();
            item.Name = itemTextBox.Text;
            item.CategoryId = Convert.ToInt32(categoryDropDownList.SelectedValue);
            item.CompanyId = Convert.ToInt32(companyDropDownList.SelectedValue);
            item.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
            messageLabel.Text = itemManager.Save(item);
        }
    }
}