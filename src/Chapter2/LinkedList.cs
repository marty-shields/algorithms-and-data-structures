namespace algorithms.Chapter2;

public class LinkedList
{
    public int Count { get; private set; }
    private LinkedListNode? _head;

    public LinkedList()
    {
        Count = 0;
        _head = null;
    }

    public void InsertAtHead(int value)
    {
        var newNode = new LinkedListNode(value, _head);
        _head = newNode;
        Count++;
    }

    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index >= Count || _head is null)
            return;

        if (index == 0)
        {
            _head = _head.Next;
            return;
        }

        var tempNode = _head;
        for (int i = 0; i < index - 1; i++)
        {
            tempNode = tempNode!.Next;
        }

        tempNode!.SetNext(tempNode.Next?.Next);
        Count--;
    }

    public LinkedListNode? Find(int value)
    {
        var current = _head;
        while (current is LinkedListNode node)
        {
            if (node.Value == value)
            {
                return node;
            }

            current = current.Next;
        }

        return null;
    }

    public void PrintList()
    {
        int position = 0;
        var tempNode = _head;
        while (tempNode is LinkedListNode node)
        {
            Console.WriteLine($"Node Position: {position} - Node Value: {node.Value}");
            tempNode = node.Next;
            position++;
        }
    }
}