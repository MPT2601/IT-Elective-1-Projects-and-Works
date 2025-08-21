using System;

public class conditionalpractice2

{
    public static void Main(string[] args)
    {
        int nuumero = 3;
        if (nuumero > 0)
        {
            Console.WriteLine($"The number {nuumero} is positive");
        }
        else
        {
            Console.WriteLine($"The number {nuumero} is negative");
        }
    }
}