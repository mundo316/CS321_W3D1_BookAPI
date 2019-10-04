using System;
using CS321_W3D1_BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using CS321_W3D1_BookAPI.Data;
using CS321_W3D1_BookAPI.Controllers;


namespace CS321_W3D1_BookAPI.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _bookContext;

        public BookService(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookContext.Books.ToList();
        }

        public Book Get(int id)
        {
            return _bookContext.Books.FirstOrDefault(b => b.Id == id);
        }

        public Book Add(Book book)
        {
            _bookContext.Books.Add(book);
            _bookContext.SaveChanges();
            return book;
        }

        public Book Update(Book updatedBook)
        {
            var currentBook = _bookContext.Books.FirstOrDefault(b => b.Id == updatedBook.Id);
            if (currentBook == null) return null;
            _bookContext.Entry(currentBook).CurrentValues.SetValues(updatedBook);
            _bookContext.SaveChanges();
            return updatedBook;
        }

        public void Remove(Book book)
        {
            _bookContext.Books.Remove(book);
            _bookContext.SaveChanges();
        }
    }
}
