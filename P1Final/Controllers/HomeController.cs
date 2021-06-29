﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using P1Final.Models;
using P1FinalDbContext;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace P1Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly P1TestDbContext _context = new P1TestDbContext();

        //constructor dependency injection for contexts: create a constructor of a class by putting in an instance of a context as a constructor parameter

        //


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult ErrLogin()
        {
            //if verificaiton method fails
            return View("ErrLogin");
        }

        //I think this creates a new "tab"
        public IActionResult StoreList()
        {
            List<Location> locs = _context.Locations.ToList<Location>();
            return View(locs);
        }

        private void FetchCustomer()
        {

        }

        public IActionResult About()
        {
            return View("About");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
