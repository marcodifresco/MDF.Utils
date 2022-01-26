using System;

namespace MDF.Utils
{
    public class MDFUtils
    {
        // Variables
        private const string version = "0.2.5";    // Version of the library

        // Return the version of this library
        public string Version()
        {
            return "Marco Di Fresco's utility library version " + version + ". " +CopyrightStatement("Marco Di Fresco");
        }

        // Return a generic copyright statement
        public string CopyrightStatement(string copyrightHolder)
        {
		    return "Copyright " + '\u00a9' + " by " + copyrightHolder + " - All Rights Reserved.";
	    }

        // Return a warning that the quality of the code is ... hobbistic
        public string CodeQualityWarning()
        {
            return "DISCLAIMER: this program and/or library is the result of hobbyistic programming and therefore it is provided AS IS without any guarantees or warranty.";
        }
    }
}
