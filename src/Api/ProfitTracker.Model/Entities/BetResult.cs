using ProfitTracker.Models.enums;
using ProfitTracker.Models.Entities.Interfaces;

namespace ProfitTracker.Model.Entities
{
    public class BetResult : IEntity
    {
        public double Winnings { get; set; }
        public BetOutcome Outcome { get; set; }
        public int Id { get; set; }
    }
}