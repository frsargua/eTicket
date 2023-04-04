using System;
using eTickets.Models;

namespace eTickets.Data.Services
{
	public interface IActorsService
	{
		Task<IEnumerable<Actor>> GetAll();
        Task<Actor> GetByIdAsync(int id);
        void Add(Actor actor);
		Task DeleteAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
    }
}

