namespace BynaryTree
{
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

        public bool IsEmpty()
        {
            return Root is null;
        }

        public void PrintElementsSorted()
        {
            
            
        }
    }
}