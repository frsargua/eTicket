 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {

        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var data = await _context.Actors.ToListAsync();
            return View(data);
        }
    }
}

