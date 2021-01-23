using System;

namespace OnAltıOcakSonrasıDenemeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Add();
            // Add2(6,5);sadece böyle yaparsam hiç bir şey olmaZ.çünkü bu method içinde sadece hesap yapıp sonuç döndürdük.
            var result = Add2(6,5); // var yerine int de yazabilirim.
            Console.WriteLine(result);

            var resuly = Add3(12);
            Console.WriteLine(resuly);
        }

        static void Add() 
        {
            Console.WriteLine("Hello");
        }

        static int Add2(int a, int b) //int yerine void yazamadım. void bi işlem yap demek. ben burada bir sonuç istiyorum bu nedenler void olmuyor.
        {
            var result = a + b;
            return result;
        }

        static int Add3(int x, int y, int z = 10) //default parametr kuralı. default değerler her zaman metodun en sonunda olmak zorunda
        {// mesela kdv uygulamsı yaparken %18 diye sabit oran verebilirsin düşmediği durumlar için.
            var resuly = x + y + z;
            return resuly;
        }

    }
}
