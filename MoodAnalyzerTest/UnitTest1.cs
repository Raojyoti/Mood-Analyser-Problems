using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MoodAnalyzerProblems;
using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        /*TC1.1 Given “I am in Sad Mood” message Should Return SAD*/
        [Test]
        public void GivenSadMessage_WhenAnalyzer_ShouldReturnSadMood()
        {
            //Arrange
            string message = "I am in Sad Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer();
            string actual = analyser.AnalyserMood(message);
            //Assert
            Assert.AreEqual(actual, "Sad");
        }
    }
}