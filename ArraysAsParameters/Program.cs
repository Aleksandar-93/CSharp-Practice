namespace ArraysAsParameters
{

    class Program
    {

        static void Main(string[] args)
        {
            int[] stundentsGrade = new int[] { 15, 13, 8, 12, 6, 16 };
            double avrageResult = GetAvrage(stundentsGrade);

            int[] happiness = { 2, 3, 4, 5, 6 };
            SunIsShining(happiness);

            foreach (int i in happiness)
            {
                Console.WriteLine(i);
            }

            foreach(int grade in stundentsGrade)
            {
                Console.WriteLine("{0}",grade);
            }

            Console.WriteLine("The avvrage is : {0}",avrageResult);
            Console.ReadKey();


        }

        static double GetAvrage(int[] gradsArray)
        {
            int size = gradsArray.Length;
            double avrage;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradsArray[i];
            }

            avrage = (double)sum / size;
            return avrage;


        }

        static void SunIsShining(int[] x)
        {
            for(int i = 0;i < x.Length;i++)
            {
                x[i] += 2;
            }
        }



    }




}