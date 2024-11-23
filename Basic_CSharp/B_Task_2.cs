namespace Basic_CSharp;

public static class B_Task_2
{
    /*
     * Write a program in C# Sharp to convert a decimal number into binary without using an array
     */

    public static void Sol()
    {
        Console.WriteLine("Enter a decimal number:");
        int number = Convert.ToInt32(Console.ReadLine());
        string answer = string.Empty;

        while (number > 0)
        {
            answer = (number % 2 == 0 ? "0" : "1") + answer;
            number /= 2;
        }

        Console.WriteLine($"Binary representation: {answer}");
    }
}