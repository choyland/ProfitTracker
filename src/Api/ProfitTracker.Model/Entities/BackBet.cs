using ProfitTracker.Models.Entities;
using ProfitTracker.Models.Entities.Interfaces;

namespace ProfitTracker.Model.Entities
{
    public class BackBet : IEntity
    {
        public double Stake { get; set; }
        public double Odds { get; set; }
        public Bookmaker Bookmaker { get; set; }
        public int BookmakerId { get; set; }
        public int Id { get; set; }
    }
}
