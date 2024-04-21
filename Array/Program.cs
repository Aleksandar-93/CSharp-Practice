namespace Array
{

    class Program
    {

        static void Main(string[] args)
        {
            // declare and initilize array grades
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 22;

            Console.WriteLine("grades at index 0: {0}",grades[0]);
           

            string input = Console.ReadLine();
            // assign value to array  grades at index 0
            grades[0] = int.Parse(input); 
            Console.WriteLine("grades at index 0: {0}", grades[0]);

            // another way of initializing an array
            int[] gradesOfMathStudentsA = {20,13,12,8,9,10};

            // thrid way of initiakizing an array
            int[] gradesOfMathStudentsB = new int[] {20,13,12,8,10};

            Console.WriteLine("Lenght of gradeOfMathStudnesA: {0}", gradesOfMathStudentsA.Length); 
            Console.ReadLine() ;






        }



    }




}