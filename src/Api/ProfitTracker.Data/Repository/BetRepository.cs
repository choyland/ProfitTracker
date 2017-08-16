using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using ProfitTracker.Data.Interfaces;
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

        public async Task<Bet> GetById(int id)
        {
            var bet = await _context.Bets.FindAsync(id);

            return bet;
        }

        public async Task<bool> Exists(int betId)
        {
            var bet = await _context.Bets.FindAsync(betId);

            return bet != null;
        }

        public async Task<RepositoryActionResult<Bet>> Insert(Bet entity)
        {
            try
            {
                _context.Bets.Add(entity);
                var result = await _context.SaveChangesAsync();
                if (result > 0)
                {
                    return new RepositoryActionResult<Bet>(entity, RepositoryActionStatus.Created);
                }
                else
                {
                    return new RepositoryActionResult<Bet>(entity, RepositoryActionStatus.NothingModified, null);
                }
            }
            catch (Exception ex)
            {
                return new RepositoryActionResult<Bet>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public async Task<RepositoryActionResult<Bet>> Update(Bet entity)
        {
            try
            {
                var existingBet = await _context.Bets.FirstOrDefaultAsync(b => b.Id == entity.Id);

                if (existingBet == null)
                {
                    return new RepositoryActionResult<Bet>(entity, RepositoryActionStatus.NotFound);
                }

                // change the original entity status to detached; otherwise, we get an error on attach
                // as the entity is already in the dbSet

                // set original entity state to detached
                _context.Entry(existingBet).State = EntityState.Detached;

                // attach & save
                _context.Bets.Attach(entity);

                // set the updated entity state to modified, so it gets updated.
                _context.Entry(entity).State = EntityState.Modified;
                
                var result = await _context.SaveChangesAsync();

                if (result > 0)
                {
                    return new RepositoryActionResult<Bet>(entity, RepositoryActionStatus.Updated);
                }
                else
                {
                    return new RepositoryActionResult<Bet>(entity, RepositoryActionStatus.NothingModified, null);
                }

            }
            catch (Exception ex)
            {
                return new RepositoryActionResult<Bet>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public async Task<RepositoryActionResult<Bet>> Delete(int betId)
        {
            try
            {
                var bet = await _context.Bets.FindAsync(betId);

                if (bet != null)
                {
                    _context.Bets.Remove(bet);
                    await _context.SaveChangesAsync();

                    return new RepositoryActionResult<Bet>(null, RepositoryActionStatus.Deleted);
                }

                return new RepositoryActionResult<Bet>(null, RepositoryActionStatus.NotFound);
            }
            catch (Exception ex)
            {
                return new RepositoryActionResult<Bet>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public IQueryable<Bet> GetBetsByBookmaker(int bookmakerId)
        {
            var bets = _context.Bets.Where(b => b.BookmakerId == bookmakerId);
            return bets;
        }
        
        public IQueryable<Bet> GetBetsForUser(int userId)
        {
            var bets = _context.Bets.Where(b => b.ApplicationUserId == userId);
        }
    }
}
