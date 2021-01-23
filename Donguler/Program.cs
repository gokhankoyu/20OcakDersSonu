using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gel Yet Kampı"; // bu kursların sayısı zamanla artabilir. bu kursları ekranda dinamik olarak yönetebilmemiz lazım.
            string kurs2 = "Programlamaya başlangıç için temel kurs"; // ikiyüz ürün olsa her biri için tek tek kurs tanımlayamayız.
            // bu tarz değişkenleri arraylerde (dizilerde) tanımlarız.

            // istediğim kadar kursu tek bir değişkende tutuyorum. artık değişkenin türü string değil "string array"
            string[] kurslar = new string[] { "Yazılım Geliştirme Yetiştirme Kampı", 
                "Programlamaya Başlangıç İçin Temel kurs", 
                "Java Kursu", "Phyton","C++"};

            for (int i = 0; i < kurslar.Length; i++) // Length eleman sayısını verir. eleman sayısı 3 burada. aslında i<3 demek. ilk eleman sıfırıncı eleman.
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR BİTTİ / YENİ DÖNGÜ YÖNTEMİ");

            foreach (string kurs in kurslar) // dizi temelli yapıları tek tek dönmeye (dolaşmaya) yarar. "in kurslar" kursları dolaş demek.
                // "kurs" kelimesi aliace (takma isim)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - footer");



            /*
             * for (int i = 1; i < 10; i+=2) //i şartı sağlıyorsa if bloğunu bir tur çalıştır ve sonrasında i değerini arttır ve tekrar kontrol et.
            {//i değerini 2 şer arttırmanın bir yolu i+=2
                Console.WriteLine(i); 
            }
            */

        }
    }
}
