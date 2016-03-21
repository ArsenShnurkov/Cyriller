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
            //string folder = @"E:\GitHub\Cyriller\Cyriller\App_Data";
            //ZipFile(folder, "nouns");
            //ZipFile(folder, "noun-rules");
            //ZipFile(folder, "adjectives");
            //ZipFile(folder, "adjective-rules");
            //return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }

        static void ZipFile(string FolderPath, string DictionaryName)
        {
            DirectoryInfo di = new DirectoryInfo(FolderPath);
            FileInfo fi = new FileInfo(Path.Combine(di.FullName, DictionaryName + ".gz"));

            if (fi.Exists)
            {
                fi.Delete();
            }

            FileStream read = new FileStream(Path.Combine(di.FullName, DictionaryName + ".txt"), FileMode.Open);
            FileStream writer = new FileStream(fi.FullName, FileMode.Create);
            GZipStream gzip = new GZipStream(writer, CompressionLevel.Optimal);

            read.CopyTo(gzip);
            read.Dispose();
            gzip.Dispose();
            writer.Dispose();
        }
    }
}
