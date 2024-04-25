namespace ParamsExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //int min = MinV2(6, 4, 2, 8, 0, 1, 5); // here we passed 7 values
            int min = MinV2(5, 1, 0, -11, 40); //same method but this time 5 values

            Console.WriteLine("The minimum is :{0} ", min);

        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;

        }


    }
}