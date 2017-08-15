using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitTracker.Model.Entities;
using ProfitTracker.Models.Entities;

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
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<BackBet> BackBets { get; set; }
        public DbSet<LayBet> LayBets { get; set; }
    }
}
