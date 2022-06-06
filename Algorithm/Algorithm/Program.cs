using System;

namespace Algorithm
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1: For Insertion Sort");
            Console.WriteLine("2: For Bubble Sort");
            Console.WriteLine("3: For Anagram");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {

                case 1:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.Insert();
                    Console.WriteLine();
                    break;
                case 2:
                    BubbleSort bubblesort = new BubbleSort();
                    bubblesort.Bubblesort();
                    Console.WriteLine();
                    break;
                case 3:
                    Anagram anagram = new Anagram();
                    anagram.Anagrams();
                    break;
                default:
                    Console.WriteLine("Number is Invalid");
                    break;
            }
        }

    }
}