using System;
using ProfitTracker.Models.enums;

namespace ProfitTracker.Models.ViewModels
{
    public class BetViewModel
    {
        public int Id { get; set; }
        public ApplicationUserViewModel ApplicationUser { get; set; }
        public BetType BetType { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public Sport Sport { get; set; }
        public DateTime EventDate { get; set; }
        public BetResultViewModel BetResult { get; set; }
        public BackBetViewModel BackBet { get; set; }
        public LayBetViewModel LayBet { get; set; }
    }
}
