using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public class Cache : ICache
    {
        void ICache.Cache()
        {
            Console.WriteLine("Cached");
        }
    }
}
