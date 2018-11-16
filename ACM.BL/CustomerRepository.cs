using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        
        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        /// <summary>
        /// Retrieves all customers.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }


        /// <summary>
        /// Save the customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }
    }
}