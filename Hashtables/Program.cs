using System;
using System.Collections;
namespace Hashtables
{
    class Program
    {
        //Key - value

        static void Main(string[] args)
        {
            
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.id, stud1);
            studentsTable.Add(stud2.id, stud2);
            studentsTable.Add(stud3.id, stud3);
            studentsTable.Add(stud4.id, stud4);

            // retrive invidual item wihh known ID
            Student storedStudent1 = (Student)studentsTable[1];

            // retrive all value from hashtable
            foreach(DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID: {0}",temp.id);
                Console.WriteLine("Student Name: {0}", temp.name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);

            }
            Console.WriteLine("/////////////////");
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}", value.id);
                Console.WriteLine("Student Name: {0}", value.name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }

            Console.WriteLine("Student ID:{0}, Name:{1}, GPA{2}", storedStudent1.id, storedStudent1.name, storedStudent1.GPA);

            Console.WriteLine("--------------------CHallnge------------------");

            Hashtable table = new Hashtable();


            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(3, "Ragnar", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(5, "Levi", 58);

            foreach(Student s in students)
            {
                if (!table.ContainsKey(s.id))
                {
                    table.Add(s.id, s);
                    Console.WriteLine("Student wutg ID{0} was Added!", s.id);
                }
                else
                {
                    Console.WriteLine("Sorry, a student with the same ID alredy exist ID:{0}",s.id);
                }
            }

        }
    }

    class Student
    {
        // orioery called id 
        public int id { get; set; }
        //property called name
        public string name { get; set; }
        //property called GPA
        public float GPA { get; set; }

        // simple constructor

        public Student(int id, string name, float GPA) {
            this.id = id;
            this.name = name;
            this.GPA = GPA;
        }
    }
}