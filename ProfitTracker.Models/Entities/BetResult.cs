using System.ComponentModel.DataAnnotations;
using ProfitTracker.BusinessLayer.enums;

namespace ProfitTracker.Models.Entities
{
    public class BetResult
    {
        [Key]
        public int Id { get; set; }
        public BackBet BackBet { get; set; }
        public int BackBetId { get; set; }
        public LayBet LayBet { get; set; }
        public int LayBetId { get; set; }
        public double Winnings { get; set; }
        public BetOutcome Outcome { get; set; }
    }
}