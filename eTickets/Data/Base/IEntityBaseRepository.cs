using System;
using eTickets.Models;

namespace eTickets.Data.Base
{
	public interface IEntityBaseRepository<T> where T:class, IEntityBase,new()
	{
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByIdAsync(int id);
        void Add(T entity);
        Task DeleteAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T newEntity);
    }
}

