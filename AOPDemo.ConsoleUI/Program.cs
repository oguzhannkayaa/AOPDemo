using AOPDemo.Business.Abstract;
using AOPDemo.Business.Concrete;
using AOPDemo.DataAccess.Concrete.EntityFramework;

namespace AOPDemo.ConsoleUI;



class Program
{
    static void Main(string[] args)
    {
        ProductService productService = new ProductManager(new ProductDal());
    }
}


