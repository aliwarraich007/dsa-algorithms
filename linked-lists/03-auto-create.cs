public class Node
{
    public int val;
    public Node next;
    public Node(int val = 0, Node? next = null)
    {
        this.val = val;
        this.next = next;
    }
}


public class Solution
{
    static Node CreateList(int[] list)
    {
        Node? current = null;
        for (int i = 0; i < list.Length; i++)
        {
            Node n = new Node(list[i], current);
            n.next = current;
            current = n;
        }
        return current;
    }

    static void PrintList(Node? head)
    {
        Node current = head;
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
        Node head = CreateList(vals);

        PrintList(head);
    }
}