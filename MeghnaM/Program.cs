using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeghnaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullname = "Jim Daley";
            int length = fullname.Length;
            int space = fullname.IndexOf(' ');
            string initial = fullname.Substring(0,1);
            //string lastname = fullname.Substring(space, length - (space));
            string lastname = fullname.Substring(space + 1,length-(space+1));
            Console.WriteLine("// fullname");
            Console.WriteLine(fullname); 
            Console.WriteLine("// length");
            Console.WriteLine(length);
            Console.WriteLine("// space");
            Console.WriteLine(space);
            Console.WriteLine("// initial");
            Console.WriteLine(initial);
            Console.WriteLine("// lastname");
            Console.WriteLine(lastname);
            Console.WriteLine("// initial + lastname");
            //Console.WriteLine(initial + lastname);
            Console.WriteLine(initial + ' '+lastname);

        }
    }
}
