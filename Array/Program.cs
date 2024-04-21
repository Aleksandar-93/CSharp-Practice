namespace Array
{

    class Program
    {

        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 10;

            }

            for(int j = 0; j < nums.Length; j++)
            {
                nums[j] = j + 10;
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
                counter++;

            }


            Console.ReadKey();

            






        }



    }




}