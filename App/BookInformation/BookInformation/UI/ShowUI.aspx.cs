using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookInformation.BLL;
using BookInformation.DAL.Model;

namespace BookInformation.UI
{
    public partial class ShowUI : System.Web.UI.Page
    {
        BookManager bookManager=new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            List<Book> books = bookManager.GetAllBooks();
            bookGridView.DataSource = books;
            bookGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (name == "")
            {
                PopulateGridView();
            }
            else
            {
                List<Book> books = bookManager.Search(name);
                bookGridView.DataSource = books;
                bookGridView.DataBind();
            }               
        }
    }
}