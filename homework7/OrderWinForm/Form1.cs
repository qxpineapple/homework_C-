﻿using System;
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
   
    public partial class Form1 : Form
    {
        Order order = new Order();
        public string KeyWord { get; set; }

        public Form1()
        {
            InitializeComponent();
            order = new Order("Customer1", "Item1", 100);
            order = new Order("Customer2", "item2", 2);
            order = new Order("Customer3", "item3", 2);
            order = new Order("Customer4", "item4", 2);
            order = new Order("Customer5", "item5", 2);
            order = new Order("Customer6", "item6", 2);
            order = new Order("Customer1", "Item1", 100);
            order = new Order("Customer2", "item2", 2);
            order = new Order("Customer1", "Item1", 100);
            order = new Order("Customer2", "item2", 2);
            order = new Order("Customer3", "item3", 2);
            order = new Order("Customer4", "item4", 2);
            order = new Order("Customer5", "item5", 2);
            order = new Order("Customer6", "item6", 2);
            order = new Order("Customer1", "Item1", 100);
            order = new Order("Customer2", "item2", 2);


            orderDetailsBindingSource1.DataSource = OrderService.orderList;
            FoundtextBox.DataBindings.Add("Text", this, "KeyWord");
        }

        private void Founding_Click(object sender, EventArgs e)
        {
            int keyNumber = 0;
            if (FoundByID.Checked)
            {
                if (Int32.TryParse(KeyWord, out keyNumber) && keyNumber != 0)
                {
                    orderDetailsBindingSource1.DataSource =
                        OrderService.orderList.Where(s => s.Id == keyNumber);
                }
            }
            else if (FoundByName.Checked)
            {
                orderDetailsBindingSource1.DataSource = 
                    OrderService.orderList.Where(s => s.CustomerName == KeyWord);
            }
        }

        private void FoundVIP_Click(object sender, EventArgs e)
        {
            orderDetailsBindingSource1.DataSource =
                   OrderService.orderList.Where(s => s.Price*s.Count >= 10000);           
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int iCount = dataGridView1.SelectedRows.Count;
            if (iCount < 1)
            {
                MessageBox.Show("Delete Data Fail!", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("是否删除选中的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                for (int i = this.dataGridView1.SelectedRows.Count; i > 0; i--)
                {
                    //当前行处于选中状态，则将其删除
                    if(dataGridView1.SelectedRows[i - 1].Cells[0].Value != null)
                    {
                    int ID = Convert.ToInt32(dataGridView1.SelectedRows[i - 1].Cells[0].Value);
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[i - 1].Index);

                    }
                }
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.StartPosition = FormStartPosition.CenterParent;
            f2.ShowDialog(this);
            renew_Click(sender, e);
        }

        private void renew_Click(object sender, EventArgs e)
        {
            List<OrderDetails> temp = new List<OrderDetails>();
            orderDetailsBindingSource1.DataSource = temp;
            orderDetailsBindingSource1.DataSource = OrderService.orderList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelOfFunction_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FoungdingtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FoundingByName_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void FoundingByID_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
