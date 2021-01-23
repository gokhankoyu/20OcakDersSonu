using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string = "gokhan";  // aslında string de bir obje ama sadece tek bir ifade tutabiliyor burada.


            Kurs kurs1 = new Kurs(); //Kurs isminde bir veri tipi oluşturdum. Önce class oluşturdum Kurs isminde. sanki kendi veri tipimi yazıyorum gibi
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); 
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmen = "KEREM";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "PHYTON";
            kurs3.Egitmen = "FURKAN";
            kurs3.IzlenmeOrani = 90;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };// kurs1 bir obje. kurs arrayinin içinde Kurs tipinde veriler tutuyorum.

            foreach  (var kurs in kurslar) // var yerine "Kurs" yazabilirdim.
            {
                Console.WriteLine( kurs.KursAdi + " : " + kurs.Egitmen); //burada sadece kurların adını yazdırmayı tercih ediyorum.
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; } //prop yazıp tab tab yapınca  burası geliyor. prop = property aslında.

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
