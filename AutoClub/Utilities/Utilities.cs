using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutoClub.Utilities
{
    public class Utilities
    {
        public static void RemoveFile(string file, string inimg, string webRootPath)
        {
            string path = webRootPath + @"\image\" + inimg + @"\" + file;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
