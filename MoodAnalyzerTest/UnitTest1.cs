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
        /*TC3.1 Given NULL Mood Should Throw MoodAnalysisException*/
        [Test]
        public void GivenNullMood_WhenAnalyzer_ShouldThrowMoodAnalyzerCustomException()
        {
            try
            {
                string message = null;
                MoodAnalyzer analyser = new MoodAnalyzer(message);
                string actual = analyser.AnalyserMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual("Mood should not be Null", e.Message);
            }
        }
        /*TC3.2 Given Empty Mood Should Throw MoodAnalysisException*/
        [Test]
        public void GivenEmptyMood_WhenAnalyzer_ShouldThrowMoodAnalyzerException()
        {
            try
            {
                string message = " ";
                MoodAnalyzer analyser = new MoodAnalyzer(message);
                string actual = analyser.AnalyserMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}