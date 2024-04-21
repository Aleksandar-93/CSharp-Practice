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

            Console.ReadKey();
        }



    }




}