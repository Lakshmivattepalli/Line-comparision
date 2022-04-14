
using Microsoft.VisualBasic.CompilerServices;
using Mood_Analyzer_Test;

namespace Mood_Analyzer_Test
{
    [TestClass]
    public class TestMood
    {
        public object Assert { get; private set; }

        [TestMethod]
        public void MsgSadMood()
        {
            string msg = "I am in sad mood";
            string expected = "SAD";

            MoodAnalyzer mood = new MoodAnalyzer(msg);

            string actual = mood.AnalyseMood();

            Assert.Equals(expected, actual);
        }

        public void MsgHaapyMood()
        {
            string msg = "I am in Any mood";
            string expected = "HAPPY";

            MoodAnalyzer mood = new MoodAnalyzer(msg);

            string actual = mood.AnalyseMood();

            Assert.Equals(expected, actual);
        }
    }
}
