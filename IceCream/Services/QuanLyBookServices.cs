﻿using IceCream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Services
{
     public interface QuanLyBookServices
    {
        List<Book> FindAllBook();
        public bool Update(Book book);

    }
}
