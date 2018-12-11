using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Cyriller
{
    public class CyrRule
    {
        /// <summary>
        /// Number of character to cut from the end of the word when applying this rule.
        /// </summary>
        protected int cut;

        /// <summary>
        /// New word ending to append to the end of the word after <see cref="CyrRule.cut"/> characters is cut from the end.
        /// </summary>
        protected string end;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rule">
        /// String describing declension rule.
        /// For example:
        /// "ен2" - cut 2 characters from the end, then append "ен" at the end.
        /// "ым" - do not cut any characters from the end, but append "ым" at the end.
        /// "*" - the rule is not applicable, will always return <see cref="String.Empty"/> when applied with <see cref="CyrRule.Apply(string)"/>.
        /// </param>
        public CyrRule(string Rule)
        {
            if (string.IsNullOrEmpty(Rule))
            {
                this.end = string.Empty;
                this.cut = 0;
                return;
            }

            Regex reg = new Regex(@"\d", RegexOptions.IgnoreCase);
            string temp;

            this.end = reg.Replace(Rule, string.Empty);

            if (this.end.Length > 0)
            {
                temp = Rule.Replace(this.end, string.Empty);
            }
            else
            {
                temp = Rule;
            }

            if (temp.IsNullOrEmpty())
            {
                this.cut = 0;
            }
            else
            {
                this.cut = int.Parse(temp);
            }
        }

        /// <summary>
        /// Applies declension rule on the specified word.
        /// </summary>
        /// <param name="Name">The word to apply declension to.</param>
        /// <returns></returns>
        public string Apply(string Name)
        {
            if (this.end == "*")
            {
                return string.Empty;
            }

            int length = Name.Length - cut;

            if (length <= 0)
            {
                return this.end;
            }

            return Name.Substring(0, length) + end;
        }
    }
}
