using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{Id = 1, ProductName = "Masa"},
                new Product{Id = 2, ProductName = "Sandalye"},
                new Product{Id = 3, ProductName = "Monitor"},
                new Product{Id = 4, ProductName = "Kasa"},
                new Product{Id = 5, ProductName = "Hoparlor"},

            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            Product productToUpdate;

            productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);

            productToUpdate.Id = product.Id;
            productToUpdate.ProductName = product.ProductName;

        }

        public void Delete(Product product)
        {
            //LINQ - language integrated query
            //Lambda

            Product productToDelete;

            productToDelete=_products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);
        }


    }
}
