using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class Bird : ILiving, IFlying
    {
        public void Eat()
        {
            Console.WriteLine("Eats small worms");
        }

        public void Fly()
        {
            Console.WriteLine("Flaps wings");
        }

        public void Land()
        {
            Console.WriteLine("Stops flapping wings");
        }

        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzz");
        }

        public void TakeOff()
        {
            Console.WriteLine("Flaps wings fast");
        }
    }
}
