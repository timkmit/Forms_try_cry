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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int points = 0;
        int plusClickPoints = 1;
        int plusClickAutoPoints = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           points += plusClickPoints + plusClickAutoPoints;
           label1.Text = points.ToString();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
            
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (points >= 100)
            {
                plusClickAutoPoints += 1;
                points -= 100;
                label1.Text = points.ToString();
            }
        }
    }
}
