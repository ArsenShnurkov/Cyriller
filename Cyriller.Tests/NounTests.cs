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

                    foreach (Word word in words)
                    {
                        CyrNoun noun = nounCollection.Get(word.Name, GetConditionsEnum.Strict, (GendersEnum?)word.GenderID, (AnimatesEnum?)word.AnimateID, (WordTypesEnum?)word.TypeID);

                        Assert.NotNull(noun);
                        Assert.Equal(word.GenderID ?? 0, (int?)noun.Gender ?? 0);
                        Assert.Equal(word.AnimateID ?? 0, (int?)noun.Animate ?? 0);
                        Assert.Equal(word.TypeID ?? 0, (int?)noun.WordType ?? 0);

                        CyrResult result = noun.Decline();

                        Assert.NotNull(result);

                        for (int caseID = 1; caseID < 7; caseID++)
                        {
                            WordCase[] wordCases = word.WordCases.Where(x => x.CaseID == caseID && x.NumberID == 1).ToArray();

                            if (!wordCases.Any())
                            {
                                Assert.True(caseID == 1 || string.IsNullOrEmpty(result[caseID]), $"{word.ID}|{caseID} - {word.Name} - {result[caseID]}");
                            }
                            else
                            {
                                Assert.True(wordCases.Any(x => string.Compare(x.Name, result[caseID], true) == 0), $"{word.ID}|{caseID} - {word.Name} - {result[caseID]}");
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
