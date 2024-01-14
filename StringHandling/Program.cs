using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {   // STRING_TO_INT()
            try
            {
                //int numVal = Int32.Parse("abc");
                //int numVal = Int32.Parse("-105");
                // float numVal = float.Parse("3.14");
                // double numVal = double.Parse("3.14159");
                string noString = "-105";
               int numVal = int.Parse(noString);
                Console.WriteLine("numVal halved "+numVal/2);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            if (Int32.TryParse("-105", out int j))
            {
                Console.WriteLine("TryParse: "+j);
            }
            else
            {
                Console.WriteLine("String could not be parsed.");
            }

            int k;
            bool result = int.TryParse("-105", out k);
            if (result)
            {
                Console.WriteLine("Parsed Value : {0}", k);
            }
            else
            {
                Console.WriteLine("Coversion failed");
            }

            // INT_TO_STRING()
            int number = 789;
            string numberString = number.ToString();
            Console.WriteLine("number.ToString() " + numberString);

            int myInt = 789;
            string myString = Convert.ToString(myInt);
            Console.WriteLine("Convert.ToString() "+myString);
        }
    }
}
