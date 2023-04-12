using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace eTickets.Data.Services
{
	public class MoviesService: EntityBaseRepository<Movie>,IMoviesService
    {
        public MoviesService(AppDbContext context) : base(context) { }

    }
}

