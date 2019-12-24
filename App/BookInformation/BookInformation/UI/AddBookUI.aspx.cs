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
    public partial class AddBookUI : System.Web.UI.Page
    {
        BookManager bookManager=new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Book abook=new Book();
            abook.Name = nameTextBox.Text;
            abook.Isbn = isbnTextBox.Text;
            abook.Author = authorTextBox.Text;

            messageLabel.Text=bookManager.Save(abook);
        }
    }
}