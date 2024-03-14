using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage of the TriangleCalculator class
        double baseLength = 5.0;
        double height = 3.0;

        double area = TriangleCalculator.CalculateArea(baseLength, height);
        Console.WriteLine("Area of the triangle: " + area);
    }
}