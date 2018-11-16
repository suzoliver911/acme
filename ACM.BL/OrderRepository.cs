using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2018, 11, 16, 2, 11, 32, new TimeSpan(1,0,0));
            }

            return order;
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }
    }
}