using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// exception
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Hello");

            //string functions

            //string s = "Welcom to ooty. Nice to meet u";
            //Console.WriteLine(s.ToLower().StartsWith("wel"));//not efficient way
            //Console.WriteLine(s.StartsWith("wel",StringComparison.InvariantCultureIgnoreCase));//4 methods availabel. explore it.
            ////Console.WriteLine(s.Replace("E","q",true,null));
            //Console.WriteLine(s.Replace("E", "e").Replace("o","O"));
            //var arr = new string[] { "q", "w", "e", "r" };
            //Console.WriteLine(string.Join("",arr));

            ////int i = null;  error
            ////int? i = null;

            //var data = new int?[5];

            //foreach (var item in data)
            //    Console.WriteLine(item);

            //string dta = null;
            //Console.WriteLine(dta?.ToUpper());
            //// if there is no ? it will show a warning error. By puting ? it will call
            //// the toupper function only if it is non nullable

            //string name = null;
            //Console.WriteLine(name ?? "Unknown"); // null coalescsing operator
            //Console.WriteLine(name == null ? "UNKNOWN": name);

            string name1 = null;
            //name1 ??= "Unknown"; // null coalescsing assignment operator
            

            var arr1 = new int[6] {1,2,3,4,3,5};
            var arr2 = new int[6];
            int count = 0;
            bool hasFound = false;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i+1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        count++;
                    }
                }
                if(count >= 2)
                    {
                        hasFound = true;
                        break;
                    for (int k = 0; k < arr2.Length; k++)
                    {
                        if (arr2[k] == arr2[i])
                        {

                        }
                    }
                }
                
            }
        }   

    }
}
