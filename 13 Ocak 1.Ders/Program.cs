using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Ocak_1.Ders
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // do not repeat yourself
            // katet - değer tutucu, alias


            string katet = "Kategori";
            int ogrenciSayisi = 32000000;
            double faizOrani = 1.45;
            bool sistemegirisyapmismi = false; //true da diyebiliriz. o kullanma amacımıza göre değişir.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            //ŞART BLOKLARINA GELDİM

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarBugun > dolarDun) 
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }



            if (sistemegirisyapmismi == true)  
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(katet);

            Console.ReadLine();
        }
    }
}
