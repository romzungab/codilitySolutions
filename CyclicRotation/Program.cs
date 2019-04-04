using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = 3;
            int[] a = { 3, 8, 9, 7, 6 };

            if (k == 0 || a.Length == 0)
            {
                foreach (var i in a)
                    Console.Out.Write(i);
            }
            else
            {
                var len = a.Length;
                int[] rot = new int[len];

                for (var i = 0; i < len; i++)
                {
                    if (i < (k % len))
                        rot[i] = a[(len - (k % len)) + i];
                    else
                        rot[i] = a[Math.Abs((k % len) - i)];

                }

                foreach (var i in rot)
                    Console.Out.Write(i);
                Console.Out.WriteLine();
            }
        }
    }
}

