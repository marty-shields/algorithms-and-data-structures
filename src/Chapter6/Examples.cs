namespace algorithms.Chapter6;

public static class Examples
{
    public static bool IsStatementBalanced(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return true;

        char[] openingOperators = ['(', '{', '['];
        char[] closingOperators = [')', '}', ']'];
        var operatorStack = new Stack<char>();

        foreach (var c in s)
        {
            if (openingOperators.Contains(c))
            {
                operatorStack.Push(c);
            }

            if (closingOperators.Contains(c))
            {
                if (operatorStack.Count == 0) return false;

                var openingOperator = operatorStack.Pop();
                for (int i = 0; i < openingOperators.Length; i++)
                {
                    if (openingOperator.Equals(openingOperators[i]) && !closingOperators[i].Equals(c))
                        return false;
                }
            }
        }

        return operatorStack.Count == 0;
    }
}
