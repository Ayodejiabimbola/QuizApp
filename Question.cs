public class Question(string text, List<string> options, int correctindex, string category)
{
    public string Text { get; set; } = text;
    public List<string> Options { get; set; } = options;
    public int CorrectIndex { get; set; } = correctindex;
    public string Category { get; set; } = category;
}

