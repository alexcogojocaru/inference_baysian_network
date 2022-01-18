using System;
using System.Collections.Generic;
using System.Linq;

namespace IAProiect
{
    class NetworkValidator
    {
        private static int CONFIG_PARAMS_LEN = 6;

        public static bool validateFile(string content)
        {
            List<string> lines = content.Split('\n').ToList();

            foreach (var line in lines)
            {
                string[] config = line.Split(' ');
            
                if (config.Length != CONFIG_PARAMS_LEN)
                {
                    return false;
                }
                
            }

            return true;
        }
    }
}
