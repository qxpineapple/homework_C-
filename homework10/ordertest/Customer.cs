﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ordertest
{
    /// <summary>
    /// Customer the man who orders goods.
    /// </summary>
    public class Customer {

        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public Customer() { }

        /// <summary>
        /// Customer constructor
        /// </summary>
        /// <param name="id">customer id</param>
        /// <param name="name">customer name </param>
        public Customer(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>string:message of the Customer object</returns>
        public override string ToString()
        {
            return Name;
        }


    }
}
