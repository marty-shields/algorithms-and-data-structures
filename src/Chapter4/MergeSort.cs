namespace algorithms.Chapter4;

public static class MergeSort
{
    public static int[] Sort(int[] values)
    {
        if (values.Length > 1)
        {
            int middleIndex = values.Length / 2;
            int[] left = values[0..middleIndex];
            int[] right = values[middleIndex..values.Length];
            left = Sort(left);
            right = Sort(right);

            int i = 0;
            int j = 0;
            int k = 0;
            int leftLength = left.Length;
            int rightLength = right.Length;

            while (i < leftLength && j < rightLength)
            {
                if (left[i] < right[j])
                {
                    values[k] = left[i];
                    i++;
                }
                else
                {
                    values[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < leftLength)
            {
                values[k] = left[i];
                i++;
                k++;
            }

            while (j < rightLength)
            {
                values[k] = right[j];
                j++;
                k++;
            }
        }

        return values;
    }
}
