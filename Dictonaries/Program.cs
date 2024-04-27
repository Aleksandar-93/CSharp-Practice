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


            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);

            }
            // update Employee 
            string KeyToUpdate = "HR";
            if(employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/Key{0} was updated!", KeyToUpdate);
            }
            else
            {
                Console.WriteLine("No employe found with this key {0}", KeyToUpdate);
            }

            //Remove item from employee dictionery
            string keyToRemove = "Intern";
            if(employeesDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("Employee with Role/Key{0} was Removed!", keyToRemove);

            }
            else
            {
                Console.WriteLine("No employe found with this key {0}", keyToRemove);
            }

            for (int i = 0;i < employeesDirectory.Count; i++)
            {
                //using ElementAt(i) to return the ket-value pair stored at index i
                KeyValuePair<string,Employee> keyValuePair = employeesDirectory.ElementAt(i);
                // print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);
                //storing the calue in a employe object
                Employee employeeValue = keyValuePair.Value;
                //printing the properies of the employe object
                Console.WriteLine("Employee name: {0}",employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salery: {0}", employeeValue.Salery);

            }

            string key = "CEO";

            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory["CEO"];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salery: {2}", empl.Name, empl.Role, empl.Salery);
            }
            else
            {
                Console.WriteLine("No employee found with this key{0}", key);
            }


            Employee result = null;
            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrived!");

                Console.WriteLine("Employee name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salery: {0}", result.Salery);

            }else
            {
                Console.WriteLine("The ket does not exist");
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