using MoodAnalyserMSTest;

Console.WriteLine("Welcome to MoodAnalyser MSTesting");
Console.WriteLine("Enter your mood to check");
string mood = Console.ReadLine();
MoodAnalyser obj = new MoodAnalyser();
Console.WriteLine($"The user mood is {obj.analyseMood(mood)}");
