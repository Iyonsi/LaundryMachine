using System;

namespace LaundryMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WashSock(2,  new int[4] { 1, 2, 1, 1}, new int[5] { 1, 4, 3, 2, 4 }));
        }

        public static int WashSock(int noOfWashes, int[] cleanPile, int[] dirtyPile)
        {
            var evenCount = 0;
            var oddCount = 0;
            var maximumEvenCountPair = 0;
            var maximumOddCountPair = 0;
            if (noOfWashes == 0)
            {
                foreach (var sock in cleanPile)
                {
                    if(sock % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }

                if (evenCount % 2 == 0)
                {
                    maximumEvenCountPair = evenCount / 2;
                }
                else
                {
                    maximumEvenCountPair = (evenCount - 1) / 2;
                }

                if (oddCount % 2 == 0)
                {
                    maximumOddCountPair = oddCount / 2;
                }
                else
                {
                    maximumOddCountPair = (oddCount - 1) / 2;
                }
            }
           else if(noOfWashes > 0)
            {
                for (int i = 0; i < noOfWashes; i++)
                {
                    if(dirtyPile[i] % 2 == 0)
                    {
                        evenCount++;
                    }
                    else { oddCount++; }
                }

                foreach (var sock in cleanPile)
                {
                    if (sock % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }

                if(evenCount % 2 == 0)
                {
                    maximumEvenCountPair = evenCount / 2;
                }
                else
                {
                    maximumEvenCountPair = (evenCount - 1) / 2;
                }

                if (oddCount % 2 == 0)
                {
                    maximumOddCountPair = oddCount / 2;
                }
                else
                {
                    maximumOddCountPair = (oddCount - 1) / 2;
                }
            }
            int maximumPairs = maximumEvenCountPair + maximumOddCountPair;
            return maximumPairs;
        }
    }
}
