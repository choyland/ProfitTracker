using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitTracker.Models.Entities;
using ProfitTracker.Models.ViewModels;

namespace ProfitTracker.Models.Extensions
{
    public static class BookmakerEx
    {
        public static BookmakerViewModel ToViewModel(this Bookmaker bookmaker)
        {
            var bookmakerViewModel = new BookmakerViewModel
            {
                Id = bookmaker.Id,
                Name = bookmaker.Name
            };

            return bookmakerViewModel;
        }

        public static List<BookmakerViewModel> ToViewModels(this IEnumerable<BookmakerViewModel> bookmakers)
        {
            return bookmakers.Select(bookmaker => new BookmakerViewModel
            {
                Id = bookmaker.Id,
                Name = bookmaker.Name
            }).ToList();
        }
    }
}
