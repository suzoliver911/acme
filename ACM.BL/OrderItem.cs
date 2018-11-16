using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public  class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the defined order item
            return new OrderItem();
        }


        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }

        public bool Validate()
        {
            bool isValid = (OrderQuantity > 0);

            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;

        }

    }
}
