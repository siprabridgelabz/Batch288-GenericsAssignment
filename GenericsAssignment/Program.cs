using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            float num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            float num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number");
            float num3 = Convert.ToInt32(Console.ReadLine());

            float val = Maximum.MaximumFloatNumber(num1, num2, num3);
            Console.WriteLine("{0} IS GREATER  NUMBER.", val);
        }
    }
}
