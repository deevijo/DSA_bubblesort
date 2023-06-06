using System;

namespace DSA_bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] inputArray = new int[] { 2,5,8,3,9,4,1};
            // int[] inputArray = new int[] { 3,0,2,5,-1,4,1};
            int[] inputArray = new int[] { 99, 98, 97, 96, 95, 94, -1 };
            classic_bubblesort(ref inputArray);
            for (int i = 0; i < inputArray.Length; i++)
            {
              Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine();

            bubblesort_but_better(ref inputArray);
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
        }

        static void classic_bubblesort(ref int[] inputArray)
        {         
            int t;
            for (int p = 0; p <= inputArray.Length - 2; p++)
            {
                for (int i = 0; i <= inputArray.Length - 2; i++)
                {
                    if (inputArray[i] > inputArray[i + 1])
                    {
                        t = inputArray[i + 1];
                        inputArray[i + 1] = inputArray[i];
                        inputArray[i] = t;
                    }
                    Console.Write(" j: " + i);
                }
                Console.WriteLine(" i: " + p);

            }
        }

        static void bubblesort_but_better(ref int[] inputArray)
        {
            for (int i = 1; i <= inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length - i; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                        swap(ref inputArray[j], ref inputArray[j + 1]);

                    Console.Write(" j: " + j);
                }
                Console.WriteLine(" i: " + i);
            }

            Console.WriteLine();
        }

        static void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
}
