using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_Enum
{
    internal class Store
    {
        Product[] Products;
        Types types;
        public Store()
        {
            Products = new Product[0];

        }
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;

            Console.WriteLine($"Mehsulun adi:{product.Name},mehsulun qiymeti:{product.Price}");
        }

        public void GetProduct(double id)
        {
            bool Find = false;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Id == id)
                {
                    Console.WriteLine(Products[i].Name);
                    Find = true;
                    break;
                }
            }
        }

        public void FilterProductByName(string name)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                    Console.WriteLine(Products[i].Name + ":adinda mehsul var");

                }
                else
                {
                    Console.WriteLine("O adda hecne yoxdu");
                }
            }
        }

        //en rahati Arrow functiondu yoxsa kod cox uzanir
        public Product[] RemoveId(double id)
        {

            List<Product> productAll = new List<Product>(Products);
            productAll.RemoveAll(x => x.Id == id);
            var All = productAll.ToArray();
            return All;
        }
    }
}
