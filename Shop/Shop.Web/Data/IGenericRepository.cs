using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data
{
   public interface IGenericRepository<T>where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetByIdSync(int id);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> ExistAsyc(int id);
    }
}
