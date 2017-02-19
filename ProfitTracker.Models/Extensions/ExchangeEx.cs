using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitTracker.Models.Entities;
using ProfitTracker.Models.ViewModels;

namespace ProfitTracker.Models.Extensions
{
    public static class ExchangeEx
    {
        public static ExchangeViewModel ToExchangeViewModel(this Exchange exchange)
        {
            var exchangeViewModel = new ExchangeViewModel
            {
                Id = exchange.Id,
                Commission = exchange.Commission,
                Name = exchange.Name
            };

            return exchangeViewModel;
        }

        public static List<ExchangeViewModel> ToExchangeViewModels(this IEnumerable<Exchange> exchanges)
        {
            return exchanges.Select(exchange => new ExchangeViewModel
            {
                Id = exchange.Id,
                Commission = exchange.Commission,
                Name = exchange.Name
            }).ToList();
        }
    }
}
