using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("For Loops:");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("While loops:");
        int j = 10;
        while (j >= 1)
        {
            Console.Write(j + " ");
            j--;
        }
        Console.WriteLine();

        Console.WriteLine("Do-while loops:");
        int k = 10;
        do
        {
            Console.Write(k + " ");
            k--;
        } while (k >= 1);
    }
}