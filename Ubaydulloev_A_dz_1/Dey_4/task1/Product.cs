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
        string path = "Product.txt";
        public Product()
        {

        }

        public Product(string name,int count)
        {
            Count = count;
            Name = name;
        }
        public string Name { get; set; }
        public int Count { get; set; }

        public void SaveToFile(string d)
        {
            using (StreamWriter fstream = new StreamWriter(path,true))
            {
                fstream.WriteLine(d);
            }
        
        }
        public string[] GetProduts()
        {
            string[] products = File.ReadAllLines("Product.txt", Encoding.UTF8);
            foreach (var item in products)
            {
                Console.WriteLine($" {item} ");
            }
            return products;
        }
        public bool ProductExists(string name, int count)
        {
           bool exists = false;
            string[] products = File.ReadAllLines("Product.txt", Encoding.UTF8);
            for (int i = 0; i < products.Length; i++)
            {
                string product = products[i];
                var splitted = product.Split(' ');
                string productName = splitted[0];
                int countOfProduct = int.Parse(splitted[1]);
                if (productName == name)
                {
                    exists=true;
                }
            }
            return exists;
        }        
    }
}
