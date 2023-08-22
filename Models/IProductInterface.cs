using System.Collections.Generic;

namespace ST10084788_PROG7311_POE.Models
{
    public interface IProductInterface
    {
        // holds list that contains all products
        List<Product> GetAllProducts();
    }
}
