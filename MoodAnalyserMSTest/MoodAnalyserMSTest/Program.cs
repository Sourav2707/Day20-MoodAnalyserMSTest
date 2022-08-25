using MoodAnalyserMSTest;

Console.WriteLine("Welcome to MoodAnalyser MSTesting");
object expected = new MoodAnalyser(null);
object obj = MoodAnalyserReflection.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserMSTest.MoodAnalyser", "MoodAnalyser", "HAPPY");
bool result = (expected.Equals(obj));
Console.WriteLine(result);