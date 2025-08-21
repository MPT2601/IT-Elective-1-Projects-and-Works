using System;

public class conditionalpractice3

{
    public static void Main(string[] args)
    {

        Console.WriteLine("To identify you, input the following");

        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Income(Monthly): ");
        double income = Convert.ToDouble(Console.ReadLine());

        if (age >= 25 && age <= 35 && income > 50000)
        {
            Console.WriteLine("You are a Young Proffesional");
        }
        else if (age >= 36 && age <= 55 && income > 70000)
        {
            Console.Write(" You are a Middle-Aged Proffesional");
        }
        else if (age >= 56 && income < 30000)
        {
            Console.WriteLine("You are a Senior Citizen");
        }
        else
        {
            Console.WriteLine("You are others");
        }
    }
}