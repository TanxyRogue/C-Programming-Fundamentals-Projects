using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] nums = { 12, 34 };
            decimal divider;
            
            Reboot:

            try
            {
                start:
                Console.WriteLine("Enter a denominator to divide the numbers : {0} and {1}", nums[0], nums[1]);
                divider = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\n{0} divided by {1} is {2}", nums[0], divider, nums[0] / divider);
                Console.WriteLine("{0} divided by {1} is {2}", nums[1], divider, nums[1] / divider);
                Console.ReadKey();
                Console.Clear();
                goto start;
            }
            catch(Exception e)
            {
                divider = 0;

                Console.WriteLine(e.Message);
                Console.ReadKey(true);
                Console.Clear();
                goto Reboot;
            }
            
        }
    }
}
