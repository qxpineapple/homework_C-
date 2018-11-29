using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ordertest {

    /// <summary>
    /// Order class : all orderDetails
    /// to record each goods and its quantity in this ordering
    /// </summary>
    [Serializable]
    public class Order {

        [Key]
        public string Id { get; set; }
        public Customer Customer { get; set; }
        public String CustomerName { get; set; }

        private List<OrderDetail> details=new List<OrderDetail>();


        public Order(){}
        /// <summary>
        /// Order constructor
        /// </summary>
        /// <param name="orderId">order id</param>
        /// <param name="customer">who orders goods</param>
        public Order(string orderId, Customer customer) {
            Id = orderId;
            Customer = customer;
            CustomerName = customer.Name;
        }

        /// <summary>
        /// order id
        /// </summary>
        
        public List<OrderDetail> Details {
            get =>this.details; }

        /// <summary>
        /// add new orderDetail to order
        /// </summary>
        /// <param name="orderDetail">the new orderDetail which will be added</param>
        public void AddDetails(OrderDetail orderDetail) {
            if (this.Details.Contains(orderDetail))  {
                throw new Exception($"orderDetails-{orderDetail.Id} is already existed!");
            }
            details.Add(orderDetail);
        }

        /// <summary>
        /// remove orderDetail by orderDetailId from order
        /// </summary>
        /// <param name="orderDetailId">id of the orderDetail which will be removed</param>
        /// 
        public void RemoveDetails(string orderDetailId) {
            details.RemoveAll(d =>d.Id==orderDetailId);
        }

        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>string:message of the Order object</returns>
        public override string ToString() {
            string result = "================================================================================\n";
            result += $"orderId:{Id}, customer:({Customer.Name})";
            details.ForEach(od => result += "\n\t" + od);
            result += "\n================================================================================";
            return result;
        }
    }
}
