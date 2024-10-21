namespace SebMathewsLynchCA1.Classes;

public class HorseFile
{
    public static List<Horse> LoadHorseFromCsv(string filePath)
    {
        List<Horse> reserveHorses = new List<Horse>();

        try
        {
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines.Skip(1))  // Skip header
            {
                var fields = line.Split(',');  // Split by comma
                string horseName = fields[0];
                DateTime dob = DateTime.Parse(fields[1]);

                Horse horse = new Horse(horseName, dob);
                reserveHorses.Add(horse);
            }

            Console.WriteLine($"Loaded {reserveHorses.Count} reserve horses from {filePath}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not found: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        return reserveHorses;
    }
}