using System;

public class conditionalpractice5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Circle Calculator");
        Console.WriteLine("A - Compute Area");
        Console.WriteLine("P - Compute Perimeter");
        Console.WriteLine("X - Exit");
        Console.Write("Enter your choice: ");
        char choice = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (choice)
        {
            case 'A':
                Console.Write("Enter the radius of the circle: ");
                if (double.TryParse(Console.ReadLine(), out double radiusA) && radiusA > 0)
                {
                    double area = Math.PI * radiusA * radiusA;
                    Console.WriteLine($"The area of the circle is: {area:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid radius.");
                }
                break;

            case 'P':
                Console.Write("Enter the radius of the circle: ");
                if (double.TryParse(Console.ReadLine(), out double radiusP) && radiusP > 0)
                {
                    double perimeter = 2 * Math.PI * radiusP;
                    Console.WriteLine($"The perimeter (circumference) of the circle is: {perimeter:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid radius.");
                }
                break;

            case 'X':
                Console.WriteLine("Exiting the application. Goodbye!");
                break;

            default:
                Console.WriteLine("Invalid option. Please choose A, P, or X.");
                break;
        }
    }
}
