using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using ProfitTracker.BusinessLayer.enums;

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

    public class Bet
    {
        [Key]
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
        public BetType BetType { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public Sport Sport { get; set; }
        public DateTime EventTime { get; set; }
        public BetResult BetResult { get; set; }
        public int BetResultId { get; set; }
        public BackBet BackBet { get; set; }
        public int BackBetId { get; set; }
        public LayBet LayBet { get; set; }
        public int? LayBetId { get; set; }
    }
}
