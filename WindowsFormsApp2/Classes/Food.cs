using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp2
{
    [Serializable]

    class Food : Product
    {
        public double _calories;
        
        public Food(string ProductName, string ProductType, int price, double calories)
           : base(ProductName, ProductType, price)
        {
            _calories = calories;
        }

        public double Calories
        {
            get => _calories;
            set => _calories = value;
        }
        

    }
}
