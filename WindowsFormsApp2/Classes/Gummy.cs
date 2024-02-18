using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp2
{

     class Gummy : Food
    {

        
       
       
        public Gummy(string ProductName, string ProductType, int price, double calories)
        : base(ProductName, ProductType, price, calories)
        {
            
            this.Id = 3;
        }
       

    }
}
