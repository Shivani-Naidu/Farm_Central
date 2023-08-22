using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ST10084788_PROG7311_POE.Data;
using ST10084788_PROG7311_POE.Data.Migrations;
using ST10084788_PROG7311_POE.Models;

namespace ST10084788_PROG7311_POE.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IProductInterface _productInterface; // uses interface

        public ProductsController(ApplicationDbContext context, UserManager<IdentityUser> userManager, IProductInterface productInterface)
        {
            _context = context;
            _userManager = userManager;
            _productInterface = productInterface;
        }

      
        public async Task<IActionResult> Index(string id, string filter)
        {

              
            //var products = await _context.Product.ToListAsync();

            // use interface to get all products
            var products = _productInterface.GetAllProducts();

            // Create a dictionary to store the usernames for each farmer
            var farmerUsernames = new Dictionary<string, string>();

            foreach (var product in products)
            {
                // get the FarmerID for each product
                var farmerId = product.FarmerID;

                // Check if the username for the farmer ID is already retrieved
                if (!farmerUsernames.ContainsKey(farmerId))
                {
                    var farmer = await _userManager.FindByIdAsync(farmerId);
                    var farmerUsername = farmer?.UserName;
                    farmerUsernames[farmerId] = farmerUsername; // Store the username in the dictionary
                }
            }

            // Pass the dictionary of usernames to the view
            ViewBag.FarmerUsernames = farmerUsernames;


            if (User.IsInRole("Farmer"))
            {
                // if a Farmer accesses this page, they will only be able to view their products
                
                // get Id of current logged in user (farmer)
                var user = await _userManager.GetUserAsync(User);
                var farmerId = user.Id;

                // get the farmer's username 
                var farmerUserName = await _userManager.FindByIdAsync(farmerId);
                var userName = farmerUserName.UserName;
                var productsFarmer = await _context.Product.Where(p => p.FarmerID == farmerId).ToListAsync();

                ViewBag.UserName = userName;
                return View(productsFarmer);
            }

            if (User.IsInRole("Employee"))
            {
                // if the Employee is logged in, it should display all products and also view the farmer's username
                
                var productsEmployee = _productInterface.GetAllProducts();
                    //await _context.Product.ToListAsync();

                foreach (var product in productsEmployee)
                {
                    var farmerId = product.FarmerID;
                    var farmer = await _userManager.FindByIdAsync(farmerId);
                    var farmerUsername = farmer.UserName;

                    ViewBag.UserName = farmerUsername;
                }

                return View(productsEmployee);
            }

            return View(products);

        }

        public async Task<IActionResult> FilterByDateRange(DateTime startDate, DateTime endDate)
        {
            var products = await _context.Product
                .Where(p => p.DateAdded >= startDate && p.DateAdded <= endDate)
                .ToListAsync();

            return View("Index", products);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,ProductName,ProductDesc,ProductCategory,Quantity,Price,DateAdded,FarmerID,ProductImage")] Product product)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(User);
                product.FarmerID = currentUser.Id;
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,ProductName,ProductDesc,ProductCategory,Quantity,Price,DateAdded,FarmerID,ProductImage")] Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductID == id);
        }
    }
}
