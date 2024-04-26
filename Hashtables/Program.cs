namespace Hashtables
{
    class Program
    {
        //Key - value

        static void Main(string[] args)
        {


            
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