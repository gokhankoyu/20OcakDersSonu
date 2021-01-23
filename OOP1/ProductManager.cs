using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) 
        {
            Console.WriteLine(product.Id + " " + product.ProductName + " eklendi!");

        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        /*
        public int Topla(int a, int b)
        {
            return a + b;
        }

        public void Topla2(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        */
    }
}
