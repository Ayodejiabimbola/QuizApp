using System.Text.Json;

public static class QuizLoader
{
    public static List<Question> LoadQuestions(string filePath)
    {
        try
        {
            string json = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Question>? questions = JsonSerializer.Deserialize<List<Question>>(json, options);
            return questions ?? new List<Question>();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: Could not find file at {filePath}");
            return new List<Question>();
        }
        catch (JsonException)
        {
            Console.WriteLine("Error: The questions file is not valid JSON.");
            return new List<Question>();
        }
    }
}