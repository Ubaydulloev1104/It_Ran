using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Product
    {
        public Product()
        {

        }

        public Product(string name, int count)
        {
            Count = count;
            Name = name;
        }
        public string Name { get; set; }
        public int Count { get; set; }

        public void SaveToFile()
        {
            using (StreamWriter fstream = new StreamWriter("Product.txt", true))
            {
                fstream.WriteLine($"{Name} {Count}");
            }

        }
        public static Product[] GetProduts()
        {
            string[] strings = File.ReadAllLines("Product.txt", Encoding.UTF8);
            Product[] products = new Product[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                string s=strings[i];
                var a=s.Split(' ');
                string prodocname=a[0];
                string count = a[1];
               int ab =int.Parse(count);
                products[i] = new Product(prodocname, ab);
            }
            return products;
        }
        public static bool ProductExists(string name, string path)
        {
            string[] products = File.ReadAllLines(path, Encoding.UTF8);
            for (int i = 0; i < products.Length; i++)
            {
                string product = products[i];
                var splitted = product.Split(' ');
                string productName = splitted[0];
                if (productName == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
