using Microsoft.EntityFrameworkCore;
using PickAndStick.Models;

namespace PickAndStick.Models
{
    public class PickerContext : DbContext
    {


        public DbSet<Player> Players { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<LeaguePlayer> LeaguePlayers { get; set; }
        public DbSet<WeekPick> WeekPicks { get; set; }
        public DbSet<Pick> Picks { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<PlayerSeason> PlayerSeasons { get; set; }

        public DbSet<Choice> Choices { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LeaguePlayer>().HasKey(lp => new { lp.LeagueId, lp.PlayerId });
            modelBuilder.Entity<LeaguePlayer>().HasOne<Player>(lp => lp.Player).WithMany(p => p.LeaguePlayers).HasForeignKey(p => p.PlayerId);

            modelBuilder.Entity<LeaguePlayer>().HasOne<League>(lp => lp.League).WithMany(l => l.LeaguePlayers).HasForeignKey(l => l.LeagueId);

            modelBuilder.Entity<PlayerSeason>().HasKey(ps => new { ps.PlayerId, ps.SeasonId });
            modelBuilder.Entity<PlayerSeason>().HasOne<Player>(ps => ps.Player).WithMany(p => p.PlayerSeasons);
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=desktop-495gej8;Initial Catalog=PickDB;Integrated Security=True"); 
        }
    }
}