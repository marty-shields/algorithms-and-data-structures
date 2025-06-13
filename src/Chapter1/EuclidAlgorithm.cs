namespace algorithms.Chapter1;

public static class EuclidAlgorithm
{
    public static int Execute(int a, int b)
    {
        while (b != 0)
        {
            int t = a;
            a = b;
            b = t % a;
        }
        return a;
    }
}
