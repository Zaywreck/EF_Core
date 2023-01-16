﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EFCore.ConsoleApp.Entities
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName => string.Concat(FirstName, LastName);
        public DateTime CreatedDate { get; set; }
        // many to many - many navigation property
        public ICollection<BookAuthor>? BookAuthors { get; set; }
    }
}
