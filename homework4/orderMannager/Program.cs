using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class MyException : ApplicationException
	{
		public MyException(string message):base(message)
		{

		}
	}

	class OrderService
	{
		public List<Order> list = new List<Order>();

		public OrderService()
		{
			Order order01 = new Order("01","小张","香蕉");
			list.Add(order01);
			
		}
		//添加订单
		public void InsertOrder()
		{
			Console.Write("输入商品名：");
			string friuts = Convert.ToString(Console.ReadLine());
			Console.Write("输入客户名：");
			string costumer = Convert.ToString(Console.ReadLine());

			Console.Write("输入数量:");
			int Amount = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine(sum);


			Order orderx = new Order("0" + (list.Count + 1), costumer, friuts);

			list.Add(orderx);
		}

		//查找订单
		public void FindOrder()
		{
			Console.Write("请输入查询方式（按订单号输入1、客户名2、商品名3）：");
			int x = 0;
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("请输入查询关键字：");
			string names = Convert.ToString(Console.ReadLine());
			switch (x)
			{
				case 1:
					foreach(Order s in list)
					{
						if (s.card.Contains(names))
							Console.WriteLine(s.card + " " + s.name + " " + s.series + " " );
					}
					break;
				case 2:
					foreach (Order s in list)
					{
						if (s.name .Contains(names))
							Console.WriteLine(s.card + " " + s.name + " " + s.series + " " );
					}
					break;
				case 3:
					foreach (Order s in list)
					{
						if (s.series.Contains(names))
							Console.WriteLine(s.card + " " + s.name + " " + s.series + " " );
					}
					break;
			}
		}
		
		//删除订单
		public void DelOrder()
		{
			Console.Write("请输入订单号：");
			string num = Convert.ToString(Console.ReadLine());
			bool num1 = false;
			for(int i = 0; i < list.Count; i++)
			{
				if (list[i].card == num)
					num1 = true;
			}

			if (num1 == false)
				throw new MyException("订单号不存在或者输入错误，请重新输入：");


			for (int i = 0;i<list.Count;i++)
			{
				if (list[i].card.Contains(num))
				{
					list.Remove(list[i]);
					
					Console.WriteLine("删除成功！！");

				}
			}
			
		}
		
		//修改订单
		public void ChangeOrder()
		{
			string num = "0";
			int x = 0;
			bool b = false;
			Console.Write("请输入订单号：");
			num = Convert.ToString(Console.ReadLine());
			Console.Write("请输入要修改的地方（修改订单号输入1、客户名2、商品名3）：");
			x = Convert.ToInt32(Console.ReadLine());
			
			if(x > 3 || x < 1)
			{
				throw new MyException("输入不合理！输入的值必须是1、2、3，需要重新输入：");
			}

			Console.Write("请输入更改后的值：");
			string change = Convert.ToString(Console.ReadLine());
			switch (x)
			{
				case 1:
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].card.Contains(num))
						{
							list[i].card = change;
							Console.WriteLine("修改成功！");
						}
					}
					break;
				case 2:
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].card.Contains(num))
						{
							list[i].name = change;
							Console.WriteLine("修改成功！");
						}
					}
					break;
				case 3:
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].card.Contains(num))
						{
							list[i].series = change;
							Console.WriteLine("修改成功！");
						}
					}
					break;

				default:
					Console.WriteLine("修改失败！");
					break;
			}


		}
	

	}

	class Order
	{
		public string card;
		public string name;
		public string series;
		
		public Order(string c, string n,string s)
		{
			this.card = c;
			this.name = n;
			this.series = s;
		}


		static void Main(string[] args)
		{


			
			
			
			OrderService orderService = new OrderService();

			//添加订单
			orderService.InsertOrder();

			//查找订单

			//orderService.FindOrder();

			//移除订单
			try
			{
				orderService.DelOrder();
			}
			catch (MyException e)
			{
				Console.WriteLine("MyException:{0}", e.Message);
				orderService.DelOrder();
			}
			
			//遍历订单
			Console.WriteLine("订单号 客户 品类 总价" + "\n");
			foreach(Order x in orderService.list)
			{
				Console.WriteLine(x.card + " "+ x.name + " " + x.series + " ");
			}

		}
	}

}

