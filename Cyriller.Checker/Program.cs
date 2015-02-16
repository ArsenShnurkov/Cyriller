using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Cyriller.Checker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*FileInfo fi = new FileInfo(@"E:\Miyconst\Cyriller\Cyriller\App_Data\adjectives.gz");

            if (fi.Exists)
            {
                fi.Delete();
            }

            FileStream read = new FileStream(@"E:\Miyconst\Cyriller\Cyriller\App_Data\adjectives.txt", FileMode.Open);
            FileStream write = new FileStream(fi.FullName, FileMode.Create);
            GZipStream gzip = new GZipStream(write, CompressionLevel.Optimal);

            read.CopyTo(gzip);
            read.Dispose();
            gzip.Dispose();
            write.Dispose();*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}
