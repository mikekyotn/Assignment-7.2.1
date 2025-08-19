using System.Text.Json.Serialization;

namespace Assignment_7._2._1
{
    //Conduct Shell sort from a user defined array
    //Status: Complete
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] test = { 3, 5, 8, 9, 6, 2 };
            //PrintArray(test);
            //ShellSort(test);
            //PrintArray(test);            

            int[] userInput = GetUserArray();
            PrintArray(userInput);
            ShellSort(userInput);
            PrintArray(userInput);
            Console.ReadKey();
        }

        //O(n2) for shell sort
        static void ShellSort(int[] arr)
        {
            int gap = arr.Length / 2;
            int i, j;
            while (gap > 0)
            {
                i = gap;
                while ( i < arr.Length ) //prevent going beyond right limit of array
                {
                    int temp = arr[i]; //number to be placed in correct spot
                    j = i - gap; //the index of the element to compare with temp;
                    while (j >=0 && arr[j] > temp) //decide if need to do the swap
                    {
                        arr[j + gap] = arr[j]; //shift the larger element to the right
                        j -= gap; //move j back by the gap
                    }
                    arr[j + gap] = temp; //place the temp in its correct position
                    i++; //
                }
                gap /= 2; //redue the dap for the next iteration
            }
        }
        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");                
            }
            Console.WriteLine();
        }

        static int[] GetUserArray()
        {
            Console.Write("Please enter the size of your array: ");
            uint length = 0;
            while (!UInt32.TryParse(Console.ReadLine(), out length))
            {
                Console.Write("Invalid entry, please enter a positive integer: ");
            }

            int[] userArray = new int[length];            
            Console.WriteLine("Please enter the values for your array");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Element at Index {i}: ");
                while (!Int32.TryParse(Console.ReadLine(), out userArray[i]))
                {
                    Console.Write($"Invalid entry, please enter an integer at Index {i}: ");                    
                }
            }
            return userArray;
        }
    }
}
