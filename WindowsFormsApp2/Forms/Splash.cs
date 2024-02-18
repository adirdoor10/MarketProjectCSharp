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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startPos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPos += 1;
            progressBar1.Value = startPos;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                
                this.Hide();
                Login log = new Login();
                log.Show();

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
