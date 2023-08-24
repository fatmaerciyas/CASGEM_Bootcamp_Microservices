using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Core.Application.Interfaceses
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T t);
        Task<T> UpdateAsync(T t);
        Task<T> DeleteAsync(T t);
        Task<List<T>> GetOrderById(Expression<Func<T,bool>>filter=null);
        //İsteğe göre listeleme
       
        
    }
}
