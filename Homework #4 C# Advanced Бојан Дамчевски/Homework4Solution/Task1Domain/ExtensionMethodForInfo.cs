using System;
using System.Collections.Generic;
using System.Text;

namespace Task1Domain
{
    public static class ExtensionMethodForInfo
    {
        public static void PrintInfo<T>(this List<T> shapes)
        {
            Console.WriteLine($"The number of this kind of shapes is {shapes.Count}, with type of {shapes[0].GetType()}");
        }
    }
}
