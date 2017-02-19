using System.Collections.Generic;
using System.Linq;
using ProfitTracker.Models.Entities;
using ProfitTracker.Models.ViewModels;

namespace ProfitTracker.Models.Extensions
{
    public static class BetEx
    {
        public static BetViewModel ToViewModel(this Bet bet)
        {
            var betViewModel = new BetViewModel
            {
                BackBet = bet.BackBet.ToViewModel(),
                LayBet = bet.LayBet.ToViewModel(),
                BetResult = bet.BetResult.ToViewModel(),
                BetType = bet.BetType,
                EventDate = bet.EventDate,
                DateAdded = bet.DateAdded,
                Description = bet.Description,
                Sport = bet.Sport,
                Id = bet.Id
            };

            return betViewModel;
        }

        public static List<BetViewModel> ToViewModels(this IEnumerable<Bet> bets)
        {
            return bets.Select(bet => new BetViewModel
            {
                BackBet = bet.BackBet.ToViewModel(),
                LayBet = bet.LayBet.ToViewModel(),
                BetResult = bet.BetResult.ToViewModel(),
                BetType = bet.BetType,
                EventDate = bet.EventDate,
                DateAdded = bet.DateAdded,
                Description = bet.Description,
                Sport = bet.Sport,
                Id = bet.Id
            }).ToList();
        } 
    }
}
