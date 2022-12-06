using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raley
{
    static class Program
    {
        public static double Raley(double t)
        {
            double fx;
            double sigma = 3 * Math.Pow(10, -5);
            if (t >= 0)
            {
                fx = t / sigma / sigma * Math.Pow(Math.E, -t * t / 2 / sigma / sigma);
                return fx;
            }
            else
                return 0;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
