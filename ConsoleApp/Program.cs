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
            GetAllSamurais();
            Console.ReadKey();
        }

        private static void GetAllSamurais()
        {
            //1:
            var samurais = samuraiContext.Samurais.ToList();
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }

            //2: retriving data during enumiration
            var samurais2 = samuraiContext.Samurais;
            foreach (var samurai in samurais2)
            {
                Console.WriteLine(samurai.Name);
            }
        }

        private static void InsertVariousTypes()
        {
            var samurai = new Samurai  { Name = "Imperial Samurai" };
            var clan = new Clan { Name = "Imperial Clan" };
            samuraiContext.AddRange(samurai, clan);
            samuraiContext.SaveChanges();
        }

        private static void InsertMultipleSamurais()
        {
            var samurai = new Samurai { Name = "Luci2" };
            var samurai2 = new Samurai { Name = "Cuci2" };
            samuraiContext.Samurais.AddRange(samurai, samurai2);
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
