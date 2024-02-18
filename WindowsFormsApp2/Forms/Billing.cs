using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            TotalBillingPrice.Text = BillingCode.GetBillingPrice().ToString();
            dataGridView1.DataSource = Stock.getList();
            billingGrid.DataSource = BillingCode.GetBillProduct();

        }

        
        

        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            if (BillingItem.Text == "" || BillingQnt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int productId, amountToBill;
                    Int32.TryParse(BillingItem.Text, out productId);
                    Int32.TryParse(BillingQnt.Text, out amountToBill);

                    int amountProduct = Stock.GetAmount(productId);
                    if (amountProduct< amountToBill)
                    {
                        MessageBox.Show("There are less items from quantity");
                    }
                    else
                    {
                        
                        var product = Stock.GetProById(productId);
                        Stock.AddToBill(product, amountToBill);
                        TotalBillingPrice.Text = BillingCode.GetBillingPrice().ToString();
                        billingGrid.DataSource = BillingCode.GetBillProduct();

                        this.Hide();
                        Billing d = new Billing();
                        d.Show();
                        
                       


                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            }

        public void DrinksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DrinksStockForm d = new DrinksStockForm();
            d.Show();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void deleteFromStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm d = new DeleteForm();
            d.Show();
        }

        private void billingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

        private void BuyBtn_Click(object sender, EventArgs e)
        {

            Stock.UpdateListAfterBill();
            BillingCode.RemoveBill();
            MessageBox.Show("Have a nice day");
            this.Hide();
            Billing d = new Billing();
            d.Show();

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Stock.Reset();
            BillingCode.RemoveBill();
            MessageBox.Show("Bill has benn reset");
            this.Hide();
            Billing d = new Billing();
            d.Show();
        }

        private void TotalBillingPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

