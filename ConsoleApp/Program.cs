using SamuraiApp.Data.Models;
using SamuraiApp.Domain.DataModels;
using System;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {

        private static SamuraiContext samuraiContext = new SamuraiContext();

        static void Main(string[] args)
        {
            samuraiContext.Database.EnsureCreated();
            GetSamurais("Before Add");
            AddSamurai();
            GetSamurais("After Add");
            Console.ReadKey();
        }

        private static void AddSamurai()
        {
            var samurai = new Samurai { Name = "Luci" };
            samuraiContext.Samurais.Add(samurai);
            samuraiContext.SaveChanges();
        }

        private static void GetSamurais(string text)
        {
            var samurais = samuraiContext.Samurais.ToList();
            Console.WriteLine($"{text}: Samurai count is {samurais.Count}");
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
