using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using ProfitTracker.Models.Entities.Interfaces;

namespace ProfitTracker.Models.Entities
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
