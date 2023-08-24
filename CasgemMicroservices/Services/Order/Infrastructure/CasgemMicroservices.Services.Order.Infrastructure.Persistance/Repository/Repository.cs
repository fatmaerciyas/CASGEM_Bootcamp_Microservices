using CasgemMicroservices.Services.Order.Core.Application.Interfaceses;
using CasgemMicroservices.Services.Order.Infrastructure.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Infrastructure.Persistance.Repository
{
    public class Repository<T>:IRepository<T> where T:class
    {
        private readonly OrderContext _context;

        public Repository(OrderContext context)
        {
            _context = context;
        }

        public async Task<T> CreateAsync(T t)
        {
            _context.Set<T>().Add(t);
            await _context.SaveChangesAsync();
            return t;
        }

        public async Task<T> DeleteAsync(T t)
        {
            _context.Set<T>().Remove(t);
            await _context.SaveChangesAsync();
            return t;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetOrderById(Expression<Func<T, bool>> filter = null)
        {
            return await _context.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<T> UpdateAsync(T t)
        {
            _context.Set<T>().Update(t);
            await _context.SaveChangesAsync();
            return t;
        }
    }
}
