namespace OOP_CSharp;

public enum Seasons
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public static class OOP_Task_1
{
    /*
     * Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter)
     * Write a C# program that takes a season name as input from the user
     * and displays the corresponding month range for that season.
     * Spring: March to May
     * Summer: June to August
     * Autumn: September to November
     * Winter: December to February
     */

    public static void Sol()
    {
        Console.Write("Enter the season name: ");
        string input = Console.ReadLine();

        if (Enum.TryParse<Seasons>(input,out Seasons season))
        {
            switch (season)
            {
                case Seasons.Spring:
                    Console.WriteLine("Spring: March to May");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("Summer: June to August");
                    break;
                case Seasons.Autumn:
                    Console.WriteLine("Autumn: September to November");
                    break;
                case Seasons.Winter:
                    Console.WriteLine("Winter: December to February");
                    break;
                default:
                    Console.WriteLine("Invalid season");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid season. Please enter Spring, Summer, Autumn, or Winter.");
        }
    }
}