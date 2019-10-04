using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CS321_W3D1_BookAPI.Models;


namespace CS321_W3D1_BookAPI.Data

{
    public class BookContext : DbContext

    {
        // TODO: implement a DbSet<Book> property
        public DbSet<Book> Books { get; set; }
        // This method runs once when the DbContext is first used.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: use optionsBuilder to configure a Sqlite db
            optionsBuilder.UseSqlite("Data Source = Books.db");
        }

        // This method runs once when the DbContext is first used.
        // It's a place where we can customize how EF Core maps our
        // model to the database. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TODO: configure some seed data in the books table
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Book One of Trilogy", Author = "John Doe", Category = "Fantasy" },
                new Book { Id = 2, Title = "Book Two of Trilogy", Author = "John Doe", Category = "Fantasy" },
                new Book { Id = 3, Title = "Book Three of Trilogy", Author = "John Doe", Category = "Fantasy" },
                new Book { Id = 4, Title = "Trendy Book", Author = "Jane Smith", Category = "Mystery" }
            );
        }
    }
}