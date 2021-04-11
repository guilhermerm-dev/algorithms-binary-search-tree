using System;

namespace BynaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] items = { 6, 3, 9, 1, 5, 7, 11 };
            // int[] items = { 34, 84, 15, 0, 2, 99, 79, 9, 88, 89, 18, 31, 39, 100, 101 };
            Tree tree = new Tree();
            foreach (var item in items)
            {
                tree.Insert(item);
            }
            Console.ReadKey();
        }
    }    
}