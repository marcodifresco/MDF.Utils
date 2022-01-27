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

        ~MdfUtilsLogger()
        {
            _logFileName.Close();
        }

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

        public void SetLogToConsole(bool console)
        {
            _toConsole = console;
        }

        public void SetLogToFile(bool file)
        {
            _toFile = file;
        }

        public void Log(string message)
        {   // If no backend is enabled, enable console
            if (!_toConsole && !_toFile)
            {
                Console.WriteLine("No backend enabled. Forcing to console.");
                this.SetLogToConsole(true);
            }
            
            // Console
            if (_toConsole)
            {
                Console.WriteLine(message);
            }

            if (_toFile)
            {
                _logFileName.Write(message);
            }
        }
    }
}
