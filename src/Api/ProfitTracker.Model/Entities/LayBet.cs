using ProfitTracker.Models.Entities.Interfaces;

namespace ProfitTracker.Model.Entities
{
    public class LayBet : IEntity
    { 
        public double LayStake { get; set; }
        public double LayOdds { get; set; }
        public Exchange Exchange { get; set; }
        public int ExchangeId { get; set; }
        public int Id { get; set; }
    }
}
