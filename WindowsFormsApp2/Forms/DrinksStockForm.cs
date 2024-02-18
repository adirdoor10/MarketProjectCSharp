using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class DrinksStockForm : Form
    {
        public DrinksStockForm()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.DataSource = Stock.getList();
        }
        

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            

            if (DrinksQun.Text == ""||DrinksPrice.Text=="")
            {

                MessageBox.Show("Missing Information, or information...");
            }
           else if (Regex.IsMatch(DrinksNames.Text, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("Use vaild signs");
            }
            else
            {
                try
                {
                    int DrinksPriceInt = 0, DrinksQuanInt = 0,id;
                    double DrinkLiterDouble = 0;
                    
                    Int32.TryParse(DrinksPrice.Text, out DrinksPriceInt);
                    DrinkLiterDouble = (Convert.ToDouble(DrinksLiter.Text));
                    Int32.TryParse(DrinksQun.Text, out DrinksQuanInt);
                    if (DrinkLiterDouble == 1)
                    {
                        id = 2;
                    }
                        
                    else
                    {
                        id = 1;
                    }
                   
                    if (Stock.GetPrice(DrinksPriceInt,id) ==true)
                    {
                        var cola = new Cola("Cola", "Drinks", DrinksPriceInt, DrinkLiterDouble);
                        Stock.Add(cola, DrinksQuanInt);
                    }
                    else
                      MessageBox.Show("Price doesn't match to product!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    

        

        

        private void SnaksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SnaksFormStock d = new SnaksFormStock();
            d.Show();
        }

        private void GummyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GummyStockForm d = new GummyStockForm();
            d.Show();
        }

        private void BillingBtn_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Billing d = new Billing();
                d.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DrinksQun_TextChanged(object sender, EventArgs e)
        {

        }

        private void DrinksNames_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DrinksQun.Text != "" || DrinksPrice.Text == "")
            {
                MessageBox.Show("Error");
            }
            else
            {

            }
            int DrinksPriceInt = 0,  id;
            double DrinkLiterDouble = 0;

            Int32.TryParse(DrinksPrice.Text, out DrinksPriceInt);
            DrinkLiterDouble = (Convert.ToDouble(DrinksLiter.Text));
            if (DrinkLiterDouble == 1)
            {
                id = 2;
            }

            else
            {
                id = 1;
            }
           if( Stock.editItem(id, DrinksPriceInt)==false)
                MessageBox.Show("Price must be more then 0");




        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            int DrinksQuanInt = 0;
            Int32.TryParse(DrinksQun.Text, out DrinksQuanInt);
            
            Stock.deleteFromList(2, DrinksQuanInt);
        }

        private void deleteFromStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm d = new DeleteForm();
            d.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DrinksLiter_TextChanged(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Stock.getList();
            this.Hide();
            DrinksStockForm d = new DrinksStockForm();
            d.Show();

        }
    }
}
