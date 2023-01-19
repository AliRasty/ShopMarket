

using System;
using System.Linq;
using System.Threading.Tasks;
using ShopMarket.DataLayer.Entities.Common;

namespace ShopMarket.DataLayer.Repository
{
    public interface IGenericRepository<TEntity> :IAsyncDisposable where TEntity : BaseEntity
    {

        IQueryable<TEntity> GetQuery();
        Task AddEntity(TEntity entity);
        Task<TEntity> GetById(long id);
        void EditEntity(TEntity entity);
        void DeleteEntity(TEntity entity);
        Task DeleteEntity(long id);
        void DeletePermanent(TEntity entity);
        Task DeletePermanent(long id);


        Task SaveChanges();
    }
}
