using System;
using System.IO;

namespace MDF.Utils.Logger
{
    public class MDFUtilsLogger : MDFUtils
    {
        private bool toConsole = false;
        private bool toFile = false;
        private StreamWriter logFileName;
        MDFUtilsLogger() { }
        ~MDFUtilsLogger() { }

        MDFUtilsLogger(string logFileToUse)
        {
            SetlogFileName(logFileToUse);
        }

        void SetlogFileName(string logFileToUse)
        {
            if (Path.GetDirectoryName(logFileToUse).Length == 0)
            {
                Console.WriteLine("");
            }
        }
    }
}
