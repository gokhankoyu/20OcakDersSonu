using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2 numaralı kategorinin mobilya kategorisi olduğunu düşünelim.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500; //normalde bu veriler kullanıcan alınır. biz burada simüle ediyoruz.
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id =2, CategoryId =5, UnitsInStock =5, 
                ProductName = "Kalem", UnitPrice = 35 };// bu da bir yazma yöntemi

            ProductManager productManager = new ProductManager();//ProductManager türündeki productManager yeni bir referans numarası almış bir ProductManager'dır.
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            /*
            productManager.Topla2(3, 6);//burdan gelen veriyi program akışında kullanamam. void buna engel oluyor.

            int toplamaSonucu = productManager.Topla(6, 7); // return sayesinde Topla'dan gelen veriyi kullanabildim.
            Console.WriteLine(toplamaSonucu*2);

            //diziler,class,abstract class, interface..
            
             */
        }
    }
}
