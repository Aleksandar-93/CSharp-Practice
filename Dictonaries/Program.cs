using System;
using Dictonaries;

namespace Dictonaries
{
    class Program
    {

        //Key - value
        // Auto - car

        static void Main(string[] args)
        {

            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95,200),
                new Employee("Manager", "Joe", 35,25),
                new Employee("HR", "Lora", 32,21),
                new Employee("Secetery", "Petra", 28,18),
                new Employee("Lead Devoloper", "Artorias", 55,35),
                new Employee("Intern", "Ernest", 22,8),
            };


            // key will be of type int and value string
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();


            Dictionary<string,Employee> employeesDirectory = new Dictionary<string, Employee>();
           
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);

            }

            string key = "CEO";

            if(employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory["CEO"];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salery: {2}", empl.Name, empl.Role, empl.Salery);
            }
            else
            {
                Console.WriteLine("No employee found with this key{0}", key);
            }

            

        }
    }

    class Employee
    {
        // few properties like Role name, age and rate
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        // Yearly salery = rate/h

        public float Salery
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // Simple constructor 
        public Employee(string role, string name, int age,float Rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = Rate;
        }
    }




}