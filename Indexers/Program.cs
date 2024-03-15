using System;

class SampleCollection
{
    private string[] data = new string[5]; // Array to store data

    // Indexer declaration
    public string this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            data[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SampleCollection collection = new SampleCollection();

        // Using the indexer to set values
        collection[0] = "Item 1";
        collection[1] = "Item 2";
        collection[2] = "Item 3";

        // Using the indexer to get values
        Console.WriteLine(collection[0]); // Output: Item 1
        Console.WriteLine(collection[1]); // Output: Item 2
        Console.WriteLine(collection[2]); // Output: Item 3
    }
}
