using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAll(n=>n.Cinema);
            return View(allProducers);
        }


        // GET: /<controller>/
        public async Task<IActionResult> Details(int id)
        {
            var data = await _service.GetMovieByIdAsync(id);
            return View(data);
        }

        // GET: /<controller>/
        public async Task<IActionResult> Create()
        {
            var movieDropdowsData = await _service.GetNewMovieDropdowsValues();

            ViewBag.Cinemas = new SelectList(movieDropdowsData.Cinemas, "Id","Name");
            ViewBag.Producers = new SelectList(movieDropdowsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdowsData.Actors, "Id", "FullName");

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM movie)
        {
            if (!ModelState.IsValid)
            {
                var movieDropdowsData = await _service.GetNewMovieDropdowsValues();

                ViewBag.Cinemas = new SelectList(movieDropdowsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropdowsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdowsData.Actors, "Id", "FullName");

                return View();
            }
            await _service.AddNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }
    }
}

  