namespace BynaryTree
{
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
}