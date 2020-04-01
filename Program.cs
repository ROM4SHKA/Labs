using System;
using System.Collections.Generic;
namespace Lab_4
{
  public   abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int YearofWork { get; set; }
        public string Position { get; set; } 
        public Employee(string name, int age,int salary, int years)
        {
            Name = name;
            Age = age;
            Salary = salary;
            YearofWork = years;
        }
        public virtual void Display() 
        {
            Console.WriteLine($"Name:{Name},Age:{Age},Salary{Salary},years{YearofWork},Position:{Position}");
        }
    }
    public class Boss : Employee
    {
        public Boss(string name, int age, int salary, int years) : base(name, age, salary, years) { Position = "Boss"; }
      
    }
    public class Manager : Employee
    {
        public List<Employee> rabotnics = new List<Employee>();
        public Manager(string name, int age, int salary, int years) : base(name, age, salary, years) { Position = "Manager"; }
        public void AddRabotnic(Employee e)
        {
            if(e.Position!="Boss"&&e.Position!=Position)
            rabotnics.Add(e);
        }
        public int CountRabotiag()
        {
            int sum = 0;
            foreach(var i in rabotnics)
            {
                sum++;
            }
            return sum;
        }
        public override void Display()
        {
            base.Display();

        }
    }
    public class Ingeneer : Employee
    {
        public int RestDay { get; set; }
        public Ingeneer(string name, int age, int salary, int years) : base(name, age, salary, years) { Position = "Ingeneer";RestDay = 66; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Кількість вихідних у інженера :{66}");
        }    
    }
    public class Mech:Employee
    {
        public Mech(string name, int age, int salary, int years) : base(name, age, salary, years) { Position = "Mech";  }
    }
    public class IngeneerArh : Employee 
    { 
        public IngeneerArh(string name, int age, int salary, int years) : base(name, age, salary, years) { Position = "IngeneerArh"; }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Employee boss = new Boss("Tom", 48, 2400, 15);
           Manager manager = new Manager("Bob", 23, 1800, 12);
            Manager manager1 = new Manager("Roman", 14, 7271, 218);
            Employee ingeneer = new Ingeneer("Anna", 18, 1200, 3);
            Employee mech = new Mech("Taras", 40, 1000, 46);
            Employee ing = new IngeneerArh("Vasya", 25, 78, 1);
            boss.Display();
            manager.Display();
            ingeneer.Display();
            mech.Display();
            Console.WriteLine();
            manager.AddRabotnic(ingeneer);
            manager.AddRabotnic(mech);
            manager.AddRabotnic(boss);
            manager.AddRabotnic(ing);
            manager.AddRabotnic(manager1);
            Console.WriteLine(manager.CountRabotiag());
            Console.ReadKey();
        }
    }
}
