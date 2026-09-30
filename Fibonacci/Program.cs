using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int first = 0;
        int second = 1;

        Console.Write("Fibonacci sequence:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " ");

            int next = first + second;
            first = second;
            second = next;
        }
    }

}