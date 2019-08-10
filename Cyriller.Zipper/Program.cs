using System;
using System.IO;
using System.IO.Compression;

namespace Cyriller.Zipper
{
    class Program
    {
        public const string OnlyIfSourceIsNewerMode = "OnlyIfSourceIsNewer";
        public const string AlwaysMode = "Always";

        static void Main(string[] args)
        {
            if (args.Length != 3 || (args[2] != OnlyIfSourceIsNewerMode && args[2] != AlwaysMode))
            {
                Console.WriteLine($"Usage: [SourceFilePath] [DestinationFilePath] [{OnlyIfSourceIsNewerMode} | {AlwaysMode}]");
                return;
            }

            string source = args[0];
            string destination = args[1];
            bool onlyIfSourceIsNewer = args[2] == OnlyIfSourceIsNewerMode;

            ZipFile(source, destination, onlyIfSourceIsNewer);

            Console.WriteLine($"File {source} has been zipped to {destination}.");
        }

        /// <summary>
        /// Compresses source file into a GZip archive using <see cref="GZipStream"/>.
        /// Throws <see cref="FileNotFoundException"/> if the source file does not exist.
        /// </summary>
        /// <param name="source">Full path to the source file.</param>
        /// <param name="destination">Full path to the destination file. Existing destination file will be deleted.</param>
        /// <param name="onlyIfSourceIsNewer">When set to true: no action will be taken if last write time of the source is less or equal of last write time of the destination.</param>
        private static void ZipFile(string source, string destination, bool onlyIfSourceIsNewer)
        {
            if (!File.Exists(source))
            {
                throw new FileNotFoundException(source);
            }

            if (onlyIfSourceIsNewer)
            {
                DateTime sourceLastWriteTime = File.GetLastWriteTime(source);
                DateTime destinationLastWriteTime = File.GetLastWriteTime(destination);

                if (sourceLastWriteTime <= destinationLastWriteTime)
                {
                    return;
                }
            }

            if (File.Exists(destination))
            {
                File.Delete(destination);
            }

            FileInfo sourceFi = new FileInfo(source);
            FileInfo destinationFi = new FileInfo(destination);

            FileStream read = new FileStream(sourceFi.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream writer = new FileStream(destinationFi.FullName, FileMode.Create);
            GZipStream gzip = new GZipStream(writer, CompressionLevel.Optimal);

            read.CopyTo(gzip);
            read.Dispose();
            gzip.Dispose();
            writer.Dispose();
        }
    }
}
