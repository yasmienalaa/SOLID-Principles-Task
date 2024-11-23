namespace Basic_CSharp;

public static class B_Task_3
{
    /*
     * Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3)
     * and determines whether these points lie on a single straight line.
     */

    public static void Sol()
    {
        Console.Write("Enter first point (x,y): ");
        string answer1 = Console.ReadLine();
        Console.Write("Enter second point (x,y): ");
        string answer2 = Console.ReadLine();
        Console.Write("Enter third point (x,y): ");
        string answer3 = Console.ReadLine();

        try
        {
            // Parse input points
            string[] point1 = answer1.Trim('(', ')').Split(',');
            double x1 = double.Parse(point1[0].Trim());
            double y1 = double.Parse(point1[1].Trim());

            string[] point2 = answer2.Trim('(', ')').Split(',');
            double x2 = double.Parse(point2[0].Trim());
            double y2 = double.Parse(point2[1].Trim());

            string[] point3 = answer3.Trim('(', ')').Split(',');
            double x3 = double.Parse(point3[0].Trim());
            double y3 = double.Parse(point3[1].Trim());

            // Check if points lie on a single straight line
            // Using the area of the triangle formed by the points: Area = 0 if collinear
            double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

            if (area == 0)
            {
                Console.WriteLine("The points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("The points do not lie on a single straight line.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please use the format (x,y) with numeric values.");
        }
    }
}