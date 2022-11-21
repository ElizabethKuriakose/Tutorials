// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Net.Cache;
using  Tutorial17Nov.ExtensionMethods;

//var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int i;
//i.FindOddorEven();

//string qq = "This is a string";
//Console.WriteLine(qq.SpaceCount());


//int[] data = { 1, 2, 3 };
//var r=data.Count(m => m % 2 == 0);
//var res = data.Any(m => m % 2 == 0);
//Console.WriteLine(r);
//Console.WriteLine(res);
//Console.WriteLine(data.First());

//int[] value = {10,20,30,45,50};
//var res1 = value.Any();
//Console.WriteLine(res1);
//Console.WriteLine(value.FirstOrDefault());
//Console.WriteLine(value.FirstOrDefault(m => m % 2 != 0));
//Console.WriteLine(value.LastOrDefault());

//var aa = value.SkipLast(2);
//Console.WriteLine(String.Join(",",aa));

//var bb = value.SkipWhile(m => m % 2 == 0);
//Console.WriteLine(String.Join(",", bb));

//Console.WriteLine(value.Min());

//var cc = value.TakeWhile(m => m % 2 == 0);
//Console.WriteLine(String.Join(",", cc));

//var dd = value.Where(m => m % 2 == 0);
//Console.WriteLine(String.Join(",", dd));

//var ee = value.Take(50);
//Console.WriteLine(String.Join(",", ee));

var trainees = new List<Trainee>
{
    new(){Name ="Anoop",Language = "C#",Age = 20},
    new(){Name ="Viss",Language = "C#",Age = 22},
    new(){Name ="Mariya",Language = "C#",Age = 19},
    new(){Name ="Arsha",Language = "C#",Age = 21},
    new(){Name ="Jinu",Language = "JS",Age = 25},
    new(){Name ="Finu",Language = "JS",Age = 24},
    new(){Name ="Manu",Language = "JS",Age = 23}
};

//var rsss = trainees.Where(m => m.Language == "C#");
//var rsss = trainees.OrderBy(m => m.Age);

//var result = trainees.GroupBy(m => m.Language);
//foreach (var grp in result)
//{
//    Console.WriteLine($"{grp.Key} has {grp.Count()} members");
//    foreach (var group in grp)
//    {
//        Console.WriteLine($"{group.Name} {group.Language}");
//    }
//}



var result1 = trainees.GroupBy(m => m.Language);
//var age = trainees.Min(m => m.Age);
//Console.WriteLine(age);
foreach (var grp in result1)
{
    //Console.WriteLine($"{grp.Key} has {grp.Count()} members");
    Console.WriteLine($"Youngest person of {grp.Key} has age {grp.Min(m => m.Age)}");
    var x = grp.Min(m => m.Age);
    var person = grp.FirstOrDefault(m => m.Age == x);
    Console.WriteLine(person.Name);
}
//var qqqq = from p in trainees where p.Language == "C#" select p;

class Trainee
{
    public string Name { get; set; }
    public string Language { get; set; }

    public int Age;
}

//var nums = Enumerable.Range(1, 100).ToArray();
//Console.WriteLine(String.Join(",",nums));