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
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(actual, "Sad");
        }
        /*TC1.2 Given “I am in Any Mood” message Should Return SAD*/
        [Test]
        public void GivenAnyMessage_WhenAnalyzer_ShouldReturnHappyMood()
        {
            //Arrange
            string message = "I am in Any Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
    }
}