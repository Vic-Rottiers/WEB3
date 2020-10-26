using _07SportsStore.Data;
using System;

namespace _07SportsStore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                Console.WriteLine("Database created");
            }
        }
    }
}
