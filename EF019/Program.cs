

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
            var client = context.Clients.FirstOrDefault(x=> x.Id == 2);

            Console.WriteLine($"Name: {client.Name}");

            Console.WriteLine("Success");
            
        }















        Console.ReadKey();
    }

    
}