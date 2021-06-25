﻿using IceCream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Services
{
    public class BookServiceImpl : BookService
    {
        public DatabaseContext db;
        public BookServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public List<Book> FindAllBook()
        {
            return db.Books.ToList();
        }
    }
}