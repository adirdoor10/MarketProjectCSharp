using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class GummyStockForm : Form
    {
        public GummyStockForm()
        {
            InitializeComponent();
        }

        private void GummyName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (GummyPrice.Text == "" || GummyQuan.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int GummyPriceInt = 0;
                    int GummyQuanInt = 0;
                    Int32.TryParse(GummyPrice.Text, out GummyPriceInt);
                    Int32.TryParse(GummyQuan.Text, out GummyQuanInt);
                    Gummy gummy = new Gummy(GummyName.Text,"Food",GummyPriceInt, GummyQuanInt * 2);
                    Stock.Add(gummy, GummyQuanInt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SnaksFormStock d = new SnaksFormStock();
            d.Show();
        }

        public void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DrinksStockForm d = new DrinksStockForm();
            d.Show();
        }

        private void BillinkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing d = new Billing();
            d.Show();
        }

        private void deleteFromStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm d = new DeleteForm();
            d.Show();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            dataGridView1.DataSource = Stock.getList();
            GummyName.Text = "Gummy";

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (GummyPrice.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int GummyPriceInt = 0;
                int GummyQuanInt = 0;
                Int32.TryParse(GummyPrice.Text, out GummyPriceInt);
              if ( Stock.editItem(3, GummyPriceInt)==false)
                {
                    MessageBox.Show("Price must be more then 0");
                }
            

            }
            

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            GummyStockForm d = new GummyStockForm();
            d.Show();
        }
    }
}
