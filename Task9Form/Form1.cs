using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task9Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            while (true)
            {
                n = (int)AnumericUpDown.Value;
                try
                {
                    if (n <= 0)
                    {
                        MessageBox.Show("n не может быть нулём или отрицателтным числом");
                        continue;
                    }
                    break;
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!!!");
                }
            }
            MessageBox.Show("a = " + A(n));

        }
        static int A(int n)
        {
            if (n == 1) return 1;
            else if (n > 1)
            {
                int a = n;
                if ((Math.Pow(2, a - 1) <= n) && (n <= Math.Pow(2, a)))
                {
                    return a;
                }
                return A(n / 2) + 1;
            }
            return 0;
        }
    }
}
