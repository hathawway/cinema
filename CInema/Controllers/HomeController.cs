﻿using Cinema.Domain.Db;
using Cinema.Domain.Models;
using Cinema.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CinemaDbContext _context;
        private readonly ISignIn _signInManager;
        public HomeController(
            ILogger<HomeController> logger,
            CinemaDbContext context,
            ISignIn signInManager)
        {
            _logger = logger;
            _context = context;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            var boxOffice = _context.BoxOffices.Select(x => x).ToArray();
            var countries = _context.Countries.Select(x => x).ToArray();

            var films = _context.Films.Select(x => x).ToArray();
            var semps = _context.FilmSemps.Select(x => x).ToArray();
            var filmStudios = _context.FilmStudios.Select(x => x).ToArray();

            var genres = _context.Genres.Select(x => x).ToArray();
            var ratings = _context.Ratings.Select(x => x).ToArray();
            var sessionFilms = _context.SessionFilms.Select(x => x).ToArray();

            var roleUsers = _context.Roles.Select(x => x).ToArray();
            var employees = _context.Employees.Select(x => x).ToArray();
            var users = _context.Users.Select(x => x).ToArray();

            return View();
        }
    }
}
