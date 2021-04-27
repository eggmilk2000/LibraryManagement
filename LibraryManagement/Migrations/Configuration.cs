namespace LibraryManagement.Migrations
{
    using LibraryManagement.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryManagement.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LibraryManagement.Models.ApplicationDbContext";
        }

        protected override void Seed(LibraryManagement.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            if (context.Books.Any())
            {
                return;
            }
            context.Books.AddOrUpdate(
                new Book
                {
                    Title = "Harry Potter ",
                    Author = "J. K. Rowling",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Category = "Fantasy"
                },
                new Book
                {
                    Title = "No game no life",
                    Author = "Sora",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Category = "Action",
                },
                new Book
                {
                    Title = "Hello World",
                    Author = "Duong",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Category = "Comedy",
                }
            );
            context.Customers.AddOrUpdate(
                new Customer
                {
                    Name = "Holmes",
                    Address = "Baker Streets"
                },
                new Customer
                {
                    Name = "James",
                    Address = "Ha Noi Streets"
                }
                );
            context.SaveChanges();
        }
    }
}
