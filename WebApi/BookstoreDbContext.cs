﻿using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi
{
    public class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
