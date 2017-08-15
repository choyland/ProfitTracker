using System.Data.Entity;
using ProfitTracker.Model.Entities;

namespace ProfitTracker.Model
{
    public class ProfitTrackerDbContext : DbContext
    {
        public ProfitTrackerDbContext() : base("name=ProfitTrackerContext")
        {
            
        }

        public DbSet<Bet> Bets { get; set; }
        public DbSet<Bookmaker> Bookmakers { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Sport> Sports { get; set; }
    }
}
