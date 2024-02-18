using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        int startPos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        { 
            startPos += 1;
            progressBar1.Value = startPos;
            PrecenetLbl.Text = startPos + "%";
            if(progressBar1.Value==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
             
                Login log = new Login();
                this.Hide();
               
                
            }

            
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
