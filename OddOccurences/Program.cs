using System;
using System.Linq;

namespace OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 9, 3, 9, 3, 9, 7, 9, 7, 9,9,9,9,7,7,9,244,9, 244, 523232 , 2,2};
            Console.Out.WriteLine(a.Aggregate((x, y) => x ^ y)); //using aggregate and XOR operator
        }
    }
}
