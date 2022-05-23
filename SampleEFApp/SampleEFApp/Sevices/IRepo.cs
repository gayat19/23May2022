using SampleEFApp.Models;
using System.Collections.Generic;

namespace SampleEFApp.Sevices
{
    public interface IRepo
    {
        public Product Add(Product product);
        public Product Update(Product product);
        public Product Delete(int pid);
        public ICollection<Product> GetAll();
        public Product Get(int pid);
    }
}
