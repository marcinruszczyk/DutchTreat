using DutchArt.Data.Entities;
using System.Collections.Generic;

namespace DutchArt.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        IEnumerable<Order> GetAllOrders(bool includeItems);
        Order GetOrderById(int id);

        void AddEntity(object model);
        bool SaveAll();
        
    }
}