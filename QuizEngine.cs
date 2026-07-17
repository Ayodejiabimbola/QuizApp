public class QuizEngine
{
    private List<Question> _questions;
    private int _currentQuestionIndex;
    private int _score;

    public QuizEngine(List<Question> questions)
    {
        _questions = questions;
        _currentQuestionIndex = 0;
        _score = 0;
    }

    public bool IsFinished => _currentQuestionIndex >= _questions.Count;
    public Question CurrentQuestion => _questions[_currentQuestionIndex];
    public int Score => _score;

    public bool SubmitAnswer(int answer)
    {
        Question currentQuestion = _questions[_currentQuestionIndex];
        bool isCorrect = (answer == currentQuestion.CorrectIndex);

        if (isCorrect)
        {
            _score++;
        }

        _currentQuestionIndex++;
        return isCorrect;
    }
}