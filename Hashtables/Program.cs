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

            Student storedStudent1 = (Student)studentsTable[1];

            Console.WriteLine("Student ID:{0}, Name:{1}, GPA{2}", storedStudent1.id, storedStudent1.name, storedStudent1.GPA);
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