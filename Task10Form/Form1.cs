using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task10Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                int n = (int) NnumericUpDown.Value;
                MessageBox.Show(t_1(n, 0));

        }
             string t_1(int nmax, int n)
            {
            var s = "";
                int j;

                if (n <= nmax)
                {
                    for (j = 1; j <= n; j++)
                        s += n + " ";
                s += "\n";    
                s += t_1(nmax, n + 1);
                }
            return s;
            }
    }
}
