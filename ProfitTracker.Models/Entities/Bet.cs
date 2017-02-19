using System;
using System.ComponentModel.DataAnnotations;
using ProfitTracker.BusinessLayer.enums;
using ProfitTracker.Models.Entities.Interfaces;

namespace ProfitTracker.Models.Entities
{
    public class Bet : IEntity
    {
        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
        public BetType BetType { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public Sport Sport { get; set; }
        public DateTime EventDate { get; set; }
        public BetResult BetResult { get; set; }
        public int BetResultId { get; set; }
        public BackBet BackBet { get; set; }
        public int BackBetId { get; set; }
        public LayBet LayBet { get; set; }
        public int? LayBetId { get; set; }
        public int Id { get; set; }
    }
}