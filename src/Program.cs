
using algorithms.Chapter1;
using algorithms.Chapter2;
using algorithms.Chapter3;
using algorithms.Chapter4;
using algorithms.Chapter5;
using algorithms.Chapter6;

Console.WriteLine(EuclidAlgorithm.Execute(60, 96));
Console.WriteLine(EuclidAlgorithm.Execute(20, 8));

var linkedList = new LinkedList();
linkedList.InsertAtHead(38);
linkedList.InsertAtHead(49);
linkedList.InsertAtHead(13);
linkedList.InsertAtHead(15);
linkedList.PrintList();

Console.WriteLine($"List Count: {linkedList.Count}");
Console.WriteLine($"Finding Item With 13: {linkedList.Find(13)}");
Console.WriteLine($"Finding Item With 78: {linkedList.Find(78)}");
linkedList.DeleteAtIndex(3);
Console.WriteLine($"List Count: {linkedList.Count}");
Console.WriteLine($"Finding Item With 38: {linkedList.Find(38)}");
linkedList.PrintList();

Recursion.CountDown(5);
Console.WriteLine($"2 to the power of 4: {Recursion.Power(2,4)}");
Console.WriteLine($"5 to the power of 3: {Recursion.Power(5,3)}");
Console.WriteLine($"Factorial of 4: {Recursion.Factorial(4)}");
Console.WriteLine($"Factorial of 0: {Recursion.Factorial(0)}");

int[] sortValues = [6, 20, 8, 19, 56, 23, 87, 41, 49, 53];
Console.WriteLine($"Max Value Recursion: {Recursion.FindMaxValue(sortValues)}");
sortValues[9] = 100;
Console.WriteLine($"Max Value Recursion: {Recursion.FindMaxValue(sortValues)}");
sortValues[0] = 101;
Console.WriteLine($"Max Value Recursion: {Recursion.FindMaxValue(sortValues)}");
sortValues[5] = 111;
Console.WriteLine($"Max Value Recursion: {Recursion.FindMaxValue(sortValues)}");

sortValues = [6, 20, 8, 19, 56, 23, 87, 41, 49, 53];
Console.WriteLine($"Bubble sort start: {string.Join(", ", sortValues)}");
sortValues = BubbleSort.Sort(sortValues);
Console.WriteLine($"Bubble sort end: {string.Join(", ", sortValues)}");

sortValues = [6, 20, 8, 19, 56, 23, 87, 41, 49, 53];
Console.WriteLine($"Merge sort start: {string.Join(", ", sortValues)}");
sortValues = MergeSort.Sort(sortValues);
Console.WriteLine($"Merge sort end: {string.Join(", ", sortValues)}");

sortValues = [6, 20, 8, 19, 56, 23, 87, 41, 49, 53];
Console.WriteLine($"Quick sort start: {string.Join(", ", sortValues)}");
QuickSort.Sort(sortValues);
Console.WriteLine($"Quick sort end: {string.Join(", ", sortValues)}");

sortValues = [6, 8, 19, 20, 23, 41, 49, 53, 56, 87];
Console.WriteLine($"Binary search for 8: {BinarySearch.Search(sortValues, 8)}");
Console.WriteLine($"Binary search for 23: {BinarySearch.Search(sortValues, 23)}");
Console.WriteLine($"Binary search for 87: {BinarySearch.Search(sortValues, 87)}");
Console.WriteLine($"Binary search for 88: {BinarySearch.Search(sortValues, 88)}");

string s = "{([])}";
Console.WriteLine($"Is statement balanced: {Examples.IsStatementBalanced(s)}");
s = "{([])";
Console.WriteLine($"Is statement balanced: {Examples.IsStatementBalanced(s)}");
s = "{([)}";
Console.WriteLine($"Is statement balanced: {Examples.IsStatementBalanced(s)}");
s = "{([]}";
Console.WriteLine($"Is statement balanced: {Examples.IsStatementBalanced(s)}");
s = "{([])}}{";
Console.WriteLine($"Is statement balanced: {Examples.IsStatementBalanced(s)}");