using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Signatures;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IBaseEntity, new()
    {
        private readonly ServiceContext _context;
        private readonly DbSet<TEntity> _entities;

        public Repository(ServiceContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }
        
        public IQueryable<TEntity> Table => _entities;

        public IQueryable<TEntity> AsNoTracking => _entities.AsNoTracking();

        public async Task<TEntity> Get(int id)
        {
            var entity = await _entities.FindAsync(id);
            if (entity != null)
                _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }
        //public async Task<List<TEntity>> GetAll()
        //{
        //    var entity = await _entities.ToListAsync();
        //    return entity;
        //}
        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            var entity = await _entities.FirstOrDefaultAsync(filter);
            if (entity != null)
                _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }
        public async Task Insert(TEntity entity)
        {
            
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;

            await _entities.AddAsync(entity);
            await SaveChangesAsync();
        }
        public async Task Update(TEntity entity)
        {           

            var oldEntity = await Get(entity.Id);
            
            entity.CreatedAt = oldEntity.CreatedAt;
            entity.UpdatedAt = DateTime.Now;

            _context.Update(entity);
            await SaveChangesAsync();
        }
        public async Task Delete(TEntity entity)
        {
            
            _entities.Remove(entity);
            await SaveChangesAsync();
        }
       
        private async Task SaveChangesAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                _context.ChangeTracker.Entries().ToList().ForEach(x => { x.State = EntityState.Detached; });
            }
            catch (DbUpdateException e)
            {
                
            }
            catch (Exception e)
            {
                
            }
        }
        //private string GetFullError(Exception e) 
        //{
        //    _context.ChangeTracker.Entries().ToList().ForEach(x => { x.State = EntityState.Detached; }); 
        //    return e.ToString();
        //}

    }
}