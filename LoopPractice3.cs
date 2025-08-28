using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter base: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter exponent: ");
        int exp = Convert.ToInt32(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < exp; i++)
        {
            result *= baseNum;
        }
        Console.WriteLine($"For loops: {result}");
        
         result = 1;
        int j = 0;
        while (j < exp)
        {
            result *= baseNum;
            j++;
        }
        Console.WriteLine($"While loops: {result}");
        
        result = 1;
        int k = 0;
        if (exp > 0) // handle exponent = 0
        {
            do
            {
                result *= baseNum;
                k++;
            } while (k < exp);
        }
        Console.WriteLine($"Do-while loops: {result}");
    }
}