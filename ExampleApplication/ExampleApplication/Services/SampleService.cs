using System;
using System.Collections.Generic;

namespace ExampleApplication.Services
{
    public class SampleService : ISample
    {
        public bool CheckNumber(int number)
        {
            checked
            {
                number++;
            }
           if(number%2==0)
                return true;
           return false;
        }

        public ICollection<string> GetNames()
        {
            List<string> names = new List<string>();
            names.Add("Ramu");
            return names;
        }
    }
}
