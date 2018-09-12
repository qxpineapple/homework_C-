using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, z = 0;
            String a = "", b = "";
            a = this.maskedTextBox1.Text;
            b = this.maskedTextBox2.Text;
            if ((a != null) && (b != null))
            {
                x = Int32.Parse(a);
                y = Int32.Parse(b);
                z = x * y;
                this.label1.Text = "" + z;
            }
        }

    }
}
