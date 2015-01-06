using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Cyriller.Model;

namespace Cyriller
{
    public partial class CyrWord
    {
        protected GendersEnum gender;
        protected AnimatesEnum animate;
        protected WordTypesEnum type;
        protected string[] cases;
        protected bool declinable;
        protected string w;

        public CyrWord(string Text, GendersEnum Gender, AnimatesEnum Animate)
            : this(Text, Gender, Animate, 0, true, null)
        {
        }

        public CyrWord(string Text, GendersEnum Gender, AnimatesEnum Animate, WordTypesEnum WordType)
            : this(Text, Gender, Animate, WordType, true, null)
        {
        }

        public CyrWord(string Text, GendersEnum Gender, AnimatesEnum Animate, WordTypesEnum WordType, bool Declinable)
            : this(Text, Gender, Animate, WordType, Declinable, null)
        {
        }

        public CyrWord(string Text, GendersEnum Gender, AnimatesEnum Animate, WordTypesEnum WordType, bool Declinable, string[] Cases)
        {
            this.w = Text;
            this.gender = Gender;
            this.animate = Animate;
            this.type = WordType;
            this.declinable = Declinable;
            this.cases = Cases;
        }

        public bool IsAnimated
        {
            get
            {
                return this.animate == AnimatesEnum.Animated;
            }
        }

        public string Word
        {
            get
            {
                return this.w;
            }
        }

        public GendersEnum Gender
        {
            get
            {
                return this.gender;
            }
        }

        public AnimatesEnum Animate
        {
            get
            {
                return this.animate;
            }
        }

        public WordTypesEnum WordType
        {
            get
            {
                return this.type;
            }
        }

        public CyrResult Decline()
        {
            if (this.type == WordTypesEnum.Surname)
            {
                return this.DeclineSurname();
            }

            if (this.type == WordTypesEnum.Name)
            {
                return this.DeclineName();
            }

            if (this.type == WordTypesEnum.Patronymic)
            {
                return this.DeclinePatronymic();
            }

            return this.DeclineNoun();
        }

        #region Patronymic.
        protected CyrResult DeclinePatronymic()
        {
            CyrName name = new CyrName();
            CyrResult result = new CyrResult(this.w,
                name.DeclinePatronymicGenitive(this.w, string.Empty, this.gender == GendersEnum.Feminine, false),
                name.DeclinePatronymicDative(this.w, string.Empty, this.gender == GendersEnum.Feminine, false),
                name.DeclinePatronymicAccusative(this.w, string.Empty, this.gender == GendersEnum.Feminine, false),
                name.DeclinePatronymicInstrumental(this.w, string.Empty, this.gender == GendersEnum.Feminine, false),
                name.DeclinePatronymicPrepositional(this.w, string.Empty, this.gender == GendersEnum.Feminine, false));

            return result;
        }
        #endregion

        #region Surname.
        protected CyrResult DeclineSurname()
        {
            CyrName name = new CyrName();
            CyrResult result = new CyrResult(this.w,
                name.DeclineSurnameGenitive(this.w, this.gender == GendersEnum.Feminine),
                name.DeclineSurnameDative(this.w, this.gender == GendersEnum.Feminine),
                name.DeclineSurnameAccusative(this.w, this.gender == GendersEnum.Feminine),
                name.DeclineSurnameInstrumental(this.w, this.gender == GendersEnum.Feminine),
                name.DeclineSurnamePrepositional(this.w, this.gender == GendersEnum.Feminine));

            return result;
        }
        #endregion

        #region Name
        protected CyrResult DeclineName()
        {
            CyrName name = new CyrName();
            CyrResult result = new CyrResult(this.w,
                name.DeclineNameGenitive(this.w, this.gender == GendersEnum.Feminine, false),
                name.DeclineNameDative(this.w, this.gender == GendersEnum.Feminine, false),
                name.DeclineNameAccusative(this.w, this.gender == GendersEnum.Feminine, false),
                name.DeclineNameInstrumental(this.w, this.gender == GendersEnum.Feminine, false),
                name.DeclineNamePrepositional(this.w, this.gender == GendersEnum.Feminine, false));

            return result;
        }
        #endregion

