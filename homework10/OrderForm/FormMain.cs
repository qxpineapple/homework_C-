using ordertest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class FormMain : Form
    {
        OrderService orderService = new OrderService();
        BindingSource fieldsBS = new BindingSource();
        public FormMain()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {

            Customer customer1 = new Customer("1", "Customer1");
            Customer customer2 = new Customer("2", "Customer2");
            Customer customer3 = new Customer("3", "limbo");

            Goods milk = new Goods("1", "Milk", 69.9);
            Goods eggs = new Goods("2", "eggs", 4.99);
            Goods apple = new Goods("3", "apple", 5.59);

            OrderDetail orderDetails1 = new OrderDetail("1", apple, 800);
            OrderDetail orderDetails2 = new OrderDetail("2", eggs, 2);
            OrderDetail orderDetails3 = new OrderDetail("3", milk, 1);

            Order order1 = new Order("1", customer1);
            Order order2 = new Order("2", customer2);
            Order order3 = new Order("3", customer3);
            order1.AddDetails(orderDetails1);
            order2.AddDetails(orderDetails2);
            order3.AddDetails(orderDetails3);

            OrderService os = new OrderService();
            os.Add(order1);
            os.Add(order2);
            os.Add(order3);

            orderBindingSource.DataSource = orderService.GetAllOrders();
        
    }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEdit form2 = new FormEdit(new Order());
            form2.ShowDialog();
            Order newOrder = form2.getResult();
            if (newOrder!=null){
                orderService.Add(newOrder);
                orderBindingSource.DataSource = orderService.GetAllOrders();
            }
           
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormEdit form2 = new FormEdit((Order)orderBindingSource.Current);
            btnDelete_Click(sender, e);
            form2.ShowDialog();
            Order newOrder = form2.getResult();
            if (newOrder != null)
            {
                orderService.Add(newOrder);
                orderBindingSource.DataSource = orderService.GetAllOrders();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Order o=(Order)orderBindingSource.Current;
            if (o != null)
            {
                orderService.Delete(o.Id);
                orderBindingSource.DataSource=orderService.GetAllOrders();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbField.SelectedIndex)
            {
                case 0:
                    orderBindingSource.DataSource =
                        orderService.GetAllOrders();
                    break;
                case 1:
                    orderBindingSource.DataSource =
                            orderService.GetOrder(txtValue.Text);
                    break;
                case 2:
                    orderBindingSource.DataSource =
                            orderService.QueryByCustormer(txtValue.Text);
                    break;
                case 3:
                    orderBindingSource.DataSource =
                            orderService.QueryByGoods(txtValue.Text);
                    break;
            }

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
