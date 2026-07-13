List<Question> questions = QuizLoader.LoadQuestions("questions.json");

Console.WriteLine($"Loaded {questions.Count} questions.");

foreach (Question q in questions)
{
    Console.WriteLine($"- {q.Text} (Category: {q.Category})");
}