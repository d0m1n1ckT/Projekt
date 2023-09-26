using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opakovani3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int a = textBox1.Lines.Count();
            int n;
            int[] cis = new int[a];

            for (int i = 0; i < a; i++)
            {
                n = Convert.ToInt32(textBox1.Lines[i]);
                cis[i] = n;
            }
            for (int i = 0; i < a; i++)
            {
                listBox1.Items.Add(cis[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int a = textBox1.Lines.Count();
            int[] cis = new int[a];
            int n;
            int max = int.MinValue;
            int min = int.MaxValue;
            int indexmax = 0;
            int indexmin = 0;

            for (int i = 0; i < a; i++)
            {
                n = Convert.ToInt32(textBox1.Lines[i]);
                cis[i] = n;
            }
            for (int i = 0; i < a; i++)
            {
                if (cis[i] > max)
                {
                    max = cis[i];
                    indexmax = i;
                }
                if (cis[i] < min)
                {
                    min = cis[i];
                    indexmin = i;
                }
                if (cis[i] == min)
                {
                    indexmin = i;
                }
            }

            cis[indexmin] = max;
            cis[indexmax] = min;

            for (int i = 0; i < a; i++)
            {
                listBox1.Items.Add(cis[i]);
            }

            MessageBox.Show("Index nejmenšího je " + indexmin + " a největšího " + indexmax);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = textBox1.Lines.Count();
            int[] cis = new int[a];
            int n;
            double artm;
            int hod = 0;
            int poc = 0;
            int prvmen = 0;
            int prvvet = 0;
            bool prv = false;
            bool pos = false;
            int indexmax = 0;
            int indexmin = 0;

            for (int i = 0; i < a; i++)
            {
                n = Convert.ToInt32(textBox1.Lines[i]);
                cis[i] = n;
            }
            for (int i = 0; i < a; i++)
            {
                if (i != 0 && i != a - 1)
                {
                    hod = hod + cis[i];
                    poc++;
                }
            }
            artm = (double)hod / poc;
            MessageBox.Show("Aritmetický průmer prvků je " + artm);
            for (int i = 0; i < a; i++)
            {
                if (cis[i] < artm && !prv)
                {
                    prvmen = cis[i];
                    indexmin = i;
                    prv = true;
                }
                if (cis[i] > artm && !pos)
                {
                    prvvet = cis[i];
                    indexmax = i;
                    pos = true;
                }
            }
            MessageBox.Show("První větší číslo je " + prvvet + " a první menší je " + prvmen);
            MessageBox.Show("Index menšího je " + indexmin + " a většího " + indexmax);
        }
    }
}
