using System;
using System.IO;

namespace MDF.Utils.Logger
{
    public class MDFUtilsLogger : MDFUtils
    {
        private bool toConsole = false;
        private bool toFile = false;
        private StreamWriter logFileName;
        public MDFUtilsLogger() { }
        ~MDFUtilsLogger() { }

        public MDFUtilsLogger(string logFileToUse)
        {
            SetlogFileName(logFileToUse);
        }

        public void SetlogFileName(string logFileToUse)
        {
            if (Path.GetDirectoryName(logFileToUse).Length == 0)
            {
                Console.WriteLine("");
            }
        }
    }
}
