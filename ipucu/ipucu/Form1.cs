using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] a = new int[10];
        private int[] b = new int[10];
        private int[] c = new int[10];
        private int[] d = new int[10];

        private int[] B = new int[10];
        private int[] C = new int[10];

        private int B1, C1;

        private int i, j;

        private void button1_Click(object sender, EventArgs e)
        {

            Random rndd = new Random();

            for (i = 0; B[i] != 4; i++)
            {

                a[i] = 0; b[i] = 0;
                while (a[i] == b[i] || a[i] == c[i] || a[i] == d[i] || b[i] == c[i] || b[i] == d[i] || c[i] == d[i])
                {
                    d[i] = rndd.Next(0, 10);
                    c[i] = rndd.Next(0, 10);
                    b[i] = rndd.Next(0, 10);
                    a[i] = rndd.Next(0, 10);

                }

                for (j = 0; j < i; j++)
                {
                    B1 = 0; C1 = 0;
                    if (a[j] == b[i] || a[j] == c[i] || a[j] == d[i]) { C1 = C1 + 1; } else if (a[j] == a[i]) { B1 = B1 + 1; }
                    if (b[j] == a[i] || b[j] == c[i] || b[j] == d[i]) { C1 = C1 + 1; } else if (b[j] == b[i]) { B1 = B1 + 1; }
                    if (c[j] == b[i] || c[j] == a[i] || c[j] == d[i]) { C1 = C1 + 1; } else if (c[j] == c[i]) { B1 = B1 + 1; }
                    if (d[j] == b[i] || d[j] == c[i] || d[j] == a[i]) { C1 = C1 + 1; } else if (d[j] == d[i]) { B1 = B1 + 1; }

                    if (B1 != B[j] || C1 != C[j])
                    {
                        a[i] = 0; b[i] = 0;
                        while (a[i] == b[i] || a[i] == c[i] || a[i] == d[i] || b[i] == c[i] || b[i] == d[i] || c[i] == d[i])
                        {
                            d[i] = rndd.Next(0, 10);
                            c[i] = rndd.Next(0, 10);
                            b[i] = rndd.Next(0, 10);
                            a[i] = rndd.Next(0, 10);

                        }

                        j = -1;


                    }

                }



                textBox1.Text = "" + a[i] + b[i] + c[i] + d[i];


                int.TryParse(comboBox1.Text, out B[i]);
                if (B[i] != 4)
                {
                  
                    int.TryParse(comboBox2.Text, out C[i]);
                }
                else
                {
                    string message = "Your number is" + "!";
                    string title = "I won!";
                    MessageBox.Show(message, title);


                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }
    }
}
