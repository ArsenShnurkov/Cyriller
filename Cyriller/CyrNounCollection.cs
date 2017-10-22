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
    public class CyrNounCollection
    {
        protected Dictionary<int, string> rules = new Dictionary<int, string>();
        protected Dictionary<string, string> words = new Dictionary<string, string>();

        public CyrNounCollection()
        {
            CyrData data = new CyrData();
            TextReader treader = data.GetData("noun-rules.gz");
            string line;
            string[] parts;

            line = treader.ReadLine();

            while (line != null)
            {
                parts = line.Split(' ');
                rules.Add(int.Parse(parts[0]), parts[1]);
                line = treader.ReadLine();
            }

            treader.Dispose();
            treader = data.GetData("nouns.gz");
            line = treader.ReadLine();

            while (line != null)
            {
                parts = line.Split(' ');

                if (!words.ContainsKey(parts[0]))
                {
                    words.Add(parts[0], parts[1]);
                }

                line = treader.ReadLine();
            }

            treader.Dispose();
        }

        public CyrNoun Get(string Word)
        {
            return this.Get(Word, GetConditionsEnum.Strict);
        }

        public CyrNoun Get(string Word, GetConditionsEnum Condition)
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

            if (details.IsNullOrEmpty() && Condition == GetConditionsEnum.Similar)
            {
                details = this.GetSimilarDetails(Word, out t);
            }

            if (details.IsNullOrEmpty())
            {
                throw new CyrWordNotFoundException(Word);
            }

            string[] parts = details.Split(',');
            int genderID = int.Parse(parts[0]);
            int animateID = int.Parse(parts[1]);
            int typeID = int.Parse(parts[2]);
            int ruleID = int.Parse(parts[3]);
            
            parts = this.rules[ruleID].Split(new char[] { ',', '|' });

            CyrRule[] rules = parts.Select(val => new CyrRule(val)).ToArray();
            CyrNoun noun = new CyrNoun(Word, t, (GendersEnum)genderID, (AnimatesEnum)animateID, (WordTypesEnum)typeID, rules);

            return noun;
        }

        protected string GetSimilarDetails(string Word, out string CollectionWord)
        {
            CyrData data = new CyrData();
            
            CollectionWord = data.GetSimilar(Word, words.Keys.ToList());

            if (CollectionWord.IsNullOrEmpty())
            {
                return null;
            }

            return this.GetDetails(CollectionWord);
        }

        protected string GetDetails(string Word)
        {
            if (Word.IsNullOrEmpty())
            {
                return null;
            }

            if (words.ContainsKey(Word))
            {
                return words[Word];
            }

            return null;
        }
    }
}
