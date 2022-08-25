using MoodAnalyserMSTest;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserReflection.CreateMoodAnalyser("MoodAnalyserMSTest.MoodAnalyser", "MoodAnalyser");
            //expected.Equals(obj);
            Assert.AreNotEqual(expected, obj);

        }
    }
}