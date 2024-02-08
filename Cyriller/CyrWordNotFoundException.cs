using System;
using Cyriller.Model;

namespace Cyriller
{
    public class CyrWordNotFoundException : Exception
    {
        public CyrWordNotFoundException(string word)
            : base($"The word was not found in the collection. Word: [{word}].")
        {
            this.Word = word;
        }

        public CyrWordNotFoundException(string word, GendersEnum gender, CasesEnum @case, NumbersEnum number, AnimatesEnum animate)
            : base($"The word was not found in the collection. Word: [{word}], gender: [{gender}], case: [{@case}], number: [{number}], animte: [{animate}].")
        {
            this.Word = word;
            this.Gender = gender;
            this.Case = @case;
            this.Number = number;
            this.Animate = animate;
        }

        public string Word { get; protected set; }
        public GendersEnum Gender { get; protected set; }
        public CasesEnum Case { get; protected set; }
        public NumbersEnum Number { get; protected set; }
        public AnimatesEnum Animate { get; protected set; }
    }
}
