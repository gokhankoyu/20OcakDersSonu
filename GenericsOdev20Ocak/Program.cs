using System;
using System.Collections.Generic;

namespace GenericsOdev20Ocak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("ankara");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Matematik";


            Mylist<Kurs> kurslar = new Mylist<Kurs>();
            kurslar Add(kurs1.KursAdi);

            Console.WriteLine(sehirler[0]);

        }


        class Mylist<T>
        {
            public void Add(T item) 
            {

            }
           
        }

        class Kurs
        {
            public int KursKodu { get; set; }

            public string KursAdi { get; set; }
        }
    
    
    
    }


}
