// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text.Json;
using System.Text.Json.Serialization;

//var obj = new
//{
//    Name = "Josmy",
//    Email = "josmy@yahoo.com"
//};

//var js = JsonSerializer.Serialize(obj);
//Console.WriteLine(js);


//-----------------------------------------------------------------------------------------

//var emp = new Employee();
//var js = JsonSerializer.Serialize(emp);
//Console.WriteLine(js);

//string json = "{\"Emp Id\":1,\"Name\":\"JOSMY\"}";
//string js = @"{""Emp Id"":1,""Name"":""JOSMY""}";
//string js = $@"";
//string jss = """

//    """;

//var obj = JsonSerializer.Deserialize<Employee>(json);
//Console.WriteLine(obj.Name);

//File write

//File.WriteAllText(@"C:\Users\elizabeth.kuriakose\Desktop\Tutorial\myfile.txt", "This is my text");


//var options = new JsonSerializerOptions()
//{
//    PropertyNameCaseInsensitive = true,
//    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
//    IncludeFields = true,
//    WriteIndented = true,
//};

////var emp = new Employee();

//Employee[] emp =
//{
//    new() {Id = 1, Name = "Jozzz", Email = "jozzz@gm.com"},
//    new() {Id = 2, Name = "Visss", Email = "visss.com"}
//};

////var employ = new List<Employee>
////{
////    new() {Id = 1, Name = "Jozzz", Email = "jozzz@gm.com"},
////    new() {Id = 2, Name = "Visss", Email = "visss.com"}
////};

//var js = JsonSerializer.Serialize(emp,options);
//File.WriteAllText(@"C:\Users\elizabeth.kuriakose\Desktop\Tutorial\Employee.json",js);

//var read = File.ReadAllText(@"C:\Users\elizabeth.kuriakose\Desktop\Tutorial\Employee.json");
//var userArray = JsonSerializer.Deserialize<Employee[]>(read,options);
////var employ = JsonSerializer.Deserialize<List<Employee>>(read,options);
//foreach (var item in userArray)
//{
//    Console.WriteLine($"Name : { item.Name} Email : {item.Email}");
//}

//class Employee
//{
//    [JsonPropertyName("Emp Id")]
//    public int Id { get; set; }
//    public string Name { get; set; } 

//    public string Email { get; set; }
//    public string Designation = "Employee";

//    [JsonIgnore]
//    public string Secret { get; set; }

//    //public Employee()
//    //{
//    //    Console.Write("Emp ID : ");
//    //    Id = int.Parse(Console.ReadLine());

//    //    Console.Write("Emp Name : ");
//    //    Name = Console.ReadLine();

//    //    Console.Write("Email : ");
//    //    Email = Console.ReadLine();
//    //}
//}

//Parallel.ForEach(arayname, functionToCall);


//deligates
//void Greet(string name, int mark)
//{
//    Console.WriteLine($"{name} {mark}");
//}

//void SayHi() => Console.WriteLine("Hi");

//Action<string, int> a = Greet;
//a("Maria", 100);

//MyDel d = Greet;
//d += SayHi;
//d();

//delegate void MyDel();


//whenever there is a return type instead of action use "FUNC"

//string GetName() => "Ann";

//Func<string> g = GetName;
//var res = g();
//Console.WriteLine(res);

// for boolean return types
//finding,filering,sorting(Applications)

//bool IsEven(int num) => num % 2 == 0;

//Predicate<int> boo = IsEven;
//Console.WriteLine(boo(10));

//---------------------------------------------------------------------

//void Find(Predicate<int> pred)
//{
//    int[] numbers = { 1, 2, 3, 4, 5 };
//    foreach (var item in numbers)
//    {
//        if (pred(item))
//        {
//            Console.WriteLine(item);
//        }
//    }
//}

//Find(FindEven);
//Find((i) => i % 2 != 0);
//bool FindEven(int i)
//{
//    return i % 2 == 0;
//}

//bool FindOdd(int i) => i % 2 != 0;

//-----------------------------------------------------------------------------

//Restuarant

Console.WriteLine("Options");
Console.WriteLine("1. ");