        #region Noun
        protected CyrResult DeclineNoun()
        {
            CyrResult result = null;

            result = this.DeclineNounExclusion();

            if (result != null)
            {
                return result;
            }

            if (w.RegexHasMatches("ийся$"))
            {
                result = this.DeclineNounIysya();
            }
            else if (w.RegexHasMatches("ина$"))
            {
                result = this.DeclineNounIna();
            }
            else if (w.RegexHasMatches("ца$"))
            {
                result = this.DeclineNounCa();
            }
            else if (w.RegexHasMatches("ча$"))
            {
                result = this.DeclineNounCha();
            }
            else if (w.RegexHasMatches("[ая]я$"))
            {
                result = this.DeclineNounAya();
            }
            else if (w.RegexHasMatches("мя$"))
            {
                result = this.DeclineNounMya();
            }
            else if (w.RegexHasMatches("льца$"))
            {
                result = this.DeclineNounLica();
            }
            else if (w.RegexHasMatches("онь$"))
            {
                result = this.DeclineNounOni();
            }
            else if (w.RegexHasMatches("оть$"))
            {
                result = this.DeclineNounOti();
            }
            else if (w.RegexHasMatches("тя$"))
            {
                result = this.DeclineNounTya();
            }
            else if (w.RegexHasMatches("[шщ]а$"))
            {
                result = this.DeclineNounSha();
            }
            else if (w.EndsWith("а") || w.EndsWith("я"))
            {
                result = this.DeclineNoun1();
            }
            else if (w.EndsWith("ель"))
            {
                result = this.DeclineNounEli();
            }
            else if (w.EndsWith("бок"))
            {
                result = this.DeclineNounBok();
            }
            else if (w.EndsWith("лок"))
            {
                result = this.DeclineNounLok();
            }
            else if (w.RegexHasMatches("[сф]ок$"))
            {
                result = this.DeclineNounSFok();
            }
            else if (w.RegexHasMatches("т[её]р$"))
            {
                result = this.DeclineNounTer();
            }
            else if (w.EndsWith("тос"))
            {
                result = this.DeclineNounTos();
            }
            else if (w.RegexHasMatches("ор$"))
            {
                result = this.DeclineNounOr();
            }
            else if (w.RegexHasMatches("орь$"))
            {
                result = this.DeclineNounOri();
            }
            else if (w.RegexHasMatches("ой$"))
            {
                result = this.DeclineNounOy();
            }
            else if (w.RegexHasMatches("[её]р$"))
            {
                result = this.DeclineNounEr();
            }
            else if (w.RegexHasMatches("док$"))
            {
                result = this.DeclineNounDok();
            }
            else if (w.RegexHasMatches("дой$"))
            {
                result = this.DeclineNounDoy();
            }
            else if (w.RegexHasMatches("дь$"))
            {
                result = this.DeclineNounDi();
            }
            else if (w.RegexHasMatches("рок$"))
            {
                result = this.DeclineNounRok();
            }
            else if (w.RegexHasMatches("тов$"))
            {
                result = this.DeclineNounTov();
            }
            else if (w.RegexHasMatches("ток$"))
            {
                result = this.DeclineNounTok();
            }
            else if (w.RegexHasMatches("шок$"))
            {
                result = this.DeclineNounShok();
            }
            else if (w.RegexHasMatches("кий$"))
            {
                result = this.DeclineNounKiy();
            }
            else if (w.RegexHasMatches("мий$"))
            {
                result = this.DeclineNounMiy();
            }
            else if (w.RegexHasMatches("ний$"))
            {
                result = this.DeclineNounNiy();
            }
            else if (w.RegexHasMatches("[её]ж$"))
            {
                result = this.DeclineNounEzh();
            }
            else if (w.RegexHasMatches("[её]к$"))
            {
                result = this.DeclineNounEk();
            }
            else if (w.RegexHasMatches("ец$"))
            {
                result = this.DeclineNounEc();
            }
            else if (w.RegexHasMatches("[её]л$"))
            {
                result = this.DeclineNounEl();
            }
            else if (w.RegexHasMatches("ен$"))
            {
                result = this.DeclineNounEn();
            }
            else if (w.RegexHasMatches("[её]с$"))
            {
                result = this.DeclineNounEs();
            }
            else if (w.RegexHasMatches("[её]й$"))
            {
                result = this.DeclineNounEy();
            }
            else if (w.RegexHasMatches("ень$"))
            {
                result = this.DeclineNounEni();
            }
            else if (w.RegexHasMatches("ож$"))
            {
                result = this.DeclineNounOzh();
            }
            else if (w.RegexHasMatches("ол$"))
            {
                result = this.DeclineNounOl();
            }
            else if (w.RegexHasMatches("он$"))
            {
                result = this.DeclineNounOn();
            }
            else if (w.RegexHasMatches("о[шщ]$"))
            {
                result = this.DeclineNounOsh();
            }
            else if (w.RegexHasMatches("и[жшщ]$"))
            {
                result = this.DeclineNounIsh();
            }
            else if (w.RegexHasMatches("ох$"))
            {
                result = this.DeclineNounOh();
            }
            else if (w.RegexHasMatches("зок$"))
            {
                result = this.DeclineNounZok();
            }
            else if (w.RegexHasMatches("вок$"))
            {
                result = this.DeclineNounVok();
            }
            else if (w.RegexHasMatches("мок$"))
            {
                result = this.DeclineNounMok();
            }
            else if (w.RegexHasMatches("чий$"))
            {
                result = this.DeclineNounChiy();
            }
            else if (w.EndsWith("овь"))
            {
                result = this.DeclineNounOvi();
            }
            else if (w.RegexHasMatches("яж$"))
            {
                result = this.DeclineNounYazh();
            }
            else if (w.RegexHasMatches("ие$"))
            {
                result = this.DeclineNounIe();
            }
            else if (this.gender == GendersEnum.Masculine || (this.gender == GendersEnum.Neuter && (w.EndsWith("о") || w.EndsWith("е"))))
            {
                result = this.DeclineNoun2();
            }
            else if (this.gender == GendersEnum.Feminine)
            {
                result = this.DeclineNoun3();
            }
            else
            {
                result = this.DeclineNoun2();
            }

            result = this.CheckNounYo(result);

            return result;
        }
        #endregion
    }
}
