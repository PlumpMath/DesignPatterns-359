using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class OneProduct : Product
    {
        static OneProduct(){
            ProductFactory.instance().registerProduct("1", new OneProduct());
        }

        public override Product createProduct()
        {
            return new OneProduct();
        }

        public String callMe() {
            return "One Product !";
        }
    }
}
