using MoodAnalyserMSTest;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object expected1 = expected;
            object obj = MoodAnalyserReflector.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserMSTest.MoodAnalyser", "MoodAnalyser", null);
            Assert.AreEqual(expected, expected1);
        }
    }
}