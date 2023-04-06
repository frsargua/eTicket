using System;
using eTickets.Models;

namespace eTickets.Data.Services
{
	public interface ICinemasService
    {
		Task<IEnumerable<Cinema>> GetAll();
        Task<Cinema> GetByIdAsync(int id);
        void Add(Cinema cinema);
		Task DeleteAsync(int id);
        Task AddAsync(Cinema cinema);
        Task<Cinema> UpdateAsync(int id, Cinema cinema);
    }
}

