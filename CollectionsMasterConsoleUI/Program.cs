using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] _50Random = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            _50Random = Methods.AssignRandom(_50Random);

            //TODO: Print the first number of the array
            Console.WriteLine($"First number in random array: {_50Random[0]}");

            //TODO: Print the last number of the array
            Console.WriteLine($"Last number in random array: {_50Random[_50Random.Length - 1]}");

            Console.WriteLine("All Numbers Original:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(_50Random);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Array.Reverse(_50Random);
            Console.WriteLine("All Numbers Reversed:");
            Methods.ArrayPrint(_50Random);
            Array.Reverse(_50Random); //returning the array to its original order - AJ

            Console.WriteLine("---------REVERSE CUSTOM------------");
            Methods.PrintReverseArray(_50Random);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            int[] noThrees = new int[50];
            Array.Copy(_50Random, noThrees, 50);
            Methods.ThreesToZero(noThrees);
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(_50Random);

            Console.WriteLine("Sorted numbers: ");
            Methods.ArrayPrint(_50Random);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> integers = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Capacity of integers list: {integers.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Methods.AssignRandom(integers);

            //TODO: Print the new capacity
            Console.WriteLine($"The new capacity for the integers list is {integers.Capacity}.");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("Search for a number between (and excluding) 0 and 50.");
            Console.WriteLine($"What number will you search for in the number list?");
            bool cont = false;
            while (true)
            {
                int searchKey = 0;
                try
                {
                    searchKey = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                }
                if (searchKey > 0 && searchKey < 50)
                    break;
                else
                    Console.WriteLine("Invalid selection");
            }
            //Methods.PrintIfPresent(searchKey, integers);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Methods.ListPrint(integers);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            Methods.Evens(integers);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            integers.Sort();
            Methods.ListPrint(integers);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] ints = integers.ToArray();

            //TODO: Clear the list
            integers.Clear();


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
