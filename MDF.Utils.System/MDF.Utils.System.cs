/*
 *  Provides integration with operative system functionalities 
 */
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace MDF.Utils.System
{
    public static class MDFUtilsSystem
    {
        private static string userDataFolder = "";
        
        // Set the data folder on the os user folder (ie /home/{user}/.config on Linux or C:\Users\{user} on Windows) 
        public static void SetUserDataFolder(string progName)
        {   // Get the base folder path
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                userDataFolder = Environment.SpecialFolder.ApplicationData + progName;
            }
            else
            {
                userDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+ "/.config/" + progName;
            }

            // Create the folder
            if (!Directory.Exists(userDataFolder))
            {
                Directory.CreateDirectory(userDataFolder);
            }
        }

        // Get the data folder on the OS user folder
        public static string GetUserDataFolder()
        {   // If the userDataFolder is empty, associate it with the base user folder
            if (userDataFolder == "")
            {
                SetUserDataFolder("");
            }

            return userDataFolder;
        }

        // Return the OS specific copyright symbol
        public static char CopyrightSymbol()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return '\xa9';
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
