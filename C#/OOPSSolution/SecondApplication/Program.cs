using System;

namespace SecondApplication
{
    class Program
    {
        public int solution(int N)
        {
            string bits = Convert.ToString(N, 2);
            int count = 0;
            int result = 0;
            int cont = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '0')
                {
                    if (cont > 0) cont++;
                    else cont = 1;
                }
                else cont = 0;
                if (cont > count) count = cont;
                if (bits[i] == '1' && count > result)
                    result = count;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
      
            Console.WriteLine(program.solution(15));
            
            //Employee employee1 = new Employee(101,"Ramu");
            //Employee employee2 = new Employee(102, "Somu", 33);
            //Employee employee3 = new Employee("Bimu", 103);
            //employee1[0] = "C";
            //employee1[1] = "Java";
            //employee1[2] = "C#";
            //Console.WriteLine("The skill position of c# is "+employee1["C#"]);
            //employee1.PrintEmployeeDetails();
            //employee2.PrintEmployeeDetails();
            //employee3.PrintEmployeeDetails();
            //employee1.DoWork();
            //employee2.DoWork("Everything");
            //Employee employee4 = employee1 + employee2;
            //employee4.PrintEmployeeDetails();
            ////employee1.Id = 101;
            ////employee1.Name = "Ramu";
            ////employee1.Age = 21;
            ////employee1.PrintEmployeeDetails();
            ////employee1.WorkingHours = 4;
            ////employee1.DoWork();
            ////Employee employee2 = employee1;
            ////employee2.Id = 102;
            ////employee2.Name = "Bimu";
            ////employee2.Age = 35;
            ////employee2.PrintEmployeeDetails();
            ////employee2.DoWork();
            //Employee employee = new Employee(101,"Ramu",23);
            //employee.Sample();
            //Console.WriteLine(employee.ToString());
            //Animal animal = new Dog();
            //animal.Eat();
            //animal.Move();
            //animal.Look();
            //Bird bird = new Bird();
            //Program program = new Program();
            //program.SkyWatch(bird);
            //program.ForestLife(bird);
            //Console.ReadKey();
        }
        void SkyWatch(IFlying flying)
        {
            flying.TakeOff();
            flying.Fly();
            flying.Land();
        }
        void ForestLife(ILiving live)
        {
            live.Eat();
            live.Sleep();
        }
    }
}
