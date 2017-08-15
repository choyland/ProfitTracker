using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitTracker.Data.Interfaces;
using ProfitTracker.Data.Repository;
using ProfitTracker.Model.Entities;
using ProfitTracker.Models.Entities.Interfaces;
using ProfitTracker.Model;

namespace ProfitTracker.Data.Repository
{
    public class BetRepository : IBetRepository
    {
        private ProfitTrackerDbContext _context;

        public BetRepository(ProfitTrackerDbContext context)
        {
            _context = context;
        }

        public async Task<IEntity> GetById(int id)
        {
            var bet = _context.Bets.Where(b => b.Id == id);
        }

        public async Task<bool> Exists(IEntity entity)
        {
            var bet = await _context.Bets.FindAsync(entity);

            return bet != null;
        }

        public RepositoryActionResult<IEntity> Insert(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public RepositoryActionResult<IEntity> Update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public RepositoryActionResult<IEntity> Delete(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Bet> GetBetsByBookmaker(int bookmakerId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Bet> GetBetsForUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
