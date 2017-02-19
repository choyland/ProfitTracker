using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace ProfitTracker.Models.Entities
{
    public class BackBet
    {
        [Key]
        public int Id { get; set; }
        public double Stake { get; set; }
        public double Odds { get; set; }
        public Bookmaker Bookmaker { get; set; }
        public int BookmakerId { get; set; }
    }
}
