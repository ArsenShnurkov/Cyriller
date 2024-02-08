using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cyriller.Model;

namespace Cyriller.Web.Models
{
    public abstract class CyrBaseDeclineResult
    {
        public string Name { get; set; }
        public string OriginalWord { get; set; }
        public string FoundWord { get; set; }
        public CasesEnum FoundCase { get; set; }
        public NumbersEnum FoundNumber { get; set; }
        public CyrResult Singular { get; set; }
        public CyrResult Plural { get; set; }

        public bool ExactMatch => this.OriginalWord == this.FoundWord;

        protected virtual string GetGenderStringRu(GendersEnum gender)
        {
            switch (gender)
            {
                case GendersEnum.Feminine: return "женский род";
                case GendersEnum.Neuter: return "средний род";
                case GendersEnum.Masculine: return "мужской род";
                default: return "неопределенный род";
            }
        }

        protected virtual string GetAnimatedStringRu(AnimatesEnum animate)
        {
            switch (animate)
            {
                case AnimatesEnum.Animated: return "одушевленное";
                case AnimatesEnum.Inanimated: return "неодушевленное";
                default: return string.Empty;
            }
        }

        protected virtual string GetWordTypeStringRu(WordTypesEnum wordType)
        {
            switch (wordType)
            {
                case WordTypesEnum.Abbreviation: return "аббревиатура";
                case WordTypesEnum.Name: return "имя";
                case WordTypesEnum.Surname: return "фамилия";
                case WordTypesEnum.Patronymic: return "отчество";
                case WordTypesEnum.Toponym: return "топоним";
                case WordTypesEnum.Organization: return "организация";
                default: return string.Empty;
            }
        }

        protected virtual string GetCaseStringRu(CasesEnum @case)
        {
            switch (@case)
            {
                case CasesEnum.Nominative: return "именительный падеж";
                case CasesEnum.Genitive: return "родительный падеж";
                case CasesEnum.Dative: return "дательный падеж";
                case CasesEnum.Accusative: return "винительный падеж";
                case CasesEnum.Instrumental: return "творительный падеж";
                case CasesEnum.Prepositional: return "предложный падеж";
                default: return string.Empty;
            }
        }

        protected virtual string GetNumberStringRu(NumbersEnum number)
        {
            switch (number)
            {
                case NumbersEnum.Singular: return "единственное число";
                case NumbersEnum.Plural: return "множественное число";
                default: return string.Empty;
            }
        }
    }
}