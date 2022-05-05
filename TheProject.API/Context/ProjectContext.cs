
using Microsoft.EntityFrameworkCore;
using TheProject.API.Models;

namespace TheProject.API.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=Donau.hiof.no;Database=aleksanf;User=aleksanf;Password=tGUNK2qLSg");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<League>().HasData(new League { LeagueId = 1, LeagueName = "Premier League", Nationality = "England" });
            modelBuilder.Entity<League>().HasData(new League { LeagueId = 2, LeagueName = "La Liga", Nationality = "Spain" });
            modelBuilder.Entity<League>().HasData(new League { LeagueId = 3, LeagueName = "Ligue 1", Nationality = "France" });
            modelBuilder.Entity<League>().HasData(new League { LeagueId = 4, LeagueName = "Serie A", Nationality = "Italia" });
            modelBuilder.Entity<League>().HasData(new League { LeagueId = 5, LeagueName = "Bundesliga", Nationality = "Germany" });
        }

    }


}
