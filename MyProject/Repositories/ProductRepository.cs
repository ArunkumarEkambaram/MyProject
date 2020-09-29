using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _dbContext = null;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddNewProduct(Product product)
        {
            if (product != null)
            {
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException(nameof(product));
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }
    }
}
