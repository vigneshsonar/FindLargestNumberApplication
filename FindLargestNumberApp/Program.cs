using System;
using System.Linq;

namespace FindLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the values by using comma separator!");
                var value = Console.ReadLine();
                int[] numbers = Array.ConvertAll(value.Split(','), s => int.Parse(s));
                int result = Max(numbers);
                Console.WriteLine("The largest number is " + result);
                Console.ReadKey();
                Main(new string[] { });
            }
            catch (Exception ex)
            {

                Console.WriteLine("Largest number cannot be determined.Pleasee see the below error message.\n\n" + "\"" + ex.Message + "\"");
                Console.ReadKey();
                Main(new string[] { });
            }
        }
        static int Max(int[] numbers)
        {
            try
            {
                return numbers.Max();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
