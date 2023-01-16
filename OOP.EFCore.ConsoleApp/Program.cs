using Microsoft.EntityFrameworkCore;
using OOP.EFCore.ConsoleApp.DAL_data_access_layer;
using OOP.EFCore.ConsoleApp.Entities;

class Program
{
    static void Main()
    {
        var _context = new BookAppDbContext();
        //var category = _context.Categories.Where(c => c.CategoryId == 4)
        //    .SingleOrDefault();
        //_context.Categories.Remove(category);
        //_context.SaveChanges();
        //Console.ReadKey();


        //var book = _context.Books.ToList();
        //var book1 = _context.Books.Where(b => b.Price < 5000); // 5000 den ucuz kitapları getirir.
        //var book2 = _context.Books.Select(b => b.Price).ToList();
        //List<Book> book3 = _context.Books.Include(I => I.BookDetail).Include(b => b.BookAuthors).ToList();


        //foreach (var item in book3)
        //{
        //    var id = item.BookDetail.BookDetailId;
        //}

        //var istenen = _context.Books.OrderBy(b => b.Price).Take(4).ToList();





    }

}