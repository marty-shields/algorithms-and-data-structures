namespace algorithms.Chapter4;

public static class BubbleSort
{
    public static int[] Sort(int[] values)
    {
        for (int i = values.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (values[j] > values[j + 1])
                {
                    int temp = values[j];
                    values[j] = values[j + 1];
                    values[j + 1] = temp;
                }
            }
            Console.WriteLine($"Bubble sort current state: {string.Join(", ", values)}");
        }

        return values;
    }
}
