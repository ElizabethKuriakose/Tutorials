using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial17Nov.ExtensionMethods;

internal static class OddOrEven
{
    //public static int FindOddorEven( this int i)
    //{
    //    var array = new int[] {1,2,3,4,5,6,7,8,9,10};
    //    foreach (var item in array)
    //    {
    //        if (item % 2 == 0)
    //            Console.WriteLine("Even");
    //        else
    //            Console.WriteLine("Odd");
    //    }
    //    i = 10;
    //    return i;
    //}
    public static int SpaceCount(this string name)
    {
        int count = 0;
        foreach (var item in name)
        {
            if(item == ' ')
            {
                count++;
            }
        }
        return count;
    }
}
