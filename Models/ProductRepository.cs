using System.Collections.Generic;
using System.IO;
using System;
using ST10084788_PROG7311_POE.Data;
using System.Linq;

namespace ST10084788_PROG7311_POE.Models
{
    public class ProductRepository : IProductInterface
    {
        // get DbContext
        private readonly ApplicationDbContext _appDbContext; 

        public ProductRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Product> GetAllProducts()
        {
            // return list of all products
            return _appDbContext.Product.ToList();
        }
    }

}

