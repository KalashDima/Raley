using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Do_Click(object sender, EventArgs e)
        {
            int right = int.Parse(textBox1.Text);
            this.chart1.Series[0].Points.Clear();
            int t = 0;
            double sigma = 3 * Math.Pow(10, -5);
            while (t < right)
            {
                double fx = t / sigma / sigma * Math.Pow(Math.E, -t * t / 2 / sigma / sigma);
                double y = fx; 
                this.chart1.Series[0].Points.AddXY(t, y);
                t++;
            }
        }
    }
}
