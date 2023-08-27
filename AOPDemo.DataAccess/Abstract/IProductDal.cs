using AOPDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo.DataAccess.Abstract
{
    public interface IProductDal
    {
        public List<Product> GetAll();
    }
}
