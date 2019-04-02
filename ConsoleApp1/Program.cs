using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var s = Convert.ToString(2, 2).ToCharArray();

            var length = s.Length;
            var bg = 0;
            var max = 0;
            for (var i = 0; i < length; i++)
            {
                if (s[i] == '0')
                {
                    bg++;
                }
                else
                {
                    if (max < bg)
                    {
                        max = bg;
                        
                    }
                    bg = 0;
                }

                }

            Console.Out.WriteLine(max);
        }

    }
}