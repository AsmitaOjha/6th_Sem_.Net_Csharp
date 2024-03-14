using System;

class Person
{
    private string name; // field

    public string Name // property
    {
        get { return name; }
        set { name = value; }
    }
}
class Car{
    //shorthand use of get and set of property
    private string brand;
    public string Brand{
        get;
        set;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person obj1 = new Person(); // Instantiate a new Person object
        obj1.Name = "Asmita";
        Console.WriteLine(obj1.Name); // Corrected capitalization of WriteLine

        //for different class
        Car car1=new Car(); //instantiate a new car object
        Console.Write("Enter your car brand: ");
        car1.Brand=Console.ReadLine();
        Console.WriteLine("The brand of car is" + car1.Brand);
    }
}



