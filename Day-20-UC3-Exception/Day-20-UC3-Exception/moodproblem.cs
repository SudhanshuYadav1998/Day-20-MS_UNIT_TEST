using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20_UC3_Exception
{
    namespace MoodAnalyserProblem
    {
        /// <summary>
        ///Handling Exception
        /// </summary>
        public class MoodAnalyser
        {
            string message;
            public MoodAnalyser(string message)
            {
                this.message = message;
            }
            public string AnalyseMood()
            {
                try
                {
                    message = message.ToLower();
                    if (message.Equals(string.Empty))
                    {
                        throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");

                    }
                    if (message.Equals(null))
                    {
                        throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
                    }
                    if (message.Contains("sad"))
                    {
                        return "sad";
                    }
                    else
                    {
                        return "happy";
                    }
                }
                catch (NullReferenceException e)
                {
                    return "happy";
                }
            }
        }
    }
}
