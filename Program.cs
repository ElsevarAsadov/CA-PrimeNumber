
using System;

class Program
{
    static void Main()
    {
        int num = 23;

        if (num <= 1)
        {
            Console.WriteLine("number is not a prime");
        }
        else
        {
            bool isPrime = true;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("number is a prime");
            }
            else
            {
                Console.WriteLine("number is not a prime.");
            }
        }
    }
}
