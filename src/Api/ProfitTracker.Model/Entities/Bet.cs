using System;
using ProfitTracker.Models.enums;
using ProfitTracker.Models.Entities;
using ProfitTracker.Models.Entities.Interfaces;

namespace ProfitTracker.Model.Entities
{
    public class Bet : IEntity
    {
        public int Id { get; set; }
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int BookmakerId { get; set; }
        public Bookmaker Bookmaker { get; set; }
        public BetType BetType { get; set; }
        public string Description { get; set; }
        public int SportId { get; set; }
        public Sport Sport { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal ProfitLoss { get; set; }
        public string Details { get; set; }
    }
}