using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        Console.WriteLine("Sum of odd digits using while loop:");
        int temp = num;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit % 2 != 0) sum += digit;
            temp /= 10;
        }
        Console.WriteLine(sum);

        Console.WriteLine("\nSum of odd digits using do-while loop:");
        sum = 0;
        temp = num;
        if (temp > 0)
        {
            do
            {
                int digit = temp % 10;
                if (digit % 2 != 0) sum += digit;
                temp /= 10;
            } while (temp > 0);
        }
        Console.WriteLine(sum);

        Console.WriteLine("\n(Same logic can be written with for loop too)");
    }
}