using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblems
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExpectionType
        {
            NULL, EMPTY, NO_SUCH_CLASS, NO_SUCH_METHOD, NO_SUCH_FIELD
        }
        public ExpectionType type;
        public MoodAnalyzerException(ExpectionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
