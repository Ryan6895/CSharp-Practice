using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        ///summary
        ///retrieve one order.
        ///summary
        
        public Order Retrieve(int orderId)
        {
            //Code that retrieves the defined order
            return new Order();
        }

        /// summary
        /// saves the current order.
        /// summart
        /// returns
        
        public bool Save()
        {
            //code that saves the defined order
            return true;
        }

        ///summary 
        ///Validates the order data
        ///summary
        ///returns

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}