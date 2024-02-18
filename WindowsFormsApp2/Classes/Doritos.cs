using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp2
{
    [Serializable]
    class Doritos:Food
    {
        bool _sweet;
        bool _sour;
        
        

        public Doritos(string ProductName, string ProductType, int price, int quantity, double calories, bool sweet,bool sour)
        : base(ProductName, ProductType, price, calories)
        {
            _sweet = sweet;
            _sour = sour;
            if (sweet == true && sour==true)
                this.Id = 4;
            if (sweet == true && sour == false)
                this.Id = 5;
            if (sweet == false && sour == true)
                this.Id = 6;
            if (sweet == false && sour == false)
                this.Id = 7;
            

        }
        public bool Sweet
        {
            get => _sweet;
            set => _sweet = value;

        }
        public bool Sour
        {
            get => _sour;
            set => _sour = value;

        }
        
    }
}
