using System.Collections.Generic;

namespace ExampleApplication.Services
{
    public interface ISample
    {
        public bool CheckNumber(int number);
        public ICollection<string> GetNames();
    }
}
