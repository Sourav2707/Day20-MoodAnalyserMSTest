using MoodAnalyserMSTest;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyser obj = new MoodAnalyser("");
            string result = obj.analyseMood();
            Assert.AreEqual(null, result);
        }
    }
}