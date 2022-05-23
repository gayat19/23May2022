using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    //cannot be instantiated
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eats something");
        }
        public void Move()
        {
            Console.WriteLine("All animas move");
        }
        public abstract void Look();
    }
    class Dog : Animal
    {
        public override void Look()
        {
            Console.WriteLine("Has four legs");
        }
    }
}
