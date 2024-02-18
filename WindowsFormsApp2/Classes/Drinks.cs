using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp2
{
    [Serializable]
    class Drinks : Product
    {
        public double _liter;





        public Drinks(string ProductName, string ProductType, int price, double liter)
            :base(ProductName, ProductType, price)
        {
            _liter = liter;
        }



  
       
        public double Liter
        {
            get => _liter;
            set => _liter = value;
        }
       

    }
}
