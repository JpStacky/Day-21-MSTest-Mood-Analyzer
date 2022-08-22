namespace MoodAnalyzerProblem
{
    public class RefactorUC1
    {
        string
        RefactorUC1()
        {

        }
        public string analyseMood(string message)
        {
            string result = "Happy Mood";
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                result = "Sad Mood";
            else
                result = "Happy Mood";
            return result;
        }
    }
}
