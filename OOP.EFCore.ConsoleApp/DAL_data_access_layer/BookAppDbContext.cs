using Microsoft.EntityFrameworkCore;
using OOP.EFCore.ConsoleApp.DAL_data_access_layer.Mapping;
using OOP.EFCore.ConsoleApp.Entities;

namespace OOP.EFCore.ConsoleApp.DAL_data_access_layer
{
    public class BookAppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookDetail> BooksDetail { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookAppDb;Integrated Security=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new BookDetailMap());
            modelBuilder.ApplyConfiguration(new AuthorMap());
            modelBuilder.ApplyConfiguration(new BookAuthorMap());
        }
    }
}