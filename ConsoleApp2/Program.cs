//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");

//// 
////Console.WriteLine("Enter your name: ");
////string name = Console.ReadLine();

////using static System.Console;
//string s = "hello" + Environment.NewLine + "world";

//Console.WriteLine(s);

//string firstName = "john";
//string lastName = "panther";

//string res = string.Format("{0} and {1}",firstName, lastName);
//Console.WriteLine(res);

//string res1 = $"{firstName} {lastName}";
//Console.WriteLine(res1);

//byte age;
//sbyte real;

//short a;
//ushort b;

//int c;
//uint d;
//long l;
//ulong r;

//Console.WriteLine(long.MinValue);
//Console.WriteLine(long.MaxValue);

//// .net utube, scott hanselman
//// cls: cmmon language specification
//// clr: common language run time- responsible for running the application
///

//Console.WriteLine("Enter first number");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter second number");
//int b = int.Parse(Console.ReadLine());
////Int32: eqlnt to int in .net
//int res = a + b;
//Console.WriteLine(res);

//Console.WriteLine("Enter number");
//int w = Convert.ToInt32(Console.ReadLine());
// it will conert null value to 0

//try to convert all type
// loops
// datatypes
//y we have dll and pdb files


//string s = Convert.ToString(Console.ReadLine());
//int ab = 1111111111;//32 bit memory allocation

//int i;

//dynamic dy = "qwerty";
//Console.WriteLine(dy.ToUpper());
//var num = new int[5];
//for (int i = 0; i < num.Length; i++)
//{
//    num[i] = int.Parse(Console.ReadLine());
//}
//for (int j = 0; j < num.Length; j++)
//{
//    //Console.WriteLine();
//    if (num[j] % 2 == 0)
//    {
//        Console.WriteLine($" {num[j]} ");
//    }
//}
//Console.WriteLine(string.Join(",", num));

//string op = "";
//while (true)
//{
//    Console.WriteLine("Enter a number");
//    op = Console.ReadLine();
//    switch (op.ToUpper())
//    {
//        case "ONE":
//            Console.WriteLine(1);
//            break;
//        case "TWO":
//            Console.WriteLine(2);
//            break;

//        default:
//            Console.WriteLine("UNKNOWN");
//            break;
//    }
//}

//string @class = "1";   //by preceeding @ we can use a keyword as a variable name

//string rev = "qwerty";


using System;
///
Console.WriteLine("Enter array elmts");
var arr = new int[5];
var max = 0;
var secl = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
Console.Write("The greatest number is ");
for (int j = 0; j < arr.Length; j++)
{
	if(arr[j] > max)
    {
        max = arr[j];
    }
    //if ((secl < arr[j]) && (arr[j] < max))
    //{
    //    secl = arr[j];
    //}
}
Console.WriteLine(max);

int temp;
for (int k = 0; k < arr.Length-1; k++)
{
    for (int l = k+1; l < arr.Length; l++)
    {
        if (arr[k] < arr[l])
        {
            temp = arr[k];
            arr[k] = arr[l];
            arr[l] = temp;
        }
    }
}
Console.WriteLine($"The second largest number is {arr[1]}");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}


string name1 = null;
name1 ??= "Unknown"; // null coalescsing assignment operator