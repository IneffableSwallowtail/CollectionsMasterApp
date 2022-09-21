using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CollectionsMasterConsoleUI
{
    internal class Methods
    {
        public static int[] AssignRandom(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, array.Length);
            }
            return array;
        }
        public static List<int> AssignRandom(List<int> randomInts)
        {
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                randomInts.Add(rnd.Next(1, 49));
            }
            return randomInts;
        }
        public static void PrintReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[0]);
        }
        public static void ArrayPrint(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[array.Length - 1]);
        }
        public static void ListPrint(List<int> items)
        {
            if (items.Count > 0)
            {
                for (int i = 0; i < (items.Count - 1); i++)
                {
                    Console.Write($"{items[i]}, ");
                }
                Console.WriteLine(items[items.Count - 1]);
            }
        }
        public static void ThreesToZero(int[] array)
        {
            for (int i = 0; i < 50; i++)
            {
                array[i] = (array[i] % 3 == 0) ? 0 : array[i];
                if (i < 49) Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[array.Length - 1]);
        }
        public static void PrintIfPresent(int i, List<int> items)
        {
            bool hasValue = items.Contains(i);
            if (hasValue == true)
                ListPrint(items);
        }
        public static void Evens(List<int> integers)
        {
            for (int i = 0; i < integers.Count; i++)
            {
                int num = integers[i];
                if (num % 2 == 1)
                {
                    integers.Remove(num);
                    i--;
                }
            }
            ListPrint(integers);
        }
    }
}
