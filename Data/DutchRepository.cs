using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DutchTreat.Data.Entities;

namespace DutchTreat.Data
{
    public class DutchRepository
    {
        public readonly DutchContext _ctx;

        public DutchRepository(DutchContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _ctx.Products
                .OrderBy(p => p.Title)
                .ToList();
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _ctx.Products
                .Where(p => p.Category == category)
                .ToList();
        }
    }
}