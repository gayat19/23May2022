using SampleEFApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SampleEFApp.Sevices
{
    public class ProductRepo : IRepo
    {
        static List<Product> products = new List<Product>()
        {
            new Product(101,"Pencil",5,20)
        };
        public Product Add(Product product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Equals(product))
                {
                    return null;
                }
            }
           products.Add(product);
            return product;
        }

        public Product Delete(int pid)
        {
            var product = Get(pid);
            if(products.Remove(product))
                return product;
            return null;
        }

        public Product Get(int pid)
        {
            var product = products.FirstOrDefault(p => p.Id == pid);
            return product;
        }

        public ICollection<Product> GetAll()
        {
            if (products.Count == 0)
                return null;
            return products;
        }

        public Product Update(Product product)
        {
            var prod = Get(product.Id);
            if (prod != null)
            {
                prod.Name = product.Name;
                prod.Price = product.Price;
                prod.Quantity = product.Quantity;
                return product;
            }
            return null;
        }
    }
}
