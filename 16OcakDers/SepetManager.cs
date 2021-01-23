using System;
using System.Collections.Generic;
using System.Text;

namespace _16OcakDers
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı

        //public void Ekle(); burada aslında Ekle isminde bir metod oluşturuyoruz ve içindeki süslü paranteze kodumuzu yazıyoruz.
        public void Ekle(Urun urun) //normal parantez görürsek orada metod çalışıyor demektir.
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi + " Stok Adedi : " + urun.StokAdedi);
        }

        //public void 

        public void Ekle2(string UrunAdi, double Fiyati, string Aciklama, int StokAdedi) 
        {
            Console.WriteLine(UrunAdi + " : " + Fiyati);
            Console.WriteLine(Aciklama + " : " + StokAdedi);
            Console.WriteLine("-----");
        }

    }
}
