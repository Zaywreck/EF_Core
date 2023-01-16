namespace EfScaffoldDbContextApp
{
    public class Program
    {
        public static void Main()
        {
            using (var _context = new NorthwindDbContext())
            {
               var list = _context.Employees.ToList();
                foreach(var item in list)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName}");
                }
            }
        }
    }
}