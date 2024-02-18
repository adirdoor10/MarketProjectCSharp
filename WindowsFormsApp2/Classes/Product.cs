using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp2
{
    [Serializable]
     class Product 

    {
        public int _price;
        public string _ProductName;
        public string _ProductType;
        public int _productId;
        public int _quantity;
        public static int _id=0;

        public Product()
        {

            

        }
        public Product(string ProductName, string ProductType, int price)
        {
            _ProductType = ProductType;
            _ProductName = ProductName;
            _price = price;
        }

        #region get set
        public string Name
        {
            get => _ProductName;
            set => _ProductName = value;
        }
        public  string ProductType
        {
            get => _ProductType;
            set => _ProductType = value;

        }
        public int Price
        {
            get => _price;
            set => _price = value;

        }
      
        public int Quantity
        {
            
            get => _quantity;
            set => _quantity = value;

        }
        
       
     

        public int Id
        {
            get => _productId;
            set => _productId = value;

        }
        #endregion
        public void SetName(string value)
        {
            _ProductName = value;
        }
        

        public void SetId(int a)
        {
            _id = a;
            
        }

       
        public static int CreateId()
        {
            _id++;
            
            return _id;
        }
        
        }
    }

