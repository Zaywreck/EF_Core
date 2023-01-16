using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using OOP.EFCore.ConsoleApp.DAL_data_access_layer;
using OOP.EFCore.ConsoleApp.Entities;

class Program
{
    static void Main()
    {
        //var _context = new BookAppDbContext();
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


        //AddBook(); //refactored
        //AddManyBooks(); // refactored
        //UpdateFirstBook();
        //RemoveLastBook();
        //AddBookWithCategory();

        //AddBookWithBookDetail();
        ListOfBooks();
    }

    private static void AddBookWithBookDetail()
    {
        using (var _context = new BookAppDbContext())
        {
            var book = new Book
            {
                Title = "Database Management",
                Price = 250,
                Category = _context.Categories.ToList().OrderBy(c => c.CategoryId).First(),
                BookDetail = new BookDetail
                {
                    City = "Ankara",
                    Country = "Turkey",
                    ISSN = "5214-4215-8563"
                }
            };
            _context.Books.Add(book);
            _context.SaveChanges();
        }
    }

    private static void AddBookWithCategory()
    {
        var book = new Book()
        {
            Title = "Software in Today",
            Price = 200,
            Category = new Category()
            {
                CategoryName = "Software"
            }
        };
        using (var _context = new BookAppDbContext())
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            ListOfBooks();
            _context.Categories.ToList().ForEach(c => Console.WriteLine(c.CategoryName));
        }
    }

    private static void RemoveLastBook()
    {
        using (var _context = new BookAppDbContext())
        {
            var temp = _context.Books.OrderBy(b => b.BookId).Last();                                                                                                                                
            _context.Books.Remove(temp);
            _context.SaveChanges();
        }
    }

    private static void UpdateFirstBook()
    {
        using (var _context = new BookAppDbContext())
        {
            var first_book = _context.Books.OrderBy(b => b.BookId).First();
            first_book.Title = "Senden Önce Ben";
            first_book.Price = 100;
            _context.SaveChanges();
        }
    }

    private static void ListOfBooks()
    {
        var list = new List<Book>();
        using (var _context = new BookAppDbContext())
        {
            list = _context.Books.ToList();
            foreach (var book in list)
            {
                Console.WriteLine($"{book.Title,-20} {book.Price,-10}");
            }
        }
    }

    private static void AddManyBooks()
    {

        var list = new List<Book>()
        {
            new Book { Title= "EF Core1" ,Price= 5},
            new Book { Title= "EF Core2" ,Price= 10},
            new Book { Title= "EF Core3" ,Price= 15},
            new Book { Title= "EF Core4" ,Price= 20}
        };
        using (var _context = new BookAppDbContext())
        {
            _context.AddRange(list);
            _context.SaveChanges();
        }
    }

    private static void AddBook()
    {
        var book = new Book()
        {
            Title = "Entity Framework Core",
            Price = 100
        };
        using (var _context = new BookAppDbContext())
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
    }
}