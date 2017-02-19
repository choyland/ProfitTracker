using System.Collections.Generic;
using System.Linq;
using ProfitTracker.Models.Entities;
using ProfitTracker.Models.ViewModels;

namespace ProfitTracker.Models.Extensions
{
    public static class BackBetEx
    {
        public static BackBetViewModel ToViewModel(this BackBet backBet)
        {
            var backBetViewModel = new BackBetViewModel
            {
                Id = backBet.Id,
                BookmakerId = backBet.BookmakerId,
                Odds = backBet.Odds,
                Stake = backBet.Stake
            };

            return backBetViewModel;
        }

        public static List<BackBetViewModel> ToViewModels(this IEnumerable<BackBet> backBets)
        {
            return backBets.Select(backBet => new BackBetViewModel
            {
                Id = backBet.Id, BookmakerId = backBet.BookmakerId, Odds = backBet.Odds, Stake = backBet.Stake
            }).ToList();
        }
    }
}
