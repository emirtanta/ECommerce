using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;


        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);

            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            var entity=await _context.Set<T>().FirstOrDefaultAsync(n=>n.Id==id);

            EntityEntry entityEntry = _context.Entry<T>(entity);

            entityEntry.State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();

        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] inclueProperties)
        {
            IQueryable<T> query = _context.Set<T>();

            query = inclueProperties.Aggregate(query, (current, inclueProperties) => current.Include(inclueProperties));

            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
             return await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        }


        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);

            entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
