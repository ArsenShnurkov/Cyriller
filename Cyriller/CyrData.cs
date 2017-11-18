using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Collections.Concurrent;

namespace Cyriller
{
    internal class CyrData
    {
        public CyrData()
        { 
        }

        public TextReader GetData(string FileName)
        {
            Stream stream = typeof(CyrData).Assembly.GetManifestResourceStream("Cyriller.App_Data." + FileName);
            GZipStream gzip = new GZipStream(stream, CompressionMode.Decompress);
            TextReader treader = new StreamReader(gzip);

            return treader;
        }

        /// <summary>
        /// To do. Create a clever search algorithm.
        /// </summary>
        /// <param name="Word"></param>
        /// <param name="Collection"></param>
        /// <returns></returns>
        public string GetSimilar(string Word, List<string> Collection)
        {
            if (Word.IsNullOrEmpty())
            {
                return Word;
            }

            ConcurrentDictionary<string, int> keys = new ConcurrentDictionary<string, int>();

            /*foreach (string s in words.Keys)
            {
                if (s.EndsWith(Word))
                {
                    keys.Add(s, s.Length);
                }
            }*/

            Collection.AsParallel().ForAll(s =>
            {
                if (s.EndsWith(Word))
                {
                    keys.TryAdd(s, s.Length);
                }
            });

            if (!keys.Any() && Word.Length > 2)
            {
                return this.GetSimilar(Word.Substring(1), Collection);
            }

            string key = keys.OrderBy(val => val.Value).FirstOrDefault().Key;

            return key;
        }
    }
}
