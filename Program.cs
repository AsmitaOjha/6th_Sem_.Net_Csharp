
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
        string a = Console.ReadLine();
        Console.WriteLine("Enter second number: ");
        string b = Console.ReadLine();
        int firstnumber = Convert.ToInt32(a);
        int secondnumber = Convert.ToInt32(b);
        int sum =firstnumber + secondnumber;
        Console.WriteLine("The sum is : " + sum);
        Console.ReadLine();
            }
        }
        }