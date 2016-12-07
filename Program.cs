using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB.UnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two number separted by space:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(new char[] { ' ' },
                                        StringSplitOptions.RemoveEmptyEntries);
            double sum = Add(numbers);
            Console.WriteLine("Sum= {0}", sum);
        }

        public static double Add(string[] numbers)
        {
            double sum = 0;
            double result;
            for (int i = 0; i < numbers.Length; i++)
            {
                double.TryParse(numbers[i], out result);
                sum += result;
            }
            return sum;
        }

    }
}
