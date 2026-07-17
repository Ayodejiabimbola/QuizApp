List<Question> questions = QuizLoader.LoadQuestions("questions.json");
QuizEngine engine = new QuizEngine(questions);

while (!engine.IsFinished)
{
    Console.WriteLine(engine.CurrentQuestion.Text);
    for (int i = 0; i < engine.CurrentQuestion.Options.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {engine.CurrentQuestion.Options[i]}");
    }

    Console.Write("Enter Your Answer: ");
    int userAnswer = Convert.ToInt32(Console.ReadLine());

    bool isCorrect = engine.SubmitAnswer(userAnswer - 1);

    if (isCorrect)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine("Wrong!");
    }

    Console.WriteLine();
}

Console.WriteLine($"Quiz finished! Your score: {engine.Score}/{questions.Count}");