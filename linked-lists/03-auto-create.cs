public class Node
{
    public int val;
    public Node? next;
    public Node(int val = 0)
    {
        this.val = val;
        //this.next = null;
    }
}


public class Solution
{
    static Node? CreateList(int[] list)
    {
        Node? current = null;
        Node? head = null;
        for (int i = 0; i < list.Length; i++)
        {
            Node n = new Node(list[i]);
            if (current == null)
            {
                head = n;
                current = head;
            }
            else
            {
                current.next = n;
                current = n;
            }
        }
        return head;
    }

    static void PrintList(Node? head)
    {
        Node? current = head;
        while (current != null)
        {
            Console.Write(current.val + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }


    static void Main()
    {
        int[] vals = [1, 2, 3, 4, 5, 6];
        Node? head = CreateList(vals);

        PrintList(head);
    }
}