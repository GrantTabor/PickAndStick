using Microsoft.EntityFrameworkCore;
using PickAndStick.Models;

namespace DatabaseContext
{
    public class PickerContext : DbContext
    {
    
        public PickerContext() : base("PickerContext")
        {
        }
        
        public DbSet<Player> Players { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<WeekPick> WeekPicks { get; set; }
        public DbSet<Pick> Picks { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Choice> Choices { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}