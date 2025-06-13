namespace algorithms.Chapter4;

public static class QuickSort
{
    public static void Sort(int[] values)
    {
        Sort(values, 0, values.Length - 1);
    }

    private static void Sort(int[] values, int firstIndex, int lastIndex)
    {
        if (firstIndex < lastIndex)
        {
            int pivotIndex = Partition(values, firstIndex, lastIndex);
            Sort(values, firstIndex, pivotIndex - 1);
            Sort(values, pivotIndex + 1, lastIndex);
        }
    }

    private static int Partition(int[] values, int firstIndex, int lastIndex)
    {
        int pivotValue = values[firstIndex];
        int lowerIndex = firstIndex + 1;
        int upperIndex = lastIndex;

        bool done = false;
        while (!done)
        {
            while (lowerIndex <= upperIndex && values[lowerIndex] <= pivotValue)
            {
                lowerIndex++;
            }

            while (upperIndex >= lowerIndex && values[upperIndex] >= pivotValue)
            {
                upperIndex--;
            }

            if (upperIndex < lowerIndex) done = true;
            else
            {
                int temp = values[lowerIndex];
                values[lowerIndex] = values[upperIndex];
                values[upperIndex] = temp;
            }
        }

        int temp2 = values[firstIndex];
        values[firstIndex] = values[upperIndex];
        values[upperIndex] = temp2;
        return upperIndex;
    }
}
