using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // declering an ArrayList with undifined amount of object 
            ArrayList myArrayList = new ArrayList();
            // declering an ArrayList with difined amount of object 
            ArrayList myArrayList2 = new ArrayList(100);


            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            //delete element with sepcific entry form the arraylist only first 13 from list
            myArrayList.Remove(13);

            // delete element at specific position
            myArrayList.RemoveAt(0);

            //count how match object we have in array list

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }else if (obj is double)
                {
                    sum += (double)obj;
                }else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();



        }
    }
}