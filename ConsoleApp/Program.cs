using SamuraiApp.Data.Models;
using SamuraiApp.Domain.DataModels;
using System;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {

        private static SamuraiContext _DbContext = new SamuraiContext();

        static void Main(string[] args)
        {
            _DbContext.Database.EnsureCreated();
            GetAllSamurais();
            Console.ReadKey();
        }

        private static void GetAllSamurais()
        {
            //1:
            var samurais = _DbContext.Samurais.ToList();
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }

            //2: retriving data during enumiration
            var samurais2 = _DbContext.Samurais;
            foreach (var samurai in samurais2)
            {
                Console.WriteLine(samurai.Name);
            }
        }

        private static void InsertVariousTypes()
        {
            var samurai = new Samurai  { Name = "Imperial Samurai" };
            var clan = new Clan { Name = "Imperial Clan" };
            _DbContext.AddRange(samurai, clan);
            _DbContext.SaveChanges();
        }

        private static void InsertMultipleSamurais()
        {
            var samurai = new Samurai { Name = "Luci2" };
            var samurai2 = new Samurai { Name = "Cuci2" };
            _DbContext.Samurais.AddRange(samurai, samurai2);
            _DbContext.SaveChanges();
        }

        private static void GetSamurais(string text)
        {
            var samurais = _DbContext.Samurais.ToList();
            Console.WriteLine($"{text}: Samurai count is {samurais.Count}");
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
