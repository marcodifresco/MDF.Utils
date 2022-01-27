using System;
using System.IO;
using MDF.Utils.System;

namespace MDF.Utils.Logger
{
    public class MdfUtilsLogger
    {
        private bool _toConsole = false;
        private bool _toFile = false;
        private StreamWriter _logFileName;
        public MdfUtilsLogger() { }
        ~MdfUtilsLogger() { }

        public MdfUtilsLogger(string logFileToUse)
        {
            SetLogFileName(logFileToUse);
        }

        public void SetLogFileName(string logFileToUse)
        {
            // If only the log file name is provide, save it on the user data folder
            _logFileName = (Path.GetDirectoryName(logFileToUse)!.Length == 0)
                ? new StreamWriter(MdfUtilsSystem.GetUserDataFolder() + logFileToUse)
                : new StreamWriter(logFileToUse);
        }
    }
}
