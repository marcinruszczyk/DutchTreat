using DutchArt.Data.Entities;
using System.Collections.Generic;

namespace DutchArt.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
    }
}