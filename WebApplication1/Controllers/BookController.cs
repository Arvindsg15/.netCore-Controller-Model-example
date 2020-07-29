using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    { 
        private readonly BookRepository _bookrepository = null;
        public BookController()
        {
            _bookrepository = new BookRepository();
        }

        public List<BookModel> GetBooks()
        {
            return _bookrepository.GetAllBooks();
        }

        public BookModel GetById(int id)
        {
            return _bookrepository.GetBookById(id);
        }

        public List<BookModel> Search(string title,string author)
        {
            return _bookrepository.SearchBook(title, author);
        }
    }
}
