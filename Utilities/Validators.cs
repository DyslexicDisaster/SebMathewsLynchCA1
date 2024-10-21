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
            if (int.TryParse(input, out value) && value > 0)
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
                if (value > DateTime.Now)
                {
                    return value;  
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a date in the future.");
                }
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

    public static DateTime GetValidHorseDOB(string prompt)
    {
        DateTime dob;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out dob))
            {
                // Validation: Ensure the horse's DOB is not in the future and not more than 30 years ago
                if (dob <= DateTime.Now && dob >= DateTime.Now.AddYears(-30))
                {
                    return dob;
                }
                else
                {
                    Console.WriteLine(
                        "Invalid date. The horse must be born within the last 30 years and not in the future.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid date (e.g., 01/01/2015).");
            }
        }
    }
}