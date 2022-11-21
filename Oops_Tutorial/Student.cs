using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Tutorial
{
    internal class Student
    {
      
         public string Name;
         public int @Class;
         public int Mark1;
         public int Mark2;
        private int _age;

        public int Age
        {
            get { return _age; }
            set { 
                if( value < 18 || value > 50)
                {
                    Console.WriteLine("Invalid Age");
                    return;
                }
                _age = value; }
        }

        public int TotalMarks()
         {
             return Mark1 + Mark2;
         }
         public string Grade()
         {
             var tot = TotalMarks();
             if (tot >= 90)
                 return "A";
             else if (tot >= 80 && tot < 90)
                 return "B";
             else if(tot >= 70 && tot < 80)
                 return "C";
             else
                 return "D";
         }
         public void ReadData()
         {
             Console.WriteLine();
             Console.Write("Name : ");
             Name = Console.ReadLine();
             while (Age< 18 || Age> 50)
                 {
                     Console.Write("Age : ");
                     Age = int.Parse(Console.ReadLine());
                 }
      
             Console.Write("Class : ");
             @Class = int.Parse(Console.ReadLine());
             Console.Write("Mark 1 : ");
             Mark1 = int.Parse(Console.ReadLine());
             Console.Write("Mark 2 : ");
             Mark2 = int.Parse(Console.ReadLine());
         }
         public void ShowData()
         {
             Console.WriteLine();
             Console.WriteLine($"Name       : {Name}");
             Console.WriteLine($"Class      : {@Class}th");
             Console.WriteLine($"Age        : {_age}");
             Console.WriteLine($"Total Marks: {TotalMarks()}");
             Console.WriteLine($"Grade      : {Grade()}");
         }
     
    }
}
