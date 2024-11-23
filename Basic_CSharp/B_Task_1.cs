namespace Basic_CSharp
{
    public static class B_Task_1
    {
        /*
         * Write a program in C# Sharp to find prime numbers within a range of numbers.
         */

        public static void Sol()
        {
            Console.WriteLine("Enter the lower bound of a range: ");
            int lower = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the upper bound of a range: ");
            int upper = int.Parse(Console.ReadLine());

            if (lower < 2)
                lower = 2;

            for (int i = lower; i <= upper; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}