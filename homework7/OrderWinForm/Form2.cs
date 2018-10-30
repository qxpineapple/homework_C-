using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderWinForm
{
    public partial class Form2 : Form
    {
        public int newCount { get; set; }
        public string newCustomer { get; set; }
        public string newItem { get; set; }
        Order order = new Order();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (Int32.TryParse(CounttextBox.Text, out count) && CustomertextBox.Text != null && ItemtextBox.Text != null)
            {

                newCount = count;
                newCustomer = CustomertextBox.Text;
                newItem = ItemtextBox.Text;
                order = new Order(newCustomer, newItem, newCount);
            }
            else
            {
                MessageBox.Show("Delete Data Fail!", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
                this.Close();
        }
    }
}
