using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApp2
{
    [Serializable]

       class Stock
    {


       public static List<Product> products = new List<Product>();
       public  static List<Product> editProducts = new List<Product>();
        
       
        public Stock(Product p1, bool b)
        {
            if (b==true)
               products.Add(p1);
            if(b==false)
                if (p1.Id!=0)
                {
                    editProducts.Add(p1);

                }
            editProducts.RemoveAll(x => x.Id == 0);

        }
        public Stock()
        {


        

        }

        public static void Add(Product p1, double amount)
        {
            p1.Quantity = 0;
            
            for (int i = 0; i < amount; i++)
            {
                products.Add(p1);
            }


            editProducts.RemoveAll(x => x.Id == p1.Id);
            p1.Quantity = GetAmount(p1.Id);
            editProducts.Add(p1);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\adird\source\repos\WindowsFormsApp2\WindowsFormsApp2\Stock.txt", FileMode.Create, FileAccess.Write);
            Stream stream2 = new FileStream(@"C:\Users\adird\source\repos\WindowsFormsApp2\WindowsFormsApp2\EditProducts.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, p1);
            formatter.Serialize(stream2, p1);
            stream.Close();
            stream2.Close();




        }
        public static void AddToBill(Product p1, int amount)
        {
            // int q = product1.Quantity
            Product product1 = new Product();
            product1.Id = p1.Id;
            product1.Name = p1.Name;
            product1.Price = p1.Price;
            product1.ProductType = p1.ProductType;
            product1.Quantity = amount;
            deleteFromList(p1.Id, amount);
            BillingCode.AddProduct(product1);


        }
        

        public static int GetAmount(int id)
        {
            return products.Where(x => x.Id == id).ToList().Count;
        }

        public static List<Product> getList()
        {
            
           
            return editProducts;
        }
        public static void deleteFromList(int id, int amount)
        {
            Product product1=null;
            product1 = products.Find(x => x.Id == id);
            for (int i=0;i<amount;i++)
            {
                products.Remove(product1);
            }

            editProducts.RemoveAll(x => x.Id == product1.Id);
           product1.Quantity = GetAmount(product1.Id);
          //  if (product1.Quantity>0)
               editProducts.Add(product1);

        }
        
         
        
        
        public static void UpdateListAfterBill()
        {
            Product product1 = null;
            product1 = editProducts.Find(x => x.Quantity== 0);
            editProducts.Remove(product1);

        }
        public static Product GetProById(int id)
        {
            return products.Find(x => x.Id == id);
        }

        public static void Reset()
        {

            Product product1 = null;
            int id;
            List<Product> billProducts = BillingCode.GetBillProduct();
            foreach (var Item in billProducts)
            {
                id = Item.Id;
               
                product1 = products.Find(x => x.Id == id);
                if (product1==null)
                {
                    Stock.Add(Item, Item.Quantity);
                }
                else
                {
                    Stock.Add(product1, Item.Quantity);
                }
               
                
            }
              

        }
   


        public static bool GetPrice(int newPrice,int id)
        {
            Product product1 = new Product();
            product1= products.Find(x => x.Id == id);
            if (product1!=null)
                if (product1.Price != newPrice)
                      return false;

            return true;
        }
        public static bool editItem(int id, int price)
        {
            if (price<1)
            {
                return false;
            }
            foreach (var item in products)
            {
                if (item.Id == id)
                    item.Price = price;
            }
            foreach (var item in products)
            {
                if (item.Id == id)
                    item.Price = price;
            }
            return true;
        }
       
        
        
           

    }


    
}
