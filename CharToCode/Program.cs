using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharToCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert char to ASCII code
            char myChar = 'A';
            int asciiCode = (int)myChar;

            // Display the result
            Console.WriteLine("Convert char to ASCII code");
            Console.WriteLine("Character: "+ myChar);
            Console.WriteLine("ASCII Code: "+ asciiCode);

            // Convert int to char
            int asciiCode2 = 97;  // ASCII code for 'a'
            char myChar2 = (char)asciiCode2;

            // Display the result
            Console.WriteLine("Convert ASCII code to char");
            Console.WriteLine("ASCII Code: "+asciiCode2);
            Console.WriteLine("Character: " + myChar2);
        }
    }
}
