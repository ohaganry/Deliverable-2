using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int checksum = 0;
            Console.WriteLine("Input your message");
            string input = Console.ReadLine();
            Console.Write("Your coded message: ");
            foreach (char c in input)
            {
                int message = char.ToUpper(c) - 64;
                Console.Write(message + "-");

                checksum += char.ToUpper(c);
            }
            Console.WriteLine();
            Console.WriteLine("Checksum: " + checksum);

        }
    }
}