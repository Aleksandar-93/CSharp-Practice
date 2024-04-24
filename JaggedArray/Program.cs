namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare jaggedArray
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 2, 3, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 11, 12 };

            // altrenative way:
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 2, 3, 7, 11 },
                new int[] { 1, 2, 3 }
            };

            Console.WriteLine("The value in the middel of the first entry is {0}", jaggedArray2[0][2]);

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("{0}", jaggedArray2[i][j]);
                }
            }
            Console.WriteLine("////////////////////////////////////");

            int[][] triangle = new int[][]
            {
                new int[] {1},
                new int[] {2,3},
                new int[] {4,5,6},
                new int[] {7,8,9,10},
            };

            //for each loop to print each row of the triangle
            foreach(int [] row  in triangle)
            {
                foreach (int number in row)
                {
                    Console.WriteLine(number);
                }
            }


            Console.WriteLine("////////////////////////////////////////////////");

            string[][] friendsAndAFamily = new string[][]
            {
                new string[] {"Michael","Sandy"},
                new string[] {"Frank","Claudia"},
                new string[] {"Andrew","Michelle"},
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndAFamily[0][0], friendsAndAFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndAFamily[0][1], friendsAndAFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndAFamily[0][1], friendsAndAFamily[2][1]);




            Console.ReadKey();


        }
    }
}