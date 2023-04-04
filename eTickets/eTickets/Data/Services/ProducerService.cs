using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ProducerService : IProducersService
    {
        private readonly AppDbContext _context;
        public ProducerService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Producer producer)
        {
            _context.Producers.Add(producer);
            _context.SaveChanges();
        }

        public Task AddAsync(Producer producer)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {

            var producer = await _context.Producers.FirstOrDefaultAsync(n => n.Id == id);
            _context.Producers.Remove(producer);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Producer>> GetAll()
        {
            var result = await _context.Producers.ToListAsync();
            return result;
        }

        public async Task<Producer> GetByIdAsync(int id)
        {
            var result = await _context.Producers.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Producer> UpdateAsync( int id, Producer newProducer)
        {
            _context.Update(newProducer);
            await _context.SaveChangesAsync();
            return newProducer;
        }
    }
}