using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-STRING METHODS-");

        // Declare two string examples
        string example1 = "String's ready and I start work";
        string example2 = "Welcome buddy";

        // Length property
        Console.WriteLine($"Length of example1: {example1.Length}");
        Console.WriteLine($"Length of example2: {example2.Length}");

        // ToUpper and ToLower methods
        Console.WriteLine(example1.ToUpper());
        Console.WriteLine(example2.ToLower());

        // Concatenation using Concat method
        Console.WriteLine(string.Concat(example1, " Never give up"));

        // CompareTo method
        Console.WriteLine($"Comparison result: {example1.CompareTo(example2)}");

        // Contains, EndsWith, and StartsWith methods
        Console.WriteLine($"Contains 'Welcome buddy': {example1.Contains(example2)}");
        Console.WriteLine($"Ends with 'work': {example1.EndsWith("work")}");
        Console.WriteLine($"Starts with 'selam': {example1.StartsWith("selam")}");

        // IndexOf method
        Console.WriteLine($"Index of 'I': {example1.IndexOf("I")}");
        Console.WriteLine($"Index of 'selam': {example1.IndexOf("selam")}");

        // Insert method
        Console.WriteLine($"Insert 'Dont back' at the beginning: {example1.Insert(0, "Dont back ")}");

        // LastIndexOf method
        Console.WriteLine($"Last index of 'k': {example1.LastIndexOf("k")}");

        // PadLeft and PadRight methods
        Console.WriteLine(example1 + example2.PadLeft(30));
        Console.WriteLine(example1 + example2.PadLeft(30, '*'));
        Console.WriteLine(example1.PadRight(50) + example2);
        Console.WriteLine(example1.PadRight(50, '*') + example2);

        // Remove method
        Console.WriteLine($"Remove from index 10: {example1.Remove(10)}");
        Console.WriteLine($"Remove 3 characters starting from index 5: {example1.Remove(5, 3)}");
        Console.WriteLine($"Remove 11 characters starting from index 0: {example1.Remove(0, 11)}");

        // Replace method
        Console.WriteLine($"Replace 'ready' with 'hazırsan': {example1.Replace("ready", "hazırsan")}");
    }
}
