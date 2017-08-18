using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyriller.Model;

namespace Cyriller
{
    public class CyrPhrase
    {
        protected CyrNounCollection nounCollection;
        protected CyrAdjectiveCollection adjCollection;

        public CyrPhrase(CyrNounCollection NounCollection, CyrAdjectiveCollection AdjCollection)
        {
            this.nounCollection = NounCollection;
            this.adjCollection = AdjCollection;
        }

        public SpeechPartsEnum DetermineSpeechPart(string Word)
        {
            string[] ends = new string[] { "ый", "ий", "ой", "ся", "ая", "яя", "ое", "ее" };

            if (ends.Any(val => Word.EndsWith(val)))
            {
                return SpeechPartsEnum.Adjective;
            }

            return SpeechPartsEnum.Noun;
        }

        public CyrResult Decline(string Phrase, GetConditionsEnum Condition)
        {
            return this.Decline(Phrase, Condition, NumbersEnum.Singular);
        }

        public CyrResult DeclinePlural(string Phrase, GetConditionsEnum Condition)
        {
            return this.Decline(Phrase, Condition, NumbersEnum.Plural);
        }

        protected CyrResult Decline(string Phrase, GetConditionsEnum Condition, NumbersEnum Number)
        {
            if (Phrase.IsNullOrEmpty())
            {
                return new CyrResult();
            }

            List<object> words = new List<object>();
            string[] parts = Phrase.Split(' ').Select(val => val.Trim()).Where(val => val.IsNotNullOrEmpty()).ToArray();
            List<CyrResult> results = new List<CyrResult>();
            
            foreach (string w in parts)
            {
                SpeechPartsEnum speech = this.DetermineSpeechPart(w);

                switch (speech)
                {
                    case SpeechPartsEnum.Adjective:
                        CyrAdjective adj = this.adjCollection.Get(w, Condition);
                        words.Add(adj);
                        break;
                    case SpeechPartsEnum.Noun:
                        CyrNoun noun = this.nounCollection.Get(w, Condition);
                        words.Add(noun);
                        break;
                    default:
                        throw new ArgumentException("This speech part is not supported yet. Speech part: " + speech.ToString());
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                CyrNoun noun = words[i] as CyrNoun;

                if (noun != null)
                {
                    if (Number == NumbersEnum.Plural)
                    {
                        results.Add(noun.DeclinePlural());
                    }
                    else
                    {
                        results.Add(noun.Decline());
                    }
                    
                    continue;
                }

                CyrAdjective adj = words[i] as CyrAdjective;
                
                noun = this.GetNextPreviousNoun(words, i);

                if (Number == NumbersEnum.Plural)
                {
                    if (noun != null)
                    {
                        results.Add(adj.DeclinePlural(noun.Animate));
                    }
                    else
                    {
                        results.Add(adj.DeclinePlural(AnimatesEnum.Animated));
                    }
                }
                else
                {
                    if (noun != null)
                    {
                        results.Add(adj.Decline(noun.Animate));
                    }
                    else
                    {
                        results.Add(adj.Decline(AnimatesEnum.Animated));
                    }
                }
            }

            CyrResult result = results.First();

            for (int i = 1; i < results.Count; i++)
            {
                result = result + results[i];
            }

            return result;
        }

        protected CyrNoun GetNextPreviousNoun(List<object> Words, int Index)
        {
            CyrNoun noun = this.GetNextNoun(Words, Index);

            if (noun == null)
            {
                noun = this.GetPreviousNoun(Words, Index);
            }

            return noun;
        }

        protected CyrNoun GetNextNoun(List<object> Words, int Index)
        {
            for (int i = Index + 1; i < Words.Count; i++)
            {
                if (Words[i] is CyrNoun)
                {
                    return Words[i] as CyrNoun;
                }
            }

            return null;
        }

        protected CyrNoun GetPreviousNoun(List<object> Words, int Index)
        {
            for (int i = Index - 1; i >= 0; i--)
            {
                if (Words[i] is CyrNoun)
                {
                    return Words[i] as CyrNoun;
                }
            }

            return null;
        }
    }
}
