namespace Array
{

    class Program
    {

        static void Main(string[] args)
        {
            //declare 2D Arrey
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            //two dimensial array
            int[,] array2D = new int[,]
            {
                {1,2,3,}, 
                {4,5,6,},
                {5,6,7,}
            };

            Console.WriteLine("Centaral value is {0}", array2D[1,1]);
            Console.WriteLine("Centaral value is {0}", array2D[2,2]);


            //3D array
            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001"},
                    {"010","011"},
                    {"Hi there","What's up"}
                },
                {
                    {"100","101"},
                    {"110","111"},
                    {"Another one","last entry"}

                }
            };

            Console.WriteLine("Centaral value is {0}", array3D[0,2,0]);


            string[,] array2DString = new string[3, 2] { 
                { "one", "two" }, 
                { "three", "four" }, 
                { "five", "six" } 
            };

            array2DString[1, 1] = "chicken";
            Console.WriteLine("i change four to {0}", array2DString[1, 1]);


            int dimensions = array2DString.Rank;
            Console.WriteLine("value is {0}", dimensions);

            int[,] array2D2 = { { 1, 2 }, { 2, 3 }, };


            Console.ReadKey();

        }



    }




}