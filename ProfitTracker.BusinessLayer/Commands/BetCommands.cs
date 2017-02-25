using System.Collections.Generic;
using System.Threading.Tasks;
using ProfitTracker.BusinessLayer.Commands.Interfaces;
using ProfitTracker.Data.Repository.Interfaces;
using ProfitTracker.Models.Entities;
using ProfitTracker.Models.Extensions;
using ProfitTracker.Models.ViewModels;

namespace ProfitTracker.BusinessLayer.Commands
{
    public class BetCommands : IBetCommands
    {
        private readonly IRepository _repository;

        public BetCommands(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<BetViewModel>> GetBetViewModels(int userId)
        {
            var bets = await _repository.GetAsync<Bet>(x => x.ApplicationUserId == userId);
            var viewModels = bets.ToViewModels();

            return viewModels;
        }

        public async Task AddBet(Bet bet)
        {
            _repository.Create(bet);
            await SaveChanges();
        }

        private async Task SaveChanges()
        {
            await _repository.SaveAsync();
        }
    }
}
