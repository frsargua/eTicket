using eTickets.Data.Base;
using eTickets.Data.ViewModels;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace eTickets.Data.Services
{
	public class MoviesService: EntityBaseRepository<Movie>,IMoviesService
    {
        private readonly AppDbContext _context;


        public MoviesService(AppDbContext context) : base(context) {
            _context = context;
        }

        public async Task AddNewMovieAsync(NewMovieVM data)
        {

            //create object
            var newMovie = new Movie()
            {
                Name = data.Name,
                Price = data.Price,
                ImageURL = data.ImageURL,
                Description = data.Description,
                EndDate = data.EndDate,
                StartDate = data.StartDate,
                CinemaId = data.CinemaId,
                ProducerId = data.ProducerId,
                MovieCategory = data.MovieCategory
        };

            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();


            foreach(var actor in data.ActorIds)
            {
                var actorMoviePair = new Actor_Movie()
                {
                    ActorId = actor,
                    MovieId = newMovie.Id
                };
                await _context.Actors_Movies.AddAsync(actorMoviePair);
            }
            await _context.SaveChangesAsync();

        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.Actors_Movies)
                .ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n=>n.Id ==id);
            return movieDetails;
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdowsValues()
        {
            var response = new NewMovieDropdownsVM();
            response.Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync();
            response.Cinemas = await _context.Cinemas.OrderBy(n => n.Name).ToListAsync();
            response.Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync();

            return response;
        }


    }
}

