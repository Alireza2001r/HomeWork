// Writter Alireza Rakkhodapour
public class Node
{
    public int data;
    public Node left, right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

public class BinaryTree
{
    Node root;
    int count = 0;
    public Node insertLevelOrder(int[] arr, Node root, int i)
    {
        if (i < arr.Length)
        {
            Node temp = new Node(arr[i]);
            root = temp;

            root.left = insertLevelOrder(arr, root.left, 2 * i + 1);

            root.right = insertLevelOrder(arr, root.right, 2 * i + 2);
        }
        return root;
    }

    public void inOrder(Node root)
    {
        if (root != null)
        {
            inOrder(root.left);
            Console.Write(root.data + " ");
            count++;
            if (count % 10 == 0)
            {
                Console.WriteLine();
            }
            inOrder(root.right);
        }
    }

    public static void Main()
    {
        BinaryTree t2 = new BinaryTree();
        int[] arr = { 3, 1, 4, 1, 123, 35, 4535, 6, 5, 32 };
        t2.root = t2.insertLevelOrder(arr, t2.root, 0);
        t2.inOrder(t2.root);
    }
}