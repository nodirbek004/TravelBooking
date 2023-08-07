using DaTaAccess.DbContexts;
using DaTaAccess.IRepasitories.Commons;
using Domain.Commons.AudiTable;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTaAccess.Repasitory.Commons
{
    internal class Repasitory<T> : IRepasitories<T> where T : AudiTable
    {
        private readonly AppDbContext appDbContext;
        private readonly DbSet<T> dbSet;

        public Repasitory()
        {
            appDbContext = new AppDbContext();
            dbSet = appDbContext.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            var temp = (await dbSet.AddAsync(entity)).Entity;
            return temp;
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public IQueryable<T> GetAll()
            => dbSet.AsQueryable();


        public async Task<T> GetByIdAsync(long id)
            => await dbSet.FindAsync(id);


        public T Update(T entity)
            => dbSet.Update(entity).Entity;

        public async Task<int> SaveAsync()
            => await appDbContext.SaveChangesAsync();
    }
}
