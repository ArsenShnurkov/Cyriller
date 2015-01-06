using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Resources;
using Cyriller.Model;

namespace Cyriller
{
    public class CyrCollection
    {
        public Dictionary<string, string> words;

        public CyrCollection()
        {
            TextReader treader = new StreamReader(typeof(CyrCollection).Assembly.GetManifestResourceStream("Cyriller.App_Data.words.txt"));
            string line;

            words = new Dictionary<string, string>();
            line = treader.ReadLine();

            while (line != null)
            {
                string[] parts = line.Split(';');
                string key = parts[0];
                string value = parts[1];

                if (words.ContainsKey(key))
                {
                    words[key] += ";" + value;
                }
                else
                {
                    words.Add(key, value);
                }
                
                line = treader.ReadLine();
            }

            treader.Dispose();
        }

        public CyrWord Get(string Word)
        {
            string t = Word;
            string details = this.GetDetails(t);

            if (details.IsNullOrEmpty())
            {
                t = Word.ToLower();
                details = this.GetDetails(t);
            }

            if (details.IsNullOrEmpty())
            {
                t = Word.ToLower().UppercaseFirst();
                details = this.GetDetails(t);
            }

            if (details.IsNullOrEmpty())
            {
                List<int> indexes = new List<int>();
                string lower = Word.ToLower();

                for (int i = 0; i < lower.Length; i++)
                {
                    if (lower[i] == 'е')
                    {
                        indexes.Add(i);
                    }
                }

                foreach (int index in indexes)
                {
                    t = lower.Substring(0, index) + "ё" + lower.Substring(index + 1);
                    details = this.GetDetails(t);

                    if (details.IsNotNullOrEmpty())
                    {
                        break;
                    }
                }
            }

            if (details.IsNullOrEmpty())
            {
                throw new CyrWordNotFoundException(Word);
            }

            string[] parts = details.Split(';')[0].Split(',');
            int genderID = int.Parse(parts[0]);
            int animateID = int.Parse(parts[1]);
            int typeID = int.Parse(parts[2]);
            bool declinable = true;
            string[] cases = null;

            if (parts.Length == 4)
            {
                declinable = parts[3] == "1";
            }
            else if (parts.Length == 8)
            {
                declinable = false;
                cases = new string[] { parts[3], parts[4], parts[5], parts[6], parts[7] };
            }

            CyrWord word = new CyrWord(t, (GendersEnum)genderID, (AnimatesEnum)animateID, (WordTypesEnum)typeID, declinable);

            return word;
        }

        protected string GetDetails(string Word)
        {
            if (words.ContainsKey(Word))
            {
                return words[Word];
            }

            return null;
        }
    }
}
