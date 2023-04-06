using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class CinemasService : ICinemasService
    {
        private readonly AppDbContext _context;
        public CinemasService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Cinema cinema)
        {
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
        }

        public Task AddAsync(Cinema cinema)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {

            var cinema = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == id);
            _context.Cinemas.Remove(cinema);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cinema>> GetAll()
        {
            var result = await _context.Cinemas.ToListAsync();
            return result;
        }

        public async Task<Cinema> GetByIdAsync(int id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Cinema> UpdateAsync( int id, Cinema newCinema)
        {
            _context.Update(newCinema);
            await _context.SaveChangesAsync();
            return newCinema;
        }
    }
}