using System;

namespace bynary_tree
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



    public class Node
    {
        public Node(int data)
        {
            Data = data;
        }

        public Node Left { get; private set; }
        public Node Right { get; private set; }
        public int Data { get; private set; }

        public void SetRight(Node node)
        {
            Right = node;
        }

        public void SetLeft(Node node)
        {
            Left = node;
        }
    }

    public class Tree
    {
        public Node Root { get; private set; }

        public void Insert(int data)
        {

            if (Root is null)
            {
                Root = new Node(data);
            }
            else
            {
                Node current = Root;
                while (true)
                {
                    if (data >= current.Data)
                    {
                        if (current.Right is null)
                        {
                            current.SetRight(new Node(data));
                            return;
                        }
                        else
                        {
                            current = current.Right;
                        }
                    }
                    else
                    {
                        if (current.Left is null)
                        {
                            current.SetLeft(new Node(data));
                            return;
                        }
                        else
                        {
                            current = current.Left;
                        }
                    }
                }
            }
        }
    }
}
