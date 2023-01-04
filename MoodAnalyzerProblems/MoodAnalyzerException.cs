using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblems
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExpectionType
        {
            NULL, EMPTY, 
        }
        public ExpectionType type;
        public MoodAnalyzerException(ExpectionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
