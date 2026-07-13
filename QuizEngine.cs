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
}