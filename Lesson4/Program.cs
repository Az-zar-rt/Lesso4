class Program
{
    static void Main()
    {
        int min;
        int max;
        FindMinValue(out min, 13, 11, 12, 9, 0, 1, 45, 345);
        FindMaxValue(out max, 13, 11, 12, 9, 0, 1, 45, 345);
        int sumOfOdd;
        var isOdd = TrySumIfOdd(3, 9, out sumOfOdd);
        var r = Repeat("long", 4);

        Console.WriteLine($"min: {min}, max - {max}, [isOdd - {isOdd}, sum - {sumOfOdd}], repeat: {r}");

    }
   
    public static void FindMaxValue (out int max, params int[] list)
    {
        max = 0;
        foreach(var i in list)
        {
            if (i > max)
                max = i;
        }
    }

    public static void FindMinValue(out int min, params int[] list)
    {
        min = 0;
        foreach (var i in list)
        {
            if (i < min)
                min = i;
        }
    }

    public static bool TrySumIfOdd (int a, int b, out int sum)
    {
        return (sum = a + b) % 2 != 0; 
    }

    public static void FindMaxValue(out int max, int a, int b, int c)
    {
        max = 0;
        if (a > max)
            max = a;
        if (b > max)
            max = b;
        if (c > max)
            max = c;
    }

    public static void FindMaxValue(out int max, int a, int b, int c, int d)
    {
        max = 0;
        if (a > max)
            max = a;
        if (b > max)
            max = b;
        if (c > max)
            max = c;
        if (d > max)
            max = d;
    }

    public static string Repeat(string x, int n)
    {
        var result = string.Empty;
        for (int i = 0; i < n; i++)
        {
            result += "\n" + x;
        }
        return result;
    }
}
//checked
