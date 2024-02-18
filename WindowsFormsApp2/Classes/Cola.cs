using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp2
{
    [Serializable]
    class Cola:Drinks
    {
      

        public Cola(string ProductName, string ProductType, int price, double liter)
           : base(ProductName, ProductType, price, liter)
        {
            if (liter == 0.750)
            {
                this.Id = 1;
            }
            else
                this.Id = 2;

        }
    }
}
