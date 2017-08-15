using System.Linq;
using ProfitTracker.Model.Entities;

namespace ProfitTracker.Data.Interfaces
{
    public interface IBetRepository : IBaseRepository
    {
        IQueryable<Bet> GetBetsByBookmaker(int bookmakerId);
        IQueryable<Bet> GetBetsForUser(int userId);
    }
}
