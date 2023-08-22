using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ST10084788_PROG7311_POE.Data;
using ST10084788_PROG7311_POE.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ST10084788_PROG7311_POE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private readonly ApplicationDbContext _context;

        private readonly IProductInterface _productInterface; // using interface

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IProductInterface productInterface)
        {
            _logger = logger;
            _context = context;
            _productInterface = productInterface;
        }

        public IActionResult Index()
        {
            //var products = _context.Product.ToList();

            // use interface to get all products
            var products = _productInterface.GetAllProducts();
            return View(products);
        }

        public IActionResult Privacy()
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
