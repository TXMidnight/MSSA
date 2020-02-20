using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //put code that youre worried might have an error, in the try block.
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            //if it has an error, it will come to the catch block and execute the code here.
            catch (Exception e)
            {
                //outputs a standard message when it fails
                Console.WriteLine(e.Message);
                //or you can output a message that you define.
                Console.WriteLine("Something went wrong.");
            }
            //Reference: https://www.w3schools.com/cs/cs_exceptions.asp

        }

    }
}
