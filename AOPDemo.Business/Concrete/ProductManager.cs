using AOPDemo.Business.Abstract;
using AOPDemo.DataAccess.Abstract;
using AOPDemo.DataAccess.Concrete.EntityFramework;
using AOPDemo.Entities.Concrete;
using Core.Aspects.Loging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo.Business.Concrete
{
    public class ProductManager : ProductService
    {
        private IProductDal efProductDal;


        public ProductManager(IProductDal _efProductDal)
        {
            efProductDal = _efProductDal;
        }


        [LogAspect]
        public List<Product> GetAll()
        {


            return efProductDal.GetAll();
        }


    }
}
