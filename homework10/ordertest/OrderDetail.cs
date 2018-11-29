using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ordertest {

    /// <summary>
    /// OrderDetail class : a entry of an order object
    /// to record the goods and its quantity
    /// </summary>
    public class OrderDetail {

        [Key]
        public string Id { get; set; }
        public string GoodsName { get; set; }
        public Goods Goods { get; set; }
        public double Quantity { get; set; }

        public OrderDetail()
        {

        }
        /// <summary>
        /// OrderDetail constructor
        /// </summary>
        /// <param name="id">orderDetail's id</param>
        /// <param name="goods">orderDetail's goods</param>
        /// <param name="quantity">goods quantity</param>
        public OrderDetail(string id, Goods goods, double quantity) {
            this.Id = id;
            this.Goods = goods;
            this.Quantity = quantity;
            this.GoodsName = goods.Name;
        }


        public override int GetHashCode()
        {

            var hashCode = 1522631281;
            String gname=Goods==null?"":(Goods.Name==null?"": Goods.Name);
            hashCode = hashCode * -1521134295 + gname.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>string:message of the OrderDetail object</returns>
        public override string ToString() {
            string result = "";
            result += $"orderDetailId:{Id}:  ";
            result += Goods + $", quantity:{Quantity}"; 
            return result;
        }


    }
}
