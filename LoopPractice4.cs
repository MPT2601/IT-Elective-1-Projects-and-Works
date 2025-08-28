using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        Console.WriteLine("For loops: ");
        for (int i = 1; i <= 10; i++)
        {
            sum += i * i;
        }
        Console.WriteLine(sum);
        
        Console.WriteLine("while loop:");
        sum = 0;
        int j = 1;
        while (j <= 10)
        {
            sum += j * j;
            j++;
        }
        Console.WriteLine(sum);

        Console.WriteLine("do-while loop:");
        sum = 0;
        int k = 1;
        do
        {
            sum += k * k;
            k++;
        } while (k <= 10);
        Console.WriteLine(sum);
    }
}