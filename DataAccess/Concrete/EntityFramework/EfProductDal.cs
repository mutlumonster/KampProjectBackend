using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product> 
            {
                new Product{Id = 1, ProductName = "Masa from EF"},
                new Product{Id = 2, ProductName = "Sandalye from EF"},
                new Product{Id = 3, ProductName = "Monitor from EF"},
                new Product{Id = 4, ProductName = "Kasa from EF"},
                new Product{Id = 5, ProductName = "Hoparlor from EF"},

            };
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
