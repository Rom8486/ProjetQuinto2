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

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

        }
        

    }
}