namespace Array
{

    class Program
    {

        static void Main(string[] args)
        {
            string[] myFriends = { "pera", "mika", "laza", "zika", "zoka" };

            foreach (string friend in myFriends)
            {
                Console.WriteLine("Hi there {0}, my friend", friend);
            }

            Console.ReadKey();


        }



    }




}