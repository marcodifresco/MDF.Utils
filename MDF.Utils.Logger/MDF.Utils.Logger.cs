using System;
using System.IO;

namespace MDF.Utils.Logger
{
    public class MDFUtilsLogger
    {
        private bool toConsole = false;
        private bool toFile = false;
        private StreamWriter logFileName;
        public MDFUtilsLogger() { }
        ~MDFUtilsLogger() { }

        public MDFUtilsLogger(string logFileToUse)
        {
            SetLogFileName(logFileToUse);
        }

        public void SetLogFileName(string logFileToUse)
        {
            // If only the log file name is provide, save it on the user data folder
            string temp = Path.GetDirectoryName(logFileToUse)!.Length == 0 ? "textadded"+logFileToUse : logFileToUse;
            //logFileName = Path.GetDirectoryName(logFileToUse)!.Length == 0 ? new StreamWriter("textadded"+logFileToUse) : new StreamWriter(logFileToUse);
            Console.WriteLine("Log file name: " + temp);
        }
    }
}
