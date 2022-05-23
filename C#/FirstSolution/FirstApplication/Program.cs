using System;

namespace FirstApplication
{
    class Program
    {
        int Number1, Number2;//instance variable
        static int SNumber1;
        void IncrementNumbers()
        {
            Number1++;
            SNumber1++;
        }
        void PrintNumebers()
        {
            Console.WriteLine("The instance number is "+Number1);
            Console.WriteLine("The static number is " + SNumber1);
        }
        int TakeNumberFromUser()//instance method
        {
            Console.WriteLine("PLease enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        void Add()//instance method
        {
            Number1 = TakeNumberFromUser();
            Number2 = TakeNumberFromUser();
            int sum = Number1 + Number2;
            Console.WriteLine("The sum of {0} and {1} is {2}",Number1,Number2,sum);
        }
        static void Main(string[] args)
        {
            //Program program = new Program();//Creation of instance and refferencing it
            //program.Add();
            Program p1, p2;
            p1 = new Program();
            p2 = new Program();
            p1.IncrementNumbers();
            p1.PrintNumebers();
            p2.IncrementNumbers();
            p2.PrintNumebers();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
