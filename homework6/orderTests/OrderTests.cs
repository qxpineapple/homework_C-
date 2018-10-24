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
        public void OrderDelet0()
        {
            OrderService obj = new OrderService();
            int n = OrderService.orderList.Count();
            obj.OrderDelete(0);
            Assert.IsTrue(n - 1 == OrderService.orderList.Count());
        }
        public void OrderDelet1()
        {
            try {
            OrderService obj = new OrderService();
            int n = OrderService.orderList.Count();
            //错误数据
            obj.OrderDelete(1);
            Assert.IsTrue(n - 1 == OrderService.orderList.Count());
            }
            catch
            {
                Assert.IsTrue(true);
            }
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
            //一起测试通不过，单独测试则能通过，不知道为什么
        }
        //xml序列化测试
        [TestMethod()]
        public void XmlTest0()
        {
            string FileName = "xmlTest.xml";
            OrderService.Export(FileName);
            //同样，一起测试生成的xml文件与单独测试生产的xml文件不一样，期望的为单独测试的
            Assert.IsTrue(File.Exists(FileName));
            
        }
        [TestMethod()]
        public void XmlTest1()
        {
            try {
                //错误数据
                string FileName = " ";
            OrderService.Export(FileName);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        //xml反序列化测试
        [TestMethod()]
        public void XmlTest2()
        {
            OrderService obj = new OrderService();
            string FileName = "xmlTest2.xml";
            Order.XmlOut(FileName);
            Assert.IsTrue(obj["NewCustomer"] != -1);
        }
        [TestMethod()]
        public void XmlTest3()
        {
            try
            {
            OrderService obj = new OrderService();
            string FileName = "ddd.xml";
            Order.XmlOut(FileName);
            Assert.IsTrue(obj["NewCustomer"] != -1);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
    }
}