using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }


        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = !string.IsNullOrWhiteSpace(ProductName);
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
