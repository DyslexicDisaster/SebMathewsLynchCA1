namespace SebMathewsLynchCA1.Utilities;

public class Validators
{
    public static int GetValidInteger(string prompt)
    {
        int value = -1;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (value > 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }

    public static DateTime GetValidDate(string prompt)
    {
        DateTime value;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid date (e.g., 12/31/2024).");
            }
        }
    }

    public static string GetValidString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-empty value.");
            }
        }
    }
}