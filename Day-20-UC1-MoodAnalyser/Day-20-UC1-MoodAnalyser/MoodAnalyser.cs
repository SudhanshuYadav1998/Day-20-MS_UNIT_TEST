using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser()
        {
        }
        public string analyseMood()
        {
            //"null"==""
            //string s = null;

            //string abc = "";
            try
            {   
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
           
            catch (MoodAnalyserCustomException ex)
            {
                Console.WriteLine("this is our custom exception");
            }
            finally
            {
                Console.WriteLine("This code will always execute irrespective of exception came or not!!!!");
            }
            return null;
        }
    }


public class MoodAnalyserCustomException : Exception
{
    public enum ExceptionType
    {
        NULL_MESSAGE,
        EMPTY_MESSAGE,
        NO_SUCH_FIELD,
        NO_SUCH_METHOD,
        NO_SUCH_CLASS,
        OBJECT_CREATION_ISSUE
    }
   
}


