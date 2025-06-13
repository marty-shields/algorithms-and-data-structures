namespace algorithms.Chapter2;

public record LinkedListNode
{
    public int Value { get; private set; }
    public LinkedListNode? Next { get; private set; }

    public LinkedListNode(int value, LinkedListNode? next)
    {
        Value = value;
        Next = next;
    }

    public void SetNext(LinkedListNode? next)
    {
        Next = next;
    }
}