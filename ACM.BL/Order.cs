using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {

        public Order()
        {
            
        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        
        // Use DateTimeOffset when used in multiple timezones 
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> orderItems { get; set; }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = !(OrderDate == null);

            return isValid;

        }
    }
}
