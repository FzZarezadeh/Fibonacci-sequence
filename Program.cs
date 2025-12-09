using System;

namespace Fibonacci_sequence
{
    class Program
    {
        static int[] FibonacciSequence(int n)
        {
            int[] sequence = new int[n+1];

            if (n > 0) sequence[0] = 0;
            if (n > 1) sequence[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];
            }

            return sequence;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Fibonacci number:");
            int count = int.Parse(Console.ReadLine());

            int[] fibArray = FibonacciSequence(count);

            Console.WriteLine("Fibonacci sequence:");
            foreach (int num in fibArray)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
