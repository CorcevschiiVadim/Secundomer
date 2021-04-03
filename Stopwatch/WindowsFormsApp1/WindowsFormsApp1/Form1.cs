using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int m, s, ms;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ms += 1;
            if (ms == 60)
            {
                ms = 0;
                s += 1;
            }
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            label1.Text = m.ToString() + " : " + s.ToString() + " : " + ms.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m = 0; s = 0; ms = 0;
            label1.Text = "0 : 0 : 0";
        }
    }
}
