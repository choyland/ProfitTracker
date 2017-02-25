using System.Collections.Generic;
using System.Threading.Tasks;
using ProfitTracker.Models.Entities;
using ProfitTracker.Models.ViewModels;

namespace ProfitTracker.BusinessLayer.Commands.Interfaces
{
    public interface IBetCommands
    {
        Task<IEnumerable<BetViewModel>> GetBetViewModels(int userId);

        Task AddBet(Bet bet);
    }
}
