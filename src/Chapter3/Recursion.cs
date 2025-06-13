namespace algorithms.Chapter3;

public static class Recursion
{
    public static void CountDown(int x)
    {
        if (x == 0)
        {
            Console.WriteLine("Done!");
            return;
        }

        Console.WriteLine($"Number is {x}");
        CountDown(x - 1);
        Console.WriteLine("Hey!");
    }

    public static int Power(int number, int power)
    {
        if (power == 0) return 1;
        return number * Power(number, power - 1);
    }

    public static int Factorial(int num)
    {
        if (num == 0) return 1;
        return num * Factorial(num - 1);
    }

    public static int FindMaxValue(int[] values)
    {
        if (values.Length == 0) return 0;
        if (values.Length == 1) return values[0];

        int value1 = values[0];
        int value2 = FindMaxValue(values[1..]);
        return value1 > value2 ? value1 : value2;
    }
}
