using ProfitTracker.Data.Repository;
using ProfitTracker.Models.Entities.Interfaces;

namespace ProfitTracker.Data.Interfaces
{
    public interface IBaseRepository
    {
        IEntity GetById(int Id);
        bool Exists(IEntity entity);
        RepositoryActionResult<IEntity> Insert(IEntity entity);
        RepositoryActionResult<IEntity> Update(IEntity entity);
        RepositoryActionResult<IEntity> Delete(IEntity entity);
    }
}