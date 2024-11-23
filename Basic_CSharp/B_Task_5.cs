namespace Basic_CSharp;

public static class B_Task_5
{
    /*
     *              write a program find the longest distance between Two equal cells
     */

    public static void Sol()
    {
        Console.Write("Enter the size of the arrays: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the array elements (space-separated, sorted): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

        Dictionary<int, int> mp = new Dictionary<int, int>();
        int res = 0;

        // Traverse elements and find maximum distance
        for (int i = 0; i < arr.Length; i++)
        {

            //    If this is the first occurrence of the element, store its index
            if (!mp.ContainsKey(arr[i]))
            {
                mp[arr[i]] = i;
            }
            else
            {
                res = Math.Max(res, i - mp[arr[i]]);
            }
        }
        
        Console.WriteLine($"Max distance is: {res}");
    }
}