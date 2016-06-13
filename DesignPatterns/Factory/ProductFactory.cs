using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class ProductFactory
    {
        private Dictionary<String, Product> m_RegisteredProducts ;

        private ProductFactory() 
        {
            m_RegisteredProducts = new Dictionary<string, Product>();
        }

        public static ProductFactory instance()
        {
            return new ProductFactory();
        }

        public void registerProduct(String productId, Product p) 
        {
            m_RegisteredProducts.Add(productId, p);
        }

        public Product createProduct(String productID) 
        {
            return ((Product)m_RegisteredProducts[productID]).createProduct();
        }
    }
}
