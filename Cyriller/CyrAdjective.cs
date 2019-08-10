using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyriller.Model;

namespace Cyriller
{
    public class CyrAdjective : CyrBaseWord
    {
        /// <summary>
        /// Прилагательное мужского рода в именительном падеже.
        /// </summary>
        public string Name { get; protected set; }

        protected CyrRule[] rules;
        protected int rulesPerAdjective = 23;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Прилагательное мужского рода, единственного числа, в именительном падеже.</param>
        /// <param name="rules">Правила склонения.</param>
        public CyrAdjective(string name, CyrRule[] rules)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (rules == null)
            {
                throw new ArgumentNullException(nameof(rules));
            }

            if (rules.Length != rulesPerAdjective)
            {
                throw new ArgumentException(nameof(rules), $"Adjective rules collection must have exactly {rulesPerAdjective} elements.");
            }

            this.Name = name;
            this.rules = rules;
        }

        public CyrAdjective(CyrAdjective source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            this.Name = source.Name;
            this.rules = source.rules;
        }

        public CyrResult Decline(GendersEnum gender, AnimatesEnum animate)
        {
            CyrRule[] rules = this.GetRules(gender, NumbersEnum.Singular, animate);
            CyrResult result = this.GetResult(this.Name, rules);

            return result;
        }

        public CyrResult DeclinePlural(AnimatesEnum animate)
        {
            CyrRule[] rules = this.GetRules(0, NumbersEnum.Plural, animate);
            CyrResult result = this.GetResult(this.Name, rules);

            return result;
        }

        public void SetName(string name, GendersEnum gender, CasesEnum @case, NumbersEnum number, AnimatesEnum animate)
        {
            CyrRule[] rules = this.GetRules(gender, number, animate);
            CyrRule rule = rules[(int)@case - 1];

            this.Name = rule.Revert(this.Name, name);
        }

        protected virtual CyrRule[] GetRules(GendersEnum gender, NumbersEnum number, AnimatesEnum animate)
        {
            CyrRule[] rules;

            
            if (gender == GendersEnum.Masculine)
            {
                rules = new CyrRule[]
                {
                    new CyrRule(string.Empty),
                    this.rules[0],
                    this.rules[1],
                    animate == AnimatesEnum.Animated ? this.rules[2] : new CyrRule(string.Empty),
                    this.rules[3],
                    this.rules[4]
                };
            }
            else if (gender == GendersEnum.Feminine)
            {
                rules = new CyrRule[]
                {
                    this.rules[5],
                    this.rules[6],
                    this.rules[7],
                    this.rules[8],
                    this.rules[9],
                    this.rules[10]
                };
            }
            else if (gender == GendersEnum.Neuter)
            {
                rules = new CyrRule[]
                {
                    this.rules[11],
                    this.rules[12],
                    this.rules[13],
                    this.rules[14],
                    this.rules[15],
                    this.rules[16]
                };
            }
            else if (number == NumbersEnum.Plural)
            {
                rules = new CyrRule[]
                {
                    this.rules[17],
                    this.rules[18],
                    this.rules[19],
                    animate == AnimatesEnum.Animated ? this.rules[20] : this.rules[17],
                    this.rules[21],
                    this.rules[22]
                };
            }
            else
            {
                throw new InvalidOperationException($"Unable to decline adjective with Gender: [{gender}], Number: [{number}], Animate: [{animate}].");
            }

            return rules;
        }
    }
}
