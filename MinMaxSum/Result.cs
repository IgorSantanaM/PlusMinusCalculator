class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positiveCount = 0, negativeCount = 0, zeroCount = 0;

        int n = arr.Count;

        foreach (int num in arr)
        {
            if (num == 0)
                zeroCount++;
            else if (num > 0)
                positiveCount++;
            else
                negativeCount++;
        }
        double positiveRatio = (double)positiveCount / n;
        double negativeRatio = (double)negativeCount / n;
        double zeroRatio = (double)zeroCount / n;

        Console.WriteLine(positiveRatio.ToString("F6"));
        Console.WriteLine(negativeRatio.ToString("F6"));
        Console.WriteLine(zeroRatio.ToString("F6"));
    }

}