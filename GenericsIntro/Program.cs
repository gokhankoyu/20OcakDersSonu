using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
    
        static void Main(string[] args)
        
        {

            List<string> sehirler = new List<string>();
            {
                sehirler.Add("Adana");
                Console.WriteLine(sehirler[0]);
            }


            MyList<int> isimler = new MyList<int>();
            {
                isimler.Add(5);
                Console.WriteLine(isimler[]);
            }
           
        }
    }
}
