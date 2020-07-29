using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class BookRepository
    {

        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title ,string authorname)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorname)).ToList();
        }

        private List<BookModel> DataSource ()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=101,Title="MVC",Author="Nitish"},
                new BookModel(){Id=102,Title="Java",Author="Abhi"},
                new BookModel(){Id=103,Title="C#",Author="RN Reddy"},

            };
        }
    }
}
