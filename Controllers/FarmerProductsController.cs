using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ST10084788_PROG7311_POE.Data;
using ST10084788_PROG7311_POE.Data.Migrations;
using ST10084788_PROG7311_POE.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST10084788_PROG7311_POE.Controllers
{
    public class FarmerProductsController : Controller
    {

        private readonly ApplicationDbContext  _context;

        public FarmerProductsController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(string id, string filter)
        {
            // view a list of products by specific farmer

            var farmerUsername = id;

            // Retrieve the user based on the provided farmerUsername
            var user = await _context.Users.SingleOrDefaultAsync(u => u.UserName == farmerUsername);

            if (user != null)
            {
                // user is found
                var userId = user.Id;

                // Retrieve the products that have FarmerID equal to UserID
                var products = _context.Product.Where(p => p.FarmerID == userId);

                // Apply filtering based on the selected option
                switch (filter)
                {
                    case "newest":
                        products = products.OrderByDescending(p => p.DateAdded);
                        break;
                    case "oldest":
                        products = products.OrderBy(p => p.DateAdded);
                        break;
                    
                    default:
                        // No filter selected
                        break;
                }

               // returns list with products from specific farmer - based on FarmerID
                return View(await products.ToListAsync());
            }

            // If the user is not found
            return View(new List<Product>());
        }
    }
}
