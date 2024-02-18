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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing();
            bill.Show();
            this.Hide();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (UserName.Text == "Adir" || Password.Text == "")
                    {
                        this.Hide();
                        Billing bill = new Billing();
                        bill.Show();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
