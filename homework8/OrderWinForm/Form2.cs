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
        public string newPhone { get; set; }
        public string newTime { get; set; }
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
            if (Int32.TryParse(CounttextBox.Text, out count) && CustomertextBox.Text != null)
            {

                newCount = count;
                newCustomer = CustomertextBox.Text;
                newItem = ItemtextBox.Text;
                newPhone = phoneBox.Text;
                newTime = yearBox.Text + "/" + monthBox.Text + "/" + dayBox.Text + "/" + dayBox2.Text;
                if(!Order.PhoneIsOK(newPhone))
                {
                    MessageBox.Show("电话号码错误", "Error", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                }
                else if(!Order.TimeIsOK(newTime))
                {
                    DialogResult result = 
                    MessageBox.Show("日期错误 是否采用本日日期", "Error", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Error);
                    if(result == DialogResult.Yes)
                    {
                        order = new Order(newCustomer, newItem, newCount, newPhone);
                    }
                }
                else
                order = new Order(newCustomer, newItem, newCount, newPhone,newTime);
                    
            }
            else
            {
                MessageBox.Show("Delete Data Fail!", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
                this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
