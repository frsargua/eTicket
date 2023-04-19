using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data.Cart;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMoviesService _moviesService;

        private readonly ShoppingCart _shoppingCart;

        public HomeController(IMoviesService moviesService, ShoppingCart shoppingCart)
        {
            _moviesService = moviesService;
            _shoppingCart = shoppingCart;
        }

        // GET: /<controller>/
        public IActionResult Index() 
        {
            return View();
        }
    }
}

