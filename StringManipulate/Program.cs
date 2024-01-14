using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulate
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string StrExp = "The quick brown fox jumped over the lazy dog";
            Console.WriteLine("The string is "+StrExp);
            Console.WriteLine();
            // LEN(StringExp) 
            int StrLen = StrExp.Length;
            Console.WriteLine("LEN(StringExp)");
            Console.WriteLine("The string is " + StrLen + " characters long");

            // POSITION(StringExp, CharExp) 
            Console.WriteLine();
            Console.WriteLine("POSITION(StringExp, CharExp)");
            int StrPos = StrExp.IndexOf("z");
            Console.WriteLine("The 'z' is at position " + StrPos);

            // SUBSTRING(Int1, Int2, StringExp) 
            Console.WriteLine();
            Console.WriteLine("SUBSTRING(Int1, Int2, StringExp)");
            string StrSub = StrExp.Substring(StrPos);
            Console.WriteLine("The substring from 'z' is: '" + StrSub+"'");
            Console.WriteLine();
        }
    }
}
