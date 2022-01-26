/*
 *  Provides integration with operative system functionalities 
 */
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace MDF.Utils.System
{
    public class MDFUtilsSystem : MDFUtils
    {
        private string userDataFolder = "";
        public MDFUtilsSystem() {}

        // Set the data folder on the os user folder (ie /home/{user}/.config on Linux or C:\Users\{user} on Windows) 
        public void SetUserDataFolder(string progName)
        {   // Get the base folder path
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                userDataFolder = Environment.SpecialFolder.ApplicationData + progName;
            }
            else
            {
                userDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+ "/.config/" + progName;
            }

            // Create the folder
            if (!Directory.Exists(progName))
            {
                Directory.CreateDirectory(progName);
            }
        }

        // Get the data folder on the OS user folder
        public string GetUserDataFolder()
        {   // If the userDataFolder is empty, associate it with the base user folder
            if (userDataFolder == "")
            {
                SetUserDataFolder("");
            }

            return userDataFolder;
        }

        public char CopyrightSymbol()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return "\xc2\xa9";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return '\xa9';
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return '\xa9';
            }

            // Generic return
            return '\xa9';
        }
    }
}
