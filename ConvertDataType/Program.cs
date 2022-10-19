using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            decimal yearlyIncome;

            Console.Write("Your Name : ");
            name = Console.ReadLine();

            Console.Write("Your Age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your Yearly Income : ");
            yearlyIncome = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"{name} of age {age} income/year {yearlyIncome:0.00}");


            Console.ReadKey();

        }
    }
}
