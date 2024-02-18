using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;



namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
           
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"C:\Users\adird\source\repos\WindowsFormsApp2\WindowsFormsApp2\Stock.txt", FileMode.Open, FileAccess.Read);
                Stream stream2 = new FileStream(@"C:\Users\adird\source\repos\WindowsFormsApp2\WindowsFormsApp2\EditProducts.txt", FileMode.Open, FileAccess.Read);

                Stock stock = new Stock((Product)formatter.Deserialize(stream), true);
                Stock stock2 = new Stock((Product)formatter.Deserialize(stream2),false);
                stream.Close();
                stream2.Close();
            }
            catch
            {

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Billing());

           






        }
    }
}
