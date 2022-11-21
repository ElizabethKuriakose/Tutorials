//Generics

using System.Collections;
using System.Text;

//ArrayList lst = new ArrayList();
//lst.Add(1);
//lst.Add("TWO");

//Console.WriteLine(string.Join(",",lst));

//foreach (var item in lst)
//{
//    Console.WriteLine(item);
//}

//while(true)
//{
//    Console.Write("-\r ");
//    Thread.Sleep(1000);
//    Console.Write("/\r ");
//    Thread.Sleep(1000);
//}

string[] symbols = { "\r|", "\r/","\r-","\r|","\r/","\r-","\r\\"};

//while (true)
//{
//	foreach (var item in symbols)
//	{
//		Console.Write(item);
//		Thread.Sleep(500);
//	}
//}
//int i =0;
//while (i < 100)
//{
//    if (i >= 50)
//    {
//        Console.Clear();
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.Write("|");
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write("|");
//        Thread.Sleep(200);
//    }
//    i++;
//}
//var c = (char)166;
//for (int i = 1; i <= 100; i++)
//{
//    Console.Write("\r");
//	if(i <= 50)
//        Console.ForegroundColor = ConsoleColor.Magenta;
//    else
//        Console.ForegroundColor = ConsoleColor.Cyan;
//    for (int j = 1; j <= i; j++)
//	{
//        Console.Write(c);
//	}
//    Console.Write(i + "%");
//    Thread.Sleep(i<=10?500:100);
//}

//Console.ForegroundColor = ConsoleColor.White;

//var d1 = new Distance<string,int>() { Name = "qq",Value = 10 };
//var d2 = new Distance<char, double>() { Name = 'q', Value = 10.5 };

//Console.WriteLine($"{d1.Name}  {d1.Value}");
//Console.WriteLine($"{d2.Name}  {d2.Value}");
//class Distance<TName, TValue>
//{
//    public TName Name { get; set; }
//    public TValue Value { get; set; }
//    public TValue GetValue() { return Value; }
//}

//var v1 = new Vehicles<Bike>();
//v1.Name = new Bike();
//v1.Type = "Two Wheeler";
//v1.Name.BikeNumber = 12345;
//v1.Name.Company = "Mahindra";

//Console.WriteLine($"{v1.Type} {v1.Name.BikeNumber} {v1.Name.Company}");

//class Vehicles<T>
//{
//    public string Type { get; set; }
//    public T Name { get; set; }
//}


//class Bike
//{
//    public int BikeNumber { get; set; }
//    public string Company { get; set; }
//}

//class Car
//{
//    public int CarNumber { get; set; }
//    public string Company { get; set; }
//}

//-------------------------------------------------------

//Write a generic method to count the number of elements in a
//collection that have a specific property
//(for example, odd integers, prime numbers, palindromes).

//enums - to limit the values

void Test()
{

}

//Days d = Days.Friday;
//Console.WriteLine((int)d);
//enum Days 
//{
//    Sunday = 1,
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday
//}

void ConvertCasing(string word, Options op)
{
    if(op == Options.Upper)
        Console.WriteLine(word.ToUpper());
    else if (op == Options.Lower)
        Console.WriteLine(word.ToLower());
}
void SwithExample(Options op)
{
    switch (op)
    {
        case Options.Upper:
            break;
        case Options.Lower:
            break;
        default:
            break;
    }
}

var w = "Hello";
ConvertCasing(w, Options.Upper);

enum Options
{
    Upper,
    Lower
}