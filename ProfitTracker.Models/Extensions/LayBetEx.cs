using System.Collections.Generic;
using System.Linq;
using ProfitTracker.Models.Entities;
using ProfitTracker.Models.ViewModels;

namespace ProfitTracker.Models.Extensions
{
    public static class LayBetEx
    {
        public static LayBetViewModel ToViewModel(this LayBet layBet)
        {
            var layBetViewModel = new LayBetViewModel
            {
                ExchangeId = layBet.ExchangeId,
                Id = layBet.Id,
                LayOdds = layBet.LayOdds,
                LayStake = layBet.LayStake
            };

            return layBetViewModel;
        }

        public static List<LayBetViewModel> ToLayBetViewModels(this IEnumerable<LayBet> layBets)
        {
            return layBets.Select(layBet => new LayBetViewModel
            {
                ExchangeId = layBet.ExchangeId,
                Id = layBet.Id,
                LayOdds = layBet.LayOdds,
                LayStake = layBet.LayStake
            }).ToList();
        }
    }
}
