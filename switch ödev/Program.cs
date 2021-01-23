using System;

namespace switch_ödev
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             int x = 3;

            switch (x)
            {
                case 4:

                Console.WriteLine("ali");
                    break;

                case 3:
                case 5:

                    Console.WriteLine("hasan");
                    break;

                    Console.ReadLine();
            }

            */

            Ofis ofis1 = new Ofis(); // benim artık ofis1 isimli Ofis tipinde bir değişkenim var. bir Ofis değişkeni tanımlamak istiyorsak bu şekilde tanımlarız.
            ofis1.firmaadi = "EKİNOKS"; //her bir değişkenime vereceğim property leri daha önce Ofis class'ı içerisinde oluşturdum.
            ofis1.ofisalani = 300;
            ofis1.ucret = 65;

            Ofis ofis2 = new Ofis(); 
            ofis2.firmaadi = "KAREL";
            ofis2.ofisalani = 350;
            ofis2.ucret = 60;

            Ofis ofis3 = new Ofis(); 
            ofis3.firmaadi = "NETCAD";
            ofis3.ofisalani = 400;
            ofis3.ucret = 55;

           // Console.WriteLine(ofis1.firmaadi + " : " + ofis1.ofisalani + "m²" + " : " + "Kira m² ücreti" + " = " + ofis1.ucret + " TL " );

            
            Ofis[] ofisler = new Ofis[] { ofis1, ofis2, ofis3 }; // içerisinde Ofis nesnesi barındıran Ofis arrayi tanımladım.

            foreach (Ofis ofis in ofisler)
            {

                Console.WriteLine(ofis.firmaadi + " : " + ofis.ofisalani + "m²" + " : " + "Kira m² ücreti" + " = " + ofis.ucret + " TL ");
            }

            Urun urun1 = new Urun();
            urun1.cinsiyet = "Erkek";
            urun1.marka = "Mavi";
            urun1.size = 55;

            Urun urun2 = new Urun();
            urun2.cinsiyet = "Erkek";
            urun2.marka = "ZARA";
            urun2.size = 36;

            Urun urun3 = new Urun();
            urun3.cinsiyet = "Kadın";
            urun3.marka = "Polo";
            urun3.size = 39;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            for (int i=0 ; i < urunler.Length; i++)
            {
                if (urunler[i].cinsiyet == "Erkek")
                {
                    // Urun abc = urunler[i]; yazıp aşağıdaki abc.size şeklinde olduğu gibi de yazdırabilirdik.
                    Urun abc = urunler[i];
                    Console.WriteLine("ERKEK REYONU");
                    Console.WriteLine(urunler[i].cinsiyet + " " + urunler[i].marka + " " + urunler[i].size);
                    //Console.WriteLine(abc.size);
                }
                else 
                {
                    Console.WriteLine("KADIN REYONU");
                    Console.WriteLine(urunler[i].cinsiyet + " " + urunler[i].marka + " " + urunler[i].size);
                }
                
            }

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.cinsiyet);
            }

            int z = 0;
            while (z < urunler.Length)
            {
                Console.WriteLine(urunler[z].size);
                z++;
            }

        }


            class Ofis //class yazdım tab tab yaptım.
        {
            public string firmaadi { get; set; } //aslında bunların her biri property. Ofis objesi oluşturdum. bu obje string int gibi tipleri bir arada tutuyor. yeni bir tip gibi.
            public int ofisalani { get; set; } // prop yazdım tab tab yaptım.
            public int ucret { get; set; }

        }

            class Urun

        {

            public string cinsiyet { get; set; }

            public string marka { get; set; }

            public int size { get; set; }

        }
    }


}
