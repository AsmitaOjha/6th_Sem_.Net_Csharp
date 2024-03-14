
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        // Console.WriteLine("Good Evening Everyone !!");
        // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        // for (int i = 0; i < cars.Length; i++) 
        // {
        //     Console.WriteLine(cars[i]);
        //     // Console.ReadLine();
        // }
        // Console.WriteLine("Hello Asmita");
        // //int a = 80;
        // //int b = 90;
        // //Console.WriteLine(a + b);

Console.WriteLine("Enter first number: ");
string? inputA = Console.ReadLine();

Console.WriteLine("Enter second number: ");
string? inputB = Console.ReadLine();

if (inputA is not null && inputB is not null)
{
    if (int.TryParse(inputA, out int firstNumber) && int.TryParse(inputB, out int secondNumber))
    {
        int sum = firstNumber + secondNumber;
        Console.WriteLine("The sum is: " + sum);
    }
    else
    {
        Console.WriteLine("Invalid input for the numbers. Please enter valid integers.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter valid values for both numbers.");
}
        }}}