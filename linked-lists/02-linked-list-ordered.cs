
public class Node
{
    public int val;
    public Node next;

    public Node(int val = 0, Node next = null)
    {
        this.val = val;
        this.next = next;
    }
}

class Program
{
    static Node CreateNode(int val = 0, Node prev = null)
    {
        Node temp = new Node(val);
        prev.next = temp;
        return temp;
    }
    static void PrintList(Node head)
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
        Node head = new Node(1);
        Node n1 = CreateNode(2, head);
        Node n2 = CreateNode(3, n1);
        PrintList(head);
    }
}