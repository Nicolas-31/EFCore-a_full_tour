using EntityFrameworkCore.Data;
using EntityFrameworkCore.Domain;
using System; 

namespace EntityFrameworkCore.ConsoleApp
{
    class Program
    {
        private static readonly FootballLeagueDbContext context = new FootballLeagueDbContext();
        static void Main(string[] args)
        {
            context.Leagues.Add(new League { Name = "English Premiere League" });
            context.SaveChangesAsync();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}