using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order
{
    class MyException : ApplicationException
    {
        public MyException(string message) : base(message)
        {

        }
    }
    public class OrderDetails
    {
        private int _id;
        private string _customerName;
        private string _itemName;
        private int _count;
        private const int _price = 1000;

        public int Price
        {
            get { return _price; }
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return _customerName;
            }
            set
            {
                _customerName = value;
            }
        }
        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                _itemName = value;
            }
        }

        public OrderDetails(string customerName = null, string itemName = null, int count = 0)
        {
            this.Count = count;
            this.CustomerName = customerName;
            this.ItemName = itemName;
        }
        public override string ToString()
        {
            return
                "========================================================================================================" + "\n" +
                "订单：" + Id + "\n" +
                "客户：" + CustomerName + "\n" +
                "商品：" + ItemName + "\n" +
                "数量：" + Count + "\n" +
                "价格: " + Price + "\n" +
                "金额：" + Count * Price + "\n" +
                "========================================================================================================" + "\n";
        }
    }
    public class OrderService
    {
        public List<OrderDetails> orderList = new List<OrderDetails>();
        public int this[int id]
        {
            get
            {
                int index = 0;
                while (index < orderList.Count)
                {
                    if (orderList[index].Id == id)
                    {
                        return orderList[index].Id;
                    }
                    index++;
                }
                return -1;
            }
        }
        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < orderList.Count)
                {
                    if (orderList[index].CustomerName == name || orderList[index].ItemName == name)
                    {
                        return orderList[index].Id;
                    }
                    index++;
                }
                return -1;
            }
        }
        public void OrderDelete(int ID)
        {
            orderList.RemoveAt(ID);
        }
        public void InsertOrder(OrderDetails newOrder)
        {
            orderList.Add(newOrder);
            newOrder.Id = orderList.Count;
        }
    }
    public class Order
    {
        static OrderService orderService = new OrderService();
        private OrderDetails order;
        public Order(string costumerName, string itemName, int count)
        {
            order = new OrderDetails(costumerName, itemName, count);
            orderService.InsertOrder(order);
        }
        public Order() { }

        /*
        //按订单号查找
        public void Seek(int id)
        {
            int ID = orderService[id] - 1;
            if (ID >= 0)
            {
                Console.WriteLine("所找订单信息：");
                Console.WriteLine(orderService.orderList[ID].ToString());
            }
            else
            {
                Console.WriteLine("无此订单!");
            }
        }
        //用户和商品名称查找
        public void Seek(string name)
        {
            int ID = orderService[name] - 1;
            if (ID >= 0)
            {
                Console.WriteLine("所找订单信息：");
                Console.WriteLine(orderService.orderList[ID].ToString());
            }
            else
            {
                Console.WriteLine("无此订单!");
            }
        }
        */
        //查找
        public void Seek(string name)
        {
            var query = from n in orderService.orderList
                        where n.CustomerName == name || n.ItemName == name
                        select n;
            foreach (var n in query)
            {
                Console.WriteLine("所查找的订单：");
                Console.WriteLine(n.ToString());
            }
        }
        public void Seek(int id)
        {
            var query = from n in orderService.orderList
                        where n.Id == id
                        select n;
            foreach (var n in query)
            {
                Console.WriteLine("所查找的订单：");
                Console.WriteLine(n.ToString());
            }
        }
        public void FoundVIP()
        {
            var query = from n in orderService.orderList
                        where n.Count * n.Price >= 10000
                        select n;
            foreach (var n in query)
            {
                Console.WriteLine("订单金额大于10000：");
                Console.WriteLine(n.ToString());
            }

        }


        //修改用户和商品名称
        public void Change(int flag, int ID, string name)
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("无可操作订单");
            }
            else if (ID >= 1 && ID <= orderService.orderList.Count)
            {
                ID--;
                switch (flag)
                {
                    case 2:
                        orderService.orderList[ID].CustomerName = name;
                        Console.WriteLine("请核对修改后订单信息:");
                        Console.WriteLine(orderService.orderList[ID].ToString());
                        break;
                    case 3:
                        orderService.orderList[ID].CustomerName = name;
                        Console.WriteLine("请核对修改后订单信息:");
                        Console.WriteLine(orderService.orderList[ID].ToString());
                        break;
                }
            }
            else
            {
                Console.WriteLine("超出可修改范围");
            }

        }
        //修改数量
        public void Change(int flag, int ID, int count)
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("无可操作订单");
            }
            else if (ID >= 1 && ID <= orderService.orderList.Count)
            {
                ID--;
                orderService.orderList[ID].Count = count;
                Console.WriteLine("请核对修改后订单信息:");
                Console.WriteLine(orderService.orderList[ID].ToString());
            }
            else
            {
                throw new MyException("超出可修改范围");
            }


        }

        public void Delete(int ID)
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("无可操作订单");
            }
            else if (ID >= 1 && ID <= orderService.orderList.Count)
            {
                ID--;
                orderService.OrderDelete(ID);

            }
            else
            {
                Console.WriteLine("超出可删除范围");
            }


        }

        /*
        public string Details()
        {
            return this.order.ToString();
        }
        */
        public string Details(int ID)
        {
            if (ID >= 1 && ID <= orderService.orderList.Count)
            {
                ID--;
                return orderService.orderList[ID].ToString();
            }
            else
            {
                throw new MyException("超出范围");
            }


        }

        public bool IsEmpty()
        {
            return orderService.orderList.Count() == 0;
        }

    }

    class Test

    {
        static int MyInt()
        {
            int id;
            string temp;
            temp = Console.ReadLine();
            if (!Int32.TryParse(temp, out id))
            {
                Console.WriteLine("请输入适当的整数:");
                MyInt();
            }
            return id;

        }
        static void StartOrder()
        {
            Order order = new Order();
            int flag = 0;
            int id = 0;
            string temp = null;
            Console.WriteLine("========================================================================================================");
            Console.WriteLine("输入您想使用的功能代号（1.新增订单；2.查找订单；3.删除订单；4.修改订单；5.金额大于10000的订单）: ");
            flag = MyInt();
            /*
            temp = Console.ReadLine();
            if(!(Int32.TryParse(temp, out flag) && flag >= 1 && flag <= 4))
            {
                Console.WriteLine("请输入适当的整数");
                Console.WriteLine();
                StartOrder();
            }
            */
            switch (flag)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("输入商品名：");
                    string itemName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("输入客户名：");
                    string costumerName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("输入数量:");
                    id = MyInt();
                    /*
                    loop1:temp = Console.ReadLine();
                    if (!Int32.TryParse(temp, out id))
                    {
                        Console.WriteLine("请输入适当的整数");
                        Console.WriteLine();
                        goto loop1;
                    }*/
                    order = new Order(itemName, costumerName, id);
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("输入您想要查找订单的相关信息: ");
                    temp = Console.ReadLine();
                    if (Int32.TryParse(temp, out id))
                    {
                        order.Seek(id);
                    }
                    else
                    {
                        order.Seek(temp);
                    }

                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("输入您想要删除订单的订单号: ");
                    id = MyInt();
                    order.Delete(id);
                    /*
                    loop3: temp = Console.ReadLine();
                    if (Int32.TryParse(temp, out id))
                    {
                        order.Seek(id);
                    }
                    else
                    {
                        Console.WriteLine("请输入适当的整数");
                        Console.WriteLine();
                        goto loop3;
                    }
                    */

                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("输入您想修改的订单号: ");
                    id = MyInt();
                    /*
                    loop4: temp = Console.ReadLine();
                    if (Int32.TryParse(temp, out id))
                    {
                        order.Seek(id);
                    }
                    else
                    {
                        Console.WriteLine("请输入适当的整数");
                        Console.WriteLine();
                        goto loop4;
                    }
                    */
                    Console.WriteLine("输入您想使用的功能代号（1.修改数量；2.用户名称；3.商品名称): ");
                    flag = MyInt();
                    if (flag == 1)
                    {
                        Console.WriteLine("输入您想修改的数量: ");
                        int count = MyInt();
                        order.Change(flag, id, count);
                    }
                    else
                    {
                        Console.WriteLine("输入您想修改的名称: ");
                        temp = Console.ReadLine();
                        order.Change(flag, id, temp);
                    }
                    break;
                case 5:
                    order.FoundVIP();
                    break;
            }
            StartOrder();
        }

        static void Main(string[] args)
        {
            StartOrder();
            /*
            Order order = new Order();
            order.IsEmpty();
            Console.WriteLine("输入商品名：");
            string itemName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("输入客户名：");
            string costumerName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("输入数量:");
            int count = Convert.ToInt32(Console.ReadLine());
            Order myOrder01 = new Order(itemName, costumerName, count);
            Order myOrder02 = new Order(itemName, costumerName, count);
            Order myOrder03 = new Order(itemName, costumerName, count);
            Console.WriteLine(myOrder01.Details(1));
            Console.WriteLine(myOrder02.Details(2));
            Console.WriteLine(myOrder03.Details(3));
            order.Seek(1);
            order.Change(2, 2, "rua");
            order.Delete(1);
            Console.WriteLine(myOrder01.Details(1));
            order.FoundVIP();
            */
        }
    }
}
