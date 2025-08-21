using System;

public class conditionalpractice4

{
    public static void Main(string[] args)
    {
        int score = 69;

        string passing = (score >= 50) ? "Passed" : "Failed";

        Console.WriteLine(passing);
    }
}