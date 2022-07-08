using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebDev.BookStore.Models;
using WebDev.BookStore.Repository;

namespace WebDev.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository= null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllbooks()
        {
            var data = _bookRepository.GetAllbooks();

            return View();
        }
        public BookModel Getbooks(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
