using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_ProjectFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring new array, with 3 rows, and 4 columns.
            int[,] a = new int[3, 4]
            {
                {0, 1, 2, 3} ,   /*  initializers for row indexed by 0 */
                {4, 5, 6, 7} ,   /*  initializers for row indexed by 1 */
                {8, 9, 10, 11}   /*  initializers for row indexed by 2 */
            };
            Console.WriteLine("\tExample Two");
            //Examples Showing I know how to navigate the array.
            Console.WriteLine($"Array position [1,3] returns {a[1, 3]}");
            Console.WriteLine($"Array position [2,0] returns {a[2, 0]}");
            Console.WriteLine($"Array position [0,3] returns {a[0, 3]}");
            Console.WriteLine($"Array position [1,1] returns {a[1, 1]}");
            //Reference: https://www.tutorialspoint.com/csharp/csharp_multi_dimensional_arrays.htm
        }
    }
}
