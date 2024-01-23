using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SidM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jim Daley";            
            Console.WriteLine("// name");
            Console.WriteLine(name);
            Console.WriteLine("// length");
            int length = name.Length;
            Console.WriteLine(length);
            Console.WriteLine("// secondnamestart");
            int secondnamestart = name.IndexOf(' ') + 1;
            Console.WriteLine(secondnamestart);
            Console.WriteLine("// initial1");
            string initial1 = name.Substring(0, 1);
            Console.WriteLine(initial1);
            Console.WriteLine("// lastname");
            string lastname = name.Substring(secondnamestart, length-secondnamestart); 
            Console.WriteLine(lastname);
            Console.WriteLine("// initial1 + ' '+ lastname");
            Console.WriteLine(initial1 + ' '+ lastname);
        }
    }
}
