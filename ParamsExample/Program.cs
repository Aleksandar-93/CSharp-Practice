namespace ParamsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";


            Console.WriteLine("Price is {0}, pi is {1}, at is {2}",32,3.14,'@');
            Console.WriteLine("{0}+{1}+{2}={3}",1,2,3,1+2+3);
            Console.WriteLine("///////////////////////////////////////////////////////");

            ParamsMethod("This", "is", "a", "long", "string", "I", "have", "no", "idea", "when", "it's", "going", "to", "end",".....");
            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("hello", 5.3, '$');

        }

        public static void ParamsMethod(params string[] sentance)
        {
            for (int i = 0; i < sentance.Length; i++)
            {
                Console.Write(sentance[i] + " ");
            }
            Console.WriteLine();

        }
        public static void ParamsMethod2(params object[] stuff)
            {
                foreach(object obj in stuff)
                {
                    Console.Write(obj + " ");
                }

        }

    }
}