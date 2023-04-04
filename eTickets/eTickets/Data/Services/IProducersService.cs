using System;
using eTickets.Models;

namespace eTickets.Data.Services
{
	public interface IProducersService
	{
		Task<IEnumerable<Producer>> GetAll();
        Task<Producer> GetByIdAsync(int id);
        void Add(Producer producer);
		Task DeleteAsync(int id);
        Task AddAsync(Producer producer);
        Task<Producer> UpdateAsync(int id, Producer newProducer);
    }
}

