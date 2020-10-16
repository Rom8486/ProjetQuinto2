using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "robot";
            char[] charArray = s.ToCharArray();

            foreach (char c in charArray)
            {
                Console.WriteLine(c);
            }
   

        }


    }
}