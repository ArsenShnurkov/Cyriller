using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyriller.Model;

namespace Cyriller
{
    public partial class CyrWord
    {
        protected CyrResult DeclineNounExclusion()
        {
            CyrResult r = null;

            if (this.cases != null)
            {
                r = new CyrResult(w, this.cases[0], this.cases[1], this.cases[2], this.cases[3], this.cases[4]);

                return r;
            }

            if (w.Contains("-"))
            {
                string[] modular = new string[] { "вагон-ресторан", "ванька-встанька", "город-герой", "город-спутник", "дед-мороз", "жук-скарабей", "комедия-буфф", "немка-меннонитка", "осетин-дигорец", "осетинка-дигорка", "осетин-иронец", 
                    "осетинка-иронка", "палестинка-христианка", "сыр-бор", "турчанка-месхетинка", "финка-ингерманландка", "финн-ингерманландец", "чеченец-аккинец", "чеченка-аккинка", "чижик-пыжик" };

                if (modular.Contains(w))
                {
                    return this.DeclineNounModular();
                }
            }
            
            string[] exclusions = new string[] { "буфф" };

            if (!this.declinable || exclusions.Contains(w))
            {
                r = new CyrResult(w);

                return r;
            }

            exclusions = new string[] { "псалом", "лоб", "оцет", "ров", "банчок", "рот", "хребет", "шов" };

            if (exclusions.Contains(w))
            {
                return this.DeclineNoun2WithoutSuffix();
            }

            return r;
        }

        protected CyrResult CheckNounYo(CyrResult Result)
        {
            string[] items = new string[] { "ёрш", "клёст", "ксёндз", "лёд", "лёт", "черёд", "осётр", "чёлн" };

            if (!items.Contains(w))
            {
                return Result;
            }

            return CutNounYo(Result);
        }

        protected CyrResult CutNounYo(CyrResult Result)
        {
            Result[2] = Result[2].Replace("ё", "е");
            Result[3] = Result[3].Replace("ё", "е");

            if (this.IsAnimated)
            {
                Result[4] = Result[4].Replace("ё", "е");
            }

            Result[5] = Result[5].Replace("ё", "е");
            Result[6] = Result[6].Replace("ё", "е");

            return Result;
        }

        protected CyrResult DeclineNounModular()
        {
            string[] parts = this.w.Split('-');
            CyrResult result = null;

            foreach (string part in parts)
            {
                CyrWord w = new CyrWord(part, this.gender, this.animate, this.type);
                CyrResult r = w.DeclineNoun();

                if (result == null)
                {
                    result = r;
                }
                else
                {
                    result.Add(r);
                }
            }

            return result;
        }
    }
}
