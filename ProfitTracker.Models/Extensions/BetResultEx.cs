using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitTracker.Models.Entities;
using ProfitTracker.Models.ViewModels;

namespace ProfitTracker.Models.Extensions
{
    public static class BetResultEx
    {
        public static BetResultViewModel ToViewModel(this BetResult betResult)
        {
            var betResultViewModel = new BetResultViewModel
            {
                Id = betResult.Id,
                Outcome = betResult.Outcome,
                Winnings = betResult.Winnings
            };

            return betResultViewModel;
        }

        public static List<BetResultViewModel> ToViewModels(this IEnumerable<BetResult> betResults)
        {
            return betResults.Select(betResult => new BetResultViewModel
            {
                Id = betResult.Id,
                Outcome = betResult.Outcome,
                Winnings = betResult.Winnings
            }).ToList();
        }
    }
}
