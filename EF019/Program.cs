

using EF019;
using EF019.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

internal class Program
{
    private static async Task Main(string[] args)
    {

        using(var context = new AppDbContext())
        {
            var query = context.Clients.FirstOrDefault(x=> x.Id == 2);

            //query.Name = "Amira Abd El Aziez";
            //query.IsDeleted = false;
            //query.dateTime = null;
            //context.Clients.Update(query);
            //context.SaveChanges();
            Console.WriteLine(query.Name);
            Console.WriteLine("Success");
            
        }















        Console.ReadKey();
    }

    
}