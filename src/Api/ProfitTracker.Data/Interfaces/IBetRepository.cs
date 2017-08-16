using System.Linq;
using System.Threading.Tasks;
using ProfitTracker.Data.Repository;
using ProfitTracker.Model.Entities;

namespace ProfitTracker.Data.Interfaces
{
    public interface IBetRepository
    {
        Task<Bet> GetById(int id);
        Task<bool> Exists(int betId);
        Task<RepositoryActionResult<Bet>> Insert(Bet entity);
        Task<RepositoryActionResult<Bet>> Update(Bet entity);
        Task<RepositoryActionResult<Bet>> Delete(int betId);
        IQueryable<Bet> GetBetsByBookmaker(int bookmakerId);
        IQueryable<Bet> GetBetsForUser(int userId);
    }
}
