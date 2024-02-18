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
    public partial class SnaksFormStock : Form
    {
        public SnaksFormStock()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.DataSource = Stock.getList();
            SnaksName.Text = "Doritos";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void drinksPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SnaksName.Text == "" || SnaksPrice.Text == "" || SnaksQuan.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int snaksPriceInt = 0, snaksQuanInt=0;
                    bool snaksSour=false, snaksSweet=false;
                    if (SnaksSour.Checked)
                        snaksSour = true;
                    if (SnaksSweet.Checked)
                        snaksSweet =true;
                    Int32.TryParse(SnaksQuan.Text, out snaksQuanInt);
                    Int32.TryParse(SnaksPrice.Text, out snaksPriceInt);
                    Doritos doritos = new Doritos(SnaksName.Text,"Food", snaksPriceInt, snaksQuanInt,0, snaksSour, snaksSweet);
                    Stock.Add(doritos, snaksQuanInt);
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

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

        private void DrinksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DrinksStockForm d = new DrinksStockForm();
            d.Show();

        }

       

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if ( SnaksPrice.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int snaksPriceInt = 0,  id=0;
                    bool snaksSour = false, snaksSweet = false;

                    if (SnaksSour.Checked && SnaksSweet.Checked)
                        id = 4;
                    if (SnaksSour.Checked && !SnaksSweet.Checked)
                        id = 6;
                    if (!SnaksSour.Checked && SnaksSweet.Checked)
                        id = 5;
                    if (!SnaksSour.Checked && !SnaksSweet.Checked)
                        id = 7;
                    Int32.TryParse(SnaksPrice.Text, out snaksPriceInt);
                   if( Stock.editItem(id, snaksPriceInt)==false)
                        MessageBox.Show("Price must be more then 0");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SnaksQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void SnaksName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SnaksSour_CheckedChanged(object sender, EventArgs e)
        {

        }

        

       

        private void deleteFromStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm d = new DeleteForm();
            d.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            SnaksFormStock d = new SnaksFormStock();
            d.Show();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
