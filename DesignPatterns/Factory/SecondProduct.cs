using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class SecondProduct : Product
    {
        static SecondProduct()
        {
            ProductFactory.instance().registerProduct("2", new SecondProduct());
        }

        public override Product createProduct()
        {
            return new SecondProduct();
        }
    }
}
