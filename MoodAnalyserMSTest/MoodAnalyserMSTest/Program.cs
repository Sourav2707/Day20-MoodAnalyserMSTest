using MoodAnalyserMSTest;

Console.WriteLine("Welcome to MoodAnalyser MSTesting");
object expected = new MoodAnalyser(null);
object obj = MoodAnalyserReflection.CreateMoodAnalyser("MoodAnalyserMSTest.MoodAnalyser", "MoodAnalyser");
bool result = (expected.Equals(obj));
Console.WriteLine(result);