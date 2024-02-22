﻿using Hotel.ATR.Portal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nest;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.ATR.Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository _repo;
        private readonly IHttpContextAccessor _context;

        public HomeController(ILogger<HomeController> logger, IRepository repo, IHttpContextAccessor context)
        {
            _logger = logger;
            _repo = repo;
            _context = context;
        }


        public IActionResult AboutUs()
        {
            string key = "IIN";
            string value = "88005553535";

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);

            Response.Cookies.Append(key,value);
            Response.Cookies.Append(key,value);
            Response.Cookies.Append(key,value);

            return View();
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("product", "Auto");

            string value = HttpContext.Session.GetString("product");

            //var data = Request.Cookies["IIN"];

            //var data2 = _context.HttpContext.Request.Cookies["IIN"];


            _logger.LogInformation("TestInfo");
            _logger.LogError("TestInfo");

            string email = "d@d.ru";
            _logger.LogWarning("Error " + email);
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
