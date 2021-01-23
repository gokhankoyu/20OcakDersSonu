using System;

namespace _16OcakDers
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma ";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 56;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz ";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 123;

            Urun[] urunler = new Urun[] { urun1, urun2 }; // urun arrayi oluşturdum. Data veri kaynağından gelir. normalde dizi içindeki veriler bir veri kaynağından gelir. Api-excel-metin dosyası vb.

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
       
                Console.WriteLine("---------------------------------------");
            }
            //.net motorumuz bu süslü parantez içini her bir urun için bir tur dönüyor.       


            Console.WriteLine("------------------------METODLAR--------------");
            //metot bana reusability imkanı veriyor.
            //instance - class örneği oluşturmak. aşağıdaki "SepetManager sepetManager = new SepetManager();" ile örnek oluşturduk.
            SepetManager sepetManager = new SepetManager();

            // sepetManager.Ekle();   bu şekilde yaparak metodumuzu çağırıyoruz.
 
            sepetManager.Ekle(urun1); // Eklenin önündeki parantez boş olursa uyarı verir. Çünkü ekle motodunu çağıracak olan kişiden urun parametresi de belirtmesini istmeiştim.
            sepetManager.Ekle(urun2);

            Console.WriteLine("*****************************");
            /*
            sepetManager.Ekle2("armut", 12, "kırmızı armut", 56);
            sepetManager.Ekle2("elma", 13, "Yeşil Elma", 40);
            sepetManager.Ekle2("ayva", 12, "sarı ayva", 60);
            */
            

        }
    }
}


// Dont repeat yourself - DRY - Clean Code -temiz kod yazma teknikleri- Best Practise - doğru uygulama yöntemi
// c# ve java gibi programlarda hemen hemen herşey class içerisinde olur.


