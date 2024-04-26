using System;

public class ListNode
{
    public int Value { get; set; }
    public ListNode Next { get; set; }

    public ListNode(int val = 0, ListNode next = null)
    {
        Value = val;
        Next = next;
    }
}
public class Solution
{
    public static void SplitList(ListNode head, out ListNode positiveList, out ListNode negativeList)
    {
        positiveList = null;
        negativeList = null;

        ListNode currentPos = null;
        ListNode currentNeg = null;

        while (head != null)
        {
            if (head.Value >= 0)
            {
                if (positiveList == null)
                {
                    positiveList = new ListNode(head.Value);
                    currentPos = positiveList;
                }
                else
                {
                    currentPos.Next = new ListNode(head.Value);
                    currentPos = currentPos.Next;
                }
            }
            else
            {
                if (negativeList == null)
                {
                    negativeList = new ListNode(head.Value);
                    currentNeg = negativeList;
                }
                else
                {
                    currentNeg.Next = new ListNode(head.Value);
                    currentNeg = currentNeg.Next;
                }
            }

            head = head.Next;
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {
        ListNode head = new ListNode(1);
        head.Next = new ListNode(-2);
        head.Next.Next = new ListNode(3);
        head.Next.Next.Next = new ListNode(-4);
        head.Next.Next.Next.Next = new ListNode(5);

        Console.WriteLine("Початковий список:");
        PrintList(head);

        ListNode positiveList;
        ListNode negativeList;
        Solution.SplitList(head, out positiveList, out negativeList);

        Console.WriteLine("Позитивний список:");
        PrintList(positiveList);

        Console.WriteLine("Негативний список:");
        PrintList(negativeList);

        Console.ReadLine();
    }

    static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.Value + " ");
            head = head.Next;
        }
        Console.WriteLine();
    }
}

