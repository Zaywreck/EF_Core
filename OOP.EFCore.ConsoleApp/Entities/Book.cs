using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EFCore.ConsoleApp.Entities
{
    public class Book
    {
        //[Key]
        public int BookId { get; set; }
        //[Required]
        //[MaxLength(50)]
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        // Foreign Key
        public int? CategoryId { get; set; }
        // simple navigation property
        public Category? Category { get; set; }
        // navigation property
        public BookDetail? BookDetail { get; set; }
        // collection navigation property
        public ICollection<BookAuthor> BookAuthors { get; set; }
        public Book(int bookId, string? title ,decimal price)
        {
            BookId = bookId;
            Title = title;
            Price = price;
        }
    }
}
