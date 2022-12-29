using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first number");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers from {0} to {1} are:", n1, n2);

            for (int i = n1; i <= n2; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }
            Console.WriteLine("This project is made by Abdullh samir");
            return true;
            
        }
    }
}