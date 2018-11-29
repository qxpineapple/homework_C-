using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ordertest
{
    class OrderDB:DbContext
    {
        public OrderDB() : base("OrderDataBase") { }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Customer> Customer { get;set; }
    }
}
