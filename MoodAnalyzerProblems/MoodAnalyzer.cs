using System;

namespace MoodAnalyzerProblems
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer() { }

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyserMood()
        {

            try
            {
                if (message.ToLower().Contains("sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch
            {
                return "Happy";
            }
        }
    }
}
