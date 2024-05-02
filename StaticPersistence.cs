using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulacion_Consola
{
    public static class StaticPersistence
    {
        private static List<Product> products = new List<Product>();

        public static void ProductGenerate(string name, double price)
        {
            Product newProduct = new Product(name, price);
            products.Add(newProduct);
        }
        public static Item CreateItem(Product product, int quantity) 
         {
            return new Item(product, quantity);
        }
    }
}
