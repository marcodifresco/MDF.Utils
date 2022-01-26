using System;

namespace MDF.Utils.System
{
    public class MDFUtilsSystem : MDFUtils
    {
        private string userDataFolder = "";
        public MDFUtilsSystem()
        {
        }

        public void SetUserDataFolder(string progName)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                userDataFolder = Environment.SpecialFolder.ApplicationData + progName;
            }
            else
            {
                userDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+ ".config/" + progName;
            }
        }

        public string GetUserDataFolder()
        {   // If the userDataFolder is empty, associate it with the base user folder
            if (userDataFolder == "")
            {
                SetUserDataFolder("");
            }

            return userDataFolder;
        }
    }
}
