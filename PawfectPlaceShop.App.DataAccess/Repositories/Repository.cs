using Microsoft.EntityFrameworkCore;
using PawfectPlaceShop.App.DataAccess.Contexts;
using PawfectPlaceShop.App.Entity.Entities;
using PawfectPlaceShop.App.Entity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly PetShopDbContext _context;
        private DbSet<T> _dbSet;
        public Repository(PetShopDbContext context)
        {
            _context = context;     //arakatman - veritabanı
            _dbSet = _context.Set<T>(); //dbset - tablo
        }
        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            //_context.SaveChanges();		//UnitOfWork tarafından yapılacak.
            //_context.SaveChangesAsync();
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            //_context.SaveChanges();
        }
        public void Delete(int? id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            //_context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity.GetType().GetProperty("IsDeleted") != null)
            {
                entity.GetType().GetProperty("IsDeleted").SetValue(entity, true);
                _dbSet.Update(entity);
            }
            else
            {
                _dbSet.Remove(entity);
            }
            //_context.SaveChanges();
        }

        public async Task<T> Get(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = _dbSet.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();  //AsNoTracking() -> EF Core verileri takip etmiyor (modified, deleted, detached gibi).
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll(
    Expression<Func<T, bool>> filter = null,
    Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
    params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (orderby != null)
                query = orderby(query);

            foreach (var table in includes)
            {
                query = query.Include(table);
            }

            return await query.ToListAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

      
    }
}
