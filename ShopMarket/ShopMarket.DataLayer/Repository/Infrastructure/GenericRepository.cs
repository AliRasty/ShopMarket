using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopMarket.DataLayer.Context;
using ShopMarket.DataLayer.Entities.Common;

namespace ShopMarket.DataLayer.Repository.Infrastructure
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        private readonly DbSet<TEntity> _dbSet;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            this._dbSet = _context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetQuery()
        {
            return _dbSet.AsQueryable();
        }

        public async Task AddEntity(TEntity entity)
        {
            entity.CreationDate=DateTime.Now;
            await _context.AddAsync(entity);
        }

        public async Task<TEntity> GetById(long id)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.Id == id);
        }

        public void EditEntity(TEntity entity)
        {
            entity.LastUpdateDate = DateTime.Now;
            _dbSet.Update(entity);
        }

        public void DeleteEntity(TEntity entity)
        {
            entity.IsDelete = true;

            EditEntity(entity);
        }

        public async Task DeleteEntity(long id)
        {
            TEntity entity = await GetById(id);
            if (entity != null) DeleteEntity(entity);
        }

        public void DeletePermanent(TEntity entity)
        {
            _context.Remove(entity);
        }

        public async Task DeletePermanent(long id)
        {
            TEntity entity = await GetById(id);
            if(entity != null) DeletePermanent(entity);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }


        public async ValueTask DisposeAsync()
        {
            if (_context != null)
            {
               await  _context.DisposeAsync();
            }
        }
    }
}