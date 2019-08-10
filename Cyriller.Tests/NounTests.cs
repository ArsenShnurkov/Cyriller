using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xunit;
using Cyriller.Model;
using Cyriller.Tests.Model;

namespace Cyriller.Tests
{
    public class NounTests
    {
        public NounTests()
        {
        }

        ~NounTests()
        {
        }

        [Fact]
        public void Nouns()
        {
            int speechPartNountID = 1;
            CyrNounCollection nounCollection = new CyrNounCollection();
            CyrillerEntities mainDB = new CyrillerEntities();
            int count = mainDB.Words.Where(x => x.SpeechPartID == speechPartNountID).Count();
            int step = 1000;
            List<Task> tasks = new List<Task>();

            mainDB.Dispose();

            for (int i = 0; i < count; i += step)
            {
                int skip = i;

                tasks.Add(Task.Run(() =>
                {
                    CyrillerEntities db = new CyrillerEntities();
                    IQueryable<Word> words = db.Words.Where(x => x.SpeechPartID == speechPartNountID).OrderBy(x => x.ID).Skip(skip).Take(step);

                    foreach (Word iterator in words)
                    {
                        CyrNoun noun = nounCollection.Get(iterator.Name, (GendersEnum)(iterator.GenderID ?? 0), CasesEnum.Nominative, NumbersEnum.Singular);

                        Assert.NotNull(noun);

                        // There might be multiple the same words in the database, one animated, another one not.
                        int animateID = (int)noun.Animate;
                        int genderID = (int)noun.Gender;
                        Word word = db.Words.FirstOrDefault(x => 
                            x.Name == noun.Name && 
                            x.AnimateID == animateID &&
                            (x.GenderID ?? 0) == genderID
                        );

                        Assert.NotNull(word);
                        Assert.True((word.GenderID ?? 0) == ((int?)noun.Gender ?? 0), $"{word.ID}|{word.Name} - wrong gender [{noun.Gender}], expected [{word.Gender?.Name}].");
                        Assert.True((word.AnimateID ?? 0) == ((int?)noun.Animate ?? 0), $"{word.ID}|{word.Name} - wrong animate [{noun.Animate}], expected [{word.Animate?.Name}].");
                        Assert.True((word.TypeID ?? 0) == ((int?)noun.WordType ?? 0), $"{word.ID}|{word.Name} - wrong type [{noun.WordType}], expected [{word.WordType?.Name}].");

                        CyrResult result = noun.Decline();

                        Assert.NotNull(result);

                        for (int caseID = 1; caseID < 7; caseID++)
                        {
                            WordCase[] wordCases = word.WordCases.Where(x => x.CaseID == caseID && x.NumberID == 1).ToArray();
                            string errorMessage = $"{word.ID}|{caseID} - wrong case [{result[caseID]}], expected [{word.Name}].";

                            if (!wordCases.Any())
                            {
                                Assert.True(caseID == 1 || string.IsNullOrEmpty(result[caseID]), errorMessage);
                            }
                            else
                            {
                                Assert.True(wordCases.Any(x => string.Compare(x.Name, result[caseID], true) == 0), errorMessage);
                            }
                        }
                    }

                    db.Dispose();
                }));
            }

            Task.WaitAll(tasks.ToArray());
        }
    }
}
