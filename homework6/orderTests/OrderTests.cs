using Microsoft.VisualStudio.TestTools.UnitTesting;
using order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace order.Tests
{
    [TestClass()]
    public class OrderTests
    {
        Order order = new Order("Customer", "Item", 3);
        //删除测试
        [TestMethod()]
        public void OrderDelet()
        {
            OrderService obj = new OrderService();
            int n = OrderService.orderList.Count();
            obj.OrderDelete(0);
            Assert.IsTrue(n - 1 == OrderService.orderList.Count());
        }
        //改变数据测试
        [TestMethod()]
        public void ChangeTest0()
        {
            OrderService obj = new OrderService();
        }
        [TestMethod()]
        public void ChangeTest1()
        {
            OrderService obj = new OrderService();
        }
        //增加测试
        [TestMethod()]
        public void InsertOrderTest0()
        {
            OrderService obj = new OrderService();
            OrderDetails newobj = new OrderDetails("NewCustomer", "NewItem", 4);
            int n = OrderService.orderList.Count();
            obj.InsertOrder(newobj);
            Assert.IsTrue(n == OrderService.orderList.Count() - 1);
        }
        [TestMethod()]
        public void InsertOrderTest1()
        {
            OrderService obj = new OrderService();
            OrderDetails newobj = new OrderDetails();
            int n = OrderService.orderList.Count();
            obj.InsertOrder(newobj);
            Assert.IsTrue(n == OrderService.orderList.Count() - 1);
        }
        //查找测试
        [TestMethod()]
        public void SeekTest()
        {
            OrderService obj = new OrderService();
            int n0 = obj[1];
            int n1 = obj["Customer"];
            int n2 = obj["Item"];
            Assert.IsFalse(n0 == -1 && n1 == -1 && n2 == -1);
        }
        [TestMethod()]
        public void FalseSeekTest()
        {
            OrderService obj = new OrderService();
            //错误数据
            int n0 = obj[2];
            int n1 = obj[" "];
            int n2 = obj[" "];
            Assert.IsTrue(n0 == -1);
            Assert.IsTrue(n1 == -1);
            Assert.IsTrue(n2 == -1);
        }
        //xml序列化测试
        [TestMethod()]
        public void XmlTest0()
        {
            string FileName = "xmlTest.xml";
            OrderService.Export(FileName);
            Assert.IsTrue(File.Exists(FileName));
            
        }
    }
}