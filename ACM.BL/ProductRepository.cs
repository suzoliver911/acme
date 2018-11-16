using System.Collections.Generic;
using System.Net.Http.Headers;

namespace ACM.BL
{
    public class ProductRepository
    {
        
        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }
        

        /// <summary>
        /// Retrieve all products
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            // Code that retrieves a list of products
            return new List<Product>();
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined product
            return true;
        }
    }
}