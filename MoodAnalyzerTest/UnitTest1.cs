using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MoodAnalyzerProblems;
using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        /*Refactor1.1 Given “I am in Sad Mood” message Should Return SAD*/
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
        /*Refactor1.2 Given “I am in Happy Mood” message Should Return SAD*/
        [Test]
        public void GivenAnyMessage_WhenAnalyzer_ShouldReturnHappyMood()
        {
            //Arrange
            string message = "I am in Happy Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
        /*TC2.1 Given Null Mood Should Return Happy*/
        [Test]
        public void GivenNullMood_WhenAnalyzer_ShouldThrowMoodAnalyzerCustomException()
        {
            //Arrange
            string message = null;
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
    }
}