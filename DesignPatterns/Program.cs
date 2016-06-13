using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            OneProduct p1 = (OneProduct)ProductFactory.instance().createProduct("1");
            Console.WriteLine(p1.callMe());
        }
    }
}
