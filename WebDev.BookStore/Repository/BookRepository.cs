using System.Collections.Generic;
using System.Linq;
using WebDev.BookStore.Models;

namespace WebDev.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllbooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorname)
        {
            return DataSource().Where(x => x.Title == title || x.Author == authorname).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() {Id=1, Title = "MVC", Author = "musabbir" },
                new BookModel() {Id=2, Title = "C", Author = "Sifat" },
                new BookModel() {Id=3, Title = "C#", Author = "hossain" },
                new BookModel() {Id=4, Title = "C++", Author = "Chowdhury" },
                new BookModel() {Id=5, Title = "Java", Author = "musa" },
            };
        }
    }
}
