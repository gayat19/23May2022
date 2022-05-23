using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class Employee
    {
        
        string[] skill = new string[3];
        public string this[int index]
        {
            get { return skill[index]; }
            set { skill[index] = value; }
        }
        public int this[string name]
        {
            get {
                int idx = -1;
                for (int i = 0; i < skill.Length; i++)
                {
                    if (skill[i] == name)
                        idx = i;
                }
                return idx;
            }
        }
        public Employee()
        {
            Console.WriteLine("Employee created");
            Id = 100;
            Name = "Nothing";
            Age = 18;
        }
        public Employee(int id,string name,int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;

        }
        public Employee( string name,int id)
        {
            Id = id;
            Name = name;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void DoWork()
        {
            Console.WriteLine(Name+" Does the work ");
        }
        public void DoWork(string work)
        {
            Console.WriteLine(Name + " Does the work named "+work);
        }
        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee ID "+Id);
            Console.WriteLine("Employee Name "+Name);
            Console.WriteLine("Employee Age "+Age);
            foreach (var item in skill)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");
        }
        public static Employee operator+(Employee e1,Employee e2)
        {
            Employee employee = new Employee();
            employee.Id = e1.Id + e2.Id;
            employee.Name = e1.Name + " " + e2.Name;
            employee.Age = e1.Age + e2.Age;
            return employee;
        }
        public virtual void Sample()
        {
            Console.WriteLine("Sample from employee class");
        }
        public override string ToString()
        {
            return "ID " + Id + "\nName " + Name + "\nAge " + Age;
        }
    }
}
