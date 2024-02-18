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
    static class BillingCode
    {
        static List<Product> billProducts = new List<Product>();
       
        public static void AddToBill(Product p1, int amount)
        {

            Product product1 = new Product();
            product1.Id = p1.Id;
            product1.Name = p1.Name;
            product1.Price = p1.Price;
            product1.ProductType = p1.ProductType;
            product1.Quantity = amount;
            billProducts.Add(product1);

            p1.Quantity = p1.Quantity- amount;
        }
        public static void RemoveBill()
        {
            billProducts.Clear();

        }
        public static List<Product> GetBillProduct()
        {
            return billProducts;
        }

        public static int GetBillingPrice()
        {
            int price = 0;
            foreach(var product in billProducts)
            {
                price += product.Price * product.Quantity;
            }
            return price;
        }

        public static int GetProById(int id)
        {
            return 0;
        }
        public static List<Product> GetList()
        {
            return billProducts;
        }
        public static void AddProduct(Product p1)
        {
            billProducts.Add(p1);

        }

    }
}
