using System.ComponentModel;

Console.WriteLine("-STRİNG METHODS-");


string example1 = "String's ready and I start work";
string example2 ="Welcome buddy";

Console.WriteLine(example1.Length);
Console.WriteLine(example2.Length);

Console.WriteLine(example1.ToUpper());
Console.WriteLine(example2.ToLower());

Console.WriteLine(string.Concat(example1,"Never give up"));

Console.WriteLine(example1.CompareTo(example2));

Console.WriteLine(example1.Contains(example2));
Console.WriteLine(example1.EndsWith("work"));
Console.WriteLine(example1.StartsWith("selam"));


Console.WriteLine(example1.IndexOf("I"));
Console.WriteLine(example1.IndexOf("selam"));

Console.WriteLine(example1.Insert(0,"Dont back "));

Console.WriteLine(example1.LastIndexOf("k"));

Console.WriteLine(example1+example2.PadLeft(30));
Console.WriteLine(example1+example2.PadLeft(30),'*');
Console.WriteLine(example1.PadRight(50)+example2);
Console.WriteLine(example1.PadRight(50),'*'+example2);

Console.WriteLine(example1.Remove(10));
Console.WriteLine(example1.Remove(5,3));
Console.WriteLine(example1.Remove(0,11));

Console.WriteLine(example1.Replace("ready","hazırsan"));