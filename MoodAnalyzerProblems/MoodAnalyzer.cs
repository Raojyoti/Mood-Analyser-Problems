using System;

namespace MoodAnalyzerProblems
{
    public class MoodAnalyzer
    {
        public string AnalyserMood(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}
