namespace Basic_CSharp;

public static class B_Task_4
{
    /*
     * Write a program in C# Sharp to merge two sorted arrays of the same size
     * to get a sorted result in ascending order.
     */

    public static void Sol()
    {
        Console.Write("Enter the size of the arrays: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the first array elements (space-separated, sorted): ");
        int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

        Console.WriteLine("Enter the second array elements (space-separated, sorted): ");
        int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

        // Validate sizes
        if (arr1.Length != size || arr2.Length != size)
        {
            Console.WriteLine("Error: The size of the arrays does not match the specified size.");
            return;
        }

        int[] answer = new int[size * 2];
        int L1 = 0, L2 = 0, L3 = 0;

        // Merge the two arrays
        while (L1 < size && L2 < size)
        {
            if (arr1[L1] <= arr2[L2])
            {
                answer[L3++] = arr1[L1++];
            }
            else
            {
                answer[L3++] = arr2[L2++];
            }
        }

        // Copy any remaining elements from arr1
        while (L1 < size)
        {
            answer[L3++] = arr1[L1++];
        }

        // Copy any remaining elements from arr2
        while (L2 < size)
        {
            answer[L3++] = arr2[L2++];
        }

        Console.Write($"Merged sorted array: {string.Join(" ", answer)}");
    }
}