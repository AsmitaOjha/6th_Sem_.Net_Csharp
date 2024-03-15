using System;

class Family{
    public string Family_Head_name, age, relation;
    public string getInfo(){
        Console.Write("Family_Head: ");
        Family_Head_name = Console.ReadLine();
        Console.Write("Age: "); // Fixed: Prompt for age separately
        age = Console.ReadLine();
        Console.Write("Relation: "); // Fixed: Prompt for relation separately
        relation = Console.ReadLine();
        return "Name: " + Family_Head_name + ", Age: " + age + ", Relation: " + relation; // Fixed: Return concatenated string
    }
}

class Bhatt_Family : Family{
    public string Address = "Bankhet"; //bhatt_family field
}

class Program
{
    static void Main(string[] args)
    {
        //create a bhatt_family object
        Bhatt_Family Hari = new Bhatt_Family();
        
        // Moved getInfo() call here
        Console.WriteLine("Hari's Family Head " + Hari.getInfo());
    }
}
