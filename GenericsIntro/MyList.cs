using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList <T>
    {
        T [] items;//metodun dışında ama classın içinde. classın bütün operasyonlarının erişebileceği bir dizi tanımladım.
        //constructor  
        public MyList()//constructor bloğum.
        {
            items = new T[0];
        }       
        public void Add(T item)
        {
            T[] tempArray = items; //tempArray dizisi items in heapteki referansını kaybolmasın diye tutuyor.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
    }
}
