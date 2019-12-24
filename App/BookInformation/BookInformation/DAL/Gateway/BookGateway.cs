using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookInformation.DAL.Model;

namespace BookInformation.DAL.Gateway
{
    public class BookGateway:Gateway
    {
        

        public int Save(Book abook)
        {
            Query = "INSERT INTO Books VALUES('"+abook.Name+"','"+abook.Isbn+"','"+abook.Author+"')";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            int rowAffected=Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool IsISBNExists(String isbn)
        {
            Query = "SELECT * FROM Books WHERE ISBN='" + isbn + "'";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader=Command.ExecuteReader();
            bool hasRows = false;
            if (Reader.HasRows)
            {
                hasRows = true;
            }
            Connection.Close();
            return hasRows;
        }

        public List<Book> Search(string name)
        {
            Query = "SELECT * FROM Books WHERE Name='"+name+"'";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            List<Book> books=new List<Book>();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Book abook=new Book();
                abook.Name = Reader["Name"].ToString();
                abook.Isbn = Reader["ISBN"].ToString();
                abook.Author = Reader["Author"].ToString();
                books.Add(abook);
            }
            Connection.Close();
            return books;
        }

        public List<Book> GetAllBooks()
        {
            Query = "SELECT * FROM Books";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            List<Book> books = new List<Book>();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Book abook = new Book();
                abook.Name = Reader["Name"].ToString();
                abook.Isbn = Reader["ISBN"].ToString();
                abook.Author = Reader["Author"].ToString();
                books.Add(abook);
            }
            Connection.Close();
            return books;
        } 
    }
}