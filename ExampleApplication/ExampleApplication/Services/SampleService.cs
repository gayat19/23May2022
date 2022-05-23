using System;

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
    }
}
