namespace algorithms.Chapter5;

public class BinarySearch
{
    public static int? Search(int[] values, int value)
    {
        int lowerIndex = 0;
        int upperIndex = values.Length - 1;

        while (lowerIndex <= upperIndex)
        {
            int midPoint = (lowerIndex + upperIndex) / 2;

            if (values[midPoint] == value) return midPoint;

            if (value > values[midPoint]) lowerIndex = midPoint + 1;
            else upperIndex = midPoint - 1;
        }

        return null;
    }
}
