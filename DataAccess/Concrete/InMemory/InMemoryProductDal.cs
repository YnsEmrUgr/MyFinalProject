using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product { CategoryId = 1, ProductId = 1, ProductName = "Bardak", UnitPrice = 125, UnitsInStock = 15 },
            new Product { CategoryId = 1, ProductId = 2, ProductName = "Kamera", UnitPrice = 2500, UnitsInStock = 3 },
            new Product { CategoryId = 2, ProductId = 3, ProductName = "Telefon", UnitPrice = 9800, UnitsInStock = 2 },
            new Product { CategoryId = 2, ProductId = 4, ProductName = "Klavye", UnitPrice = 500, UnitsInStock = 65 },
            new Product { CategoryId = 2, ProductId = 5, ProductName = "Fare", UnitPrice = 185, UnitsInStock = 1 }
        };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;

            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public void Update(Product product)
        {
            Product productToUpdate = null;

            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

            _products.Add(productToUpdate);
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
