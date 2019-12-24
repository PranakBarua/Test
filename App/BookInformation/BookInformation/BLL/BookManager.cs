using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookInformation.DAL.Gateway;
using BookInformation.DAL.Model;

namespace BookInformation.BLL
{
    public class BookManager
    {
        BookGateway bookGateway=new BookGateway();
        public string Save(Book abook)
        {
            if (bookGateway.IsISBNExists(abook.Isbn))
            {
                return "ISBN exists";
            }
            if (abook.Isbn.Length != 13)
                return "ISBN must thirteen 13 characters long.";
            int rowAffected = bookGateway.Save(abook);
            if (rowAffected > 0)
                return "Book saved succesfully";
            return "Book saved failed";
        }


        public List<Book> Search(string name)
        {
        
            return bookGateway.Search(name);
        }

        public List<Book> GetAllBooks()
        {
            return bookGateway.GetAllBooks();
        } 
    }
}