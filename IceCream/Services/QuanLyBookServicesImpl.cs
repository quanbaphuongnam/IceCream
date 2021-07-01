using IceCream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Services
{
    public class QuanLyBookSercicesImpl : QuanLyBookServices
    {
        public DatabaseContext db;
        public QuanLyBookSercicesImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public List<Book> FindAllBook()
        {
            return db.Books.ToList();
        }

        public bool Update(Book book)
        {
            var bookupdate = db.Books.Find(book.BookId);
            bookupdate.BookName = book.BookName;
            bookupdate.BookPhoto = book.BookPhoto;
            bookupdate.BookPrice = book.BookPrice;
            bookupdate.BookQuantity = book.BookQuantity;
            bookupdate.BookYear = book.BookYear;
            bookupdate.BookCreated = book.BookCreated;
            db.SaveChanges();
            return true;
            
        }
    }
}
