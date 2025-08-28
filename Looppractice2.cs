using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("For loops:");
        for (int i = 3; i <= 50; i += 2)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("While loop:");
        int j = 3;
        while (j <= 50)
        {
            Console.Write(j + " ");
            j += 2;
        }
        Console.WriteLine();
        
        Console.WriteLine("Do-while loop:");
        int k = 3;
        do
        {
            Console.Write(k + " ");
            k += 2;
        } while (k <= 50);
    }
}