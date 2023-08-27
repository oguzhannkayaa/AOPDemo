using AOPDemo.DataAccess.Abstract;
using AOPDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo.DataAccess.Concrete.EntityFramework
{
    public class ProductDal : IProductDal
    {

        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product {Name="Laptop",Id=1},
                new Product {Name="Laptop",Id=1},
                new Product {Name="Laptop",Id=1},
                new Product {Name="Laptop",Id=1},

            };
        }


    }
}
