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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            {


                int barCode = 0, quantity1 = 0;
                if (barcode.Text == "" || quantity.Text == "")
                {

                    MessageBox.Show("Missing Information, or information...");
                }

                else
                {
                    Int32.TryParse(barcode.Text, out barCode);
                    Int32.TryParse(quantity.Text, out quantity1);
                    int checkQuan = Stock.GetAmount(barCode);
                    if (checkQuan == 0 || Stock.getList() == null)
                    {
                        MessageBox.Show("There is no item to delete");
                    }
                    else
                    {
                        Stock.deleteFromList(barCode, quantity1);
                        dataGridView1.DataSource = Stock.getList();
                    }
                    

                }
            }
           
            
            
        }

        private void BillingPrice_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.DataSource = Stock.getList();
        }

        private void DrinksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DrinksStockForm d = new DrinksStockForm();
            d.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GummyStockForm d = new GummyStockForm();
            d.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.DataSource = Stock.getList();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Stock.getList();
            this.Hide();
            DeleteForm d = new DeleteForm();
            d.Show();

        }

        private void BillingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing d = new Billing();
            d.Show();
        }

        private void snaksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SnaksFormStock d = new SnaksFormStock();
            d.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
