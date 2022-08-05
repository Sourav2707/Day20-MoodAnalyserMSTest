using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserMSTest
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public void analyseMood()
        {
            if (this.message.ToUpper().Contains("SAD"))
                Console.WriteLine("The user mood is SAD");
            else
                Console.WriteLine("The user mood is HAPPY");
        }
    }
}
