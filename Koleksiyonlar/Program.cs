using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //// dizileri genişletmeyiz. genişletirsek de değer kaybı yaşıyoruz.
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // isimler arrayi 5 elemanlı bir arraye dönüştü.
            //isimler[4] = "ilker"; //5.elemanı tanımladık ama ilk 4 elemanı tanımlamadık.
            //Console.WriteLine(isimler[4]);//ekrana bunu ilker olarak yazdıracak
            //Console.WriteLine(isimler[0]); // sıfırıncı eleman tanımlanmadığı için bir şey yazmayacak.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            foreach (string isim in isimler2)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
