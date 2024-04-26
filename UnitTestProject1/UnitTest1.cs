using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class SolutionTests
{
    [TestMethod]
    public void TestSplitList_PositiveAndNegativeListsAreCorrect()
    {
        ListNode head = new ListNode(1);
        head.Next = new ListNode(-2);
        head.Next.Next = new ListNode(3);
        head.Next.Next.Next = new ListNode(-4);
        head.Next.Next.Next.Next = new ListNode(5);

        ListNode positiveList;
        ListNode negativeList;
        Solution.SplitList(head, out positiveList, out negativeList);

        Console.WriteLine("Positive list:");
        PrintList(positiveList);
        Console.WriteLine("Negative list:");
        PrintList(negativeList);

        string expectedPositive = "1 3 5";
        string actualPositive = ConvertToString(positiveList);
        Assert.AreEqual(expectedPositive, actualPositive, "Positive list is not correct");

        string expectedNegative = "-2 -4";
        string actualNegative = ConvertToString(negativeList);
        Assert.AreEqual(expectedNegative, actualNegative, "Negative list is not correct");
    }

    private string ConvertToString(ListNode head)
    {
        string result = "";
        while (head != null)
        {
            result += head.Value + " ";
            head = head.Next;
        }
        return result.Trim();
    }

    private void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.Value + " ");
            head = head.Next;
        }
        Console.WriteLine();
    }
}
