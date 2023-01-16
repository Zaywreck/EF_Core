namespace OOP.EFCore.ConsoleApp.Entities
{
    public class Category // princible entity
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }

        // collection navigation property
        public ICollection<Book>? Books { get; set; }
    }
}
