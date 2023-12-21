using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static bool isArmStrongNum(int num)
        {
            int originalNum = num;
            int sum = 0;
            int numberOfDigits = (int)Math.Floor(Math.Log10(num) + 1);

            while (num != 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, numberOfDigits);
                num /= 10;
            }

            return sum == originalNum;
        }
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı giriniz: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (isArmStrongNum(number))
                {
                    Console.WriteLine($"{number} is an Armstrong Number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not an Armstrong Number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
