using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1, ProductName = "Masa"},
                new Product{ProductId = 2, ProductName = "Sandalye"},
                new Product{ProductId = 3, ProductName = "Monitor"},
                new Product{ProductId = 4, ProductName = "Kasa"},
                new Product{ProductId = 5, ProductName = "Hoparlor"},

            };
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

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            Product productToUpdate;

            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductId = product.ProductId;
            productToUpdate.ProductName = product.ProductName;

        }

        public void Delete(Product product)
        {
            //LINQ - language integrated query
            //Lambda

            Product productToDelete;

            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }


    }
}
