using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } //ID primary keyimiz.
        public int CategoryId { get; set; }//kategorileri genelde int ile tutarız
        public string ProductName { get; set; } // fore
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUDE operasyonları create,read, update, delete,
    }
}
