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

        public int AddNewProduct(Product product)
        {
            if (product != null)
            {
                _dbContext.Products.Add(product);
                return _dbContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException(nameof(product));
            }
        }

        public int EditProduct(Product product)
        {
            var productFromDb = _dbContext.Products.SingleOrDefault(p => p.Id == product.Id);
            if (productFromDb != null)
            {
                productFromDb.Name = product.Name;
                productFromDb.Description = product.Description;
                productFromDb.Price = product.Price;
                productFromDb.ImageName = product.ImageName;
                return _dbContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public Product GetProductById(int id)
        {
            return _dbContext.Products.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }
    }
}
