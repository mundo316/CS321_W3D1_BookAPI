using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CS321_W3D1_BookAPI.Models;
using CS321_W3D1_BookAPI.Data;
using CS321_W3D1_BookAPI.Controllers;
using System.Linq;

namespace CS321_W3D1_BookAPI.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();

        Book Get(int id);
        Book Add(Book book);
        Book Update(Book book);
        void Remove(Book book);
    }
}
