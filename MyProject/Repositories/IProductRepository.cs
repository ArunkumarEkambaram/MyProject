using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Models;

namespace MyProject.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int id);

        int AddNewProduct(Product product);

        int EditProduct(Product product);
    }
}
