using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        // Default Constructor
        public Customer()    
            : this(0)
        {
            
        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerType { get; set; }
        public List<Address> AddressList { get; set; }

        public static int InstanceCount { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }


        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (string.IsNullOrWhiteSpace(FirstName)) return fullName;
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    fullName += ", ";
                }

                fullName += FirstName;

                return fullName;
            }
        }


        public bool Validate()
        {
            bool isValid = !string.IsNullOrWhiteSpace(LastName);
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;

        }


    }
}
