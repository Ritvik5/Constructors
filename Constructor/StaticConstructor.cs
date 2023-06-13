using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Employee1
    {
        static Employee1()
        {
            Console.WriteLine("\nThe Static constructor called.");
        }

        public static void Salary()
        {
            Console.WriteLine("\nThe salary method");
        }
    }
}
