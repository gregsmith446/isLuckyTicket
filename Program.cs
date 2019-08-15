using System;

namespace isLuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm run = new Algorithm();

            bool answer = run.IsLucky(123456);

            // expected answer "false"
            Console.WriteLine(answer);
        }

        class Algorithm
        {
            public bool IsLucky(int n)
            {
                // find length
                int arrayLength = n.ToString().Length;

                // create arr of that length
                int[] arr = new int[arrayLength];

                int firstHalf = 0;
                int secondHalf = 0;
                bool lucky = true;

                // loop through given integer and convert into an array of integers
                for (int i = 0; i < arrayLength; i++)
                {
                    arr[i] = int.Parse(n.ToString().Substring(i, 1));
                }

                // loop through first half of int arr + add up total
                for (int i = 0; i < arrayLength / 2; i++)
                {
                    firstHalf = arr[i] + firstHalf;
                }

                Console.WriteLine(firstHalf);

                // loop through second half int arr + add up total
                for (int i = arrayLength / 2; i < arrayLength; i++)
                {
                    secondHalf = arr[i] + secondHalf;
                }

                Console.WriteLine(secondHalf);

                // compare
                if (firstHalf == secondHalf)
                {
                    lucky = true;
                }
                else
                {
                    lucky = false;
                }

                return lucky;
            }
        }
    }
}
