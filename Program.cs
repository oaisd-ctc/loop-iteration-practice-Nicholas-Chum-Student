using System;

public class Program
{
    
    public static void Main(string[] args)
    {
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);

        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);

        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);

        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);

        WriteEvensThrough100();

        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);

        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);

        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);

        OutputRightTriangle(4);
        OutputRightTriangle(6);
        OutputRightTriangle(-4);
        OutputRightTriangle(-6);
        OutputRightTriangle(0);
    }
    
    public static void Write1ThroughN_While(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
            return;
        }
        int i = 1;
        while (n >= i)
        {
            Console.WriteLine($"{i}");
            i++;
        }
        
    }
    public static void Write1ThroughN_For(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
    public static void WriteNThrough1_While(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
            return;
        }
        while (n >= 1)
        {
            Console.WriteLine($"{n}");
            n--;
        }
    }
    public static void WriteNThrough1_For(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
            return;
        }
        for (int i = 1; i >= n; i++)
        {
            Console.WriteLine(i);
        }
    }
    public static void WriteEvensThrough100()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    public static void FindSum(int n)
    {
        if (n == 0)
        {
            Console.WriteLine(n);
        }
        int sum = 0;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
        }
        else
        {
            for (int i = 1; i >= n; i--)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
    public static void FindSumOfEvenNumbers(int n)
    {
        if (n == 0)
        {
            Console.WriteLine(n);
            return;
        }
        int sum = 0;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
        }
        else
        {
            for (int i = 1; i >= n; i--)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
        }
        Console.WriteLine(sum);
    }
    public static void FindSumOfOddNumbers(int n)
    {
        if (n == 0)
        {
            Console.WriteLine(n);
            return;
        }
        int sum = 0;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
        }
        else
        {
            for (int i = 1; i >= n; i--)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
        }
        Console.WriteLine(sum);
    }
    public static void OutputRightTriangle(int _base)
    {
        if (_base == 0)
        {
            OutOfRangeMessage(_base);
        }
        else if (_base > 0)
        {
            for (int i = 1; i <= _base; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write("🐱");
                }
                Console.WriteLine();
            }
        }
        else
        {
            for (int i = Math.Abs(_base); i > 0; i--)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write("🐱");
                }
                Console.WriteLine();
            }
        }
    }
    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine($"{n} is out of range");
    }
}