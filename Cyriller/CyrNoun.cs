using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyriller.Model;

namespace Cyriller
{
    public class CyrNoun : CyrBaseWord
    {
        public const string Hyphen = "-";


        public string Name { get; protected set; }
        public GendersEnum Gender { get; protected set; }
        public AnimatesEnum Animate { get; protected set; }
        public WordTypesEnum WordType { get; protected set; }

        protected CyrRule[] rules;
        protected int rulesPerNoun = 11;

        public CyrNoun(string name, GendersEnum gender, AnimatesEnum animate, WordTypesEnum type, CyrRule[] rules)
            : this(name, name, gender, animate, type, rules)
        {
        }

        public CyrNoun(string name, string collectionName, GendersEnum gender, AnimatesEnum animate, WordTypesEnum type, CyrRule[] rules)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (rules == null)
            {
                throw new ArgumentNullException(nameof(rules));
            }

            if (rules.Length % rulesPerNoun != 0)
            {
                throw new ArgumentException(nameof(rules), $"Noun rules collection must have {rulesPerNoun} * N elements.");
            }

            this.Name = name;
            this.Gender = gender;
            this.Animate = animate;
            this.WordType = type;
            this.rules = rules;
        }

        public CyrNoun(CyrNoun source)
        {
            this.Name = source.Name;
            this.Gender = source.Gender;
            this.Animate = source.Animate;
            this.WordType = source.WordType;
            this.rules = source.rules;
        }

        public bool IsAnimated
        {
            get
            {
                return this.Animate == AnimatesEnum.Animated;
            }
        }

        public CyrResult Decline()
        {
            string[] parts = this.Name.Split(Hyphen[0]);

            if (parts.Length == 1 || this.rules.Length <= this.rulesPerNoun)
            {
                CyrRule[] rules = this.GetRules(NumbersEnum.Singular, 0);
                CyrResult result = this.GetResult(this.Name, rules);

                return result;
            }

            return this.DeclineMultipleParts(parts, NumbersEnum.Singular);
        }

        public CyrResult DeclinePlural()
        {
            string[] parts = this.Name.Split(Hyphen[0]);

            if (parts.Length == 1 || this.rules.Length <= this.rulesPerNoun)
            {
                CyrRule[] rules = this.GetRules(NumbersEnum.Plural, 0);
                CyrResult result = this.GetResult(this.Name, rules);

                return result;
            }

            return this.DeclineMultipleParts(parts, NumbersEnum.Plural);
        }

        public void SetName(string name, CasesEnum @case, NumbersEnum number)
        {
            if (this.rules.Length > rulesPerNoun)
            {
                throw new NotImplementedException($"{nameof(SetName)} is not yet supported for composite nouns.");
            }

            CyrRule[] rules = this.GetRules(number, 0);
            CyrRule rule = rules[(int)@case - 1];

            this.Name = rule.Revert(this.Name, name);
        }

        protected CyrResult DeclineMultipleParts(string[] parts, NumbersEnum number)
        {
            List<CyrResult> results = new List<CyrResult>();

            for (int i = 0; i < parts.Length; i++)
            {
                CyrRule[] rules = this.GetRules(number, i);
                CyrResult result = this.GetResult(parts[i], rules);

                results.Add(result);
            }

            return this.JoinResults(results);
        }

        protected CyrResult JoinResults(IEnumerable<CyrResult> results)
        {
            CyrResult result = new CyrResult(string.Join(Hyphen, results.Select(x => x[(int)CasesEnum.Nominative]).Where(x => !string.IsNullOrEmpty(x)).ToArray()),
                string.Join(Hyphen, results.Select(x => x[(int)CasesEnum.Genitive]).Where(x => !string.IsNullOrEmpty(x)).ToArray()),
                string.Join(Hyphen, results.Select(x => x[(int)CasesEnum.Dative]).Where(x => !string.IsNullOrEmpty(x)).ToArray()),
                string.Join(Hyphen, results.Select(x => x[(int)CasesEnum.Accusative]).Where(x => !string.IsNullOrEmpty(x)).ToArray()),
                string.Join(Hyphen, results.Select(x => x[(int)CasesEnum.Instrumental]).Where(x => !string.IsNullOrEmpty(x)).ToArray()),
                string.Join(Hyphen, results.Select(x => x[(int)CasesEnum.Prepositional]).Where(x => !string.IsNullOrEmpty(x)).ToArray()));

            return result;
        }

        protected virtual CyrRule[] GetRules(NumbersEnum number, int wordPartIndex)
        {
            if (number == NumbersEnum.Singular)
            {
                return new CyrRule[]
                {
                    new CyrRule(string.Empty),
                    this.rules[0 + wordPartIndex * rulesPerNoun],
                    this.rules[1 + wordPartIndex * rulesPerNoun],
                    this.rules[2 + wordPartIndex * rulesPerNoun],
                    this.rules[3 + wordPartIndex * rulesPerNoun],
                    this.rules[4 + wordPartIndex * rulesPerNoun]
                };
            }
            else
            {
                return new CyrRule[]
                {
                    this.rules[5 + wordPartIndex * rulesPerNoun],
                    this.rules[6 + wordPartIndex * rulesPerNoun],
                    this.rules[7 + wordPartIndex * rulesPerNoun],
                    this.rules[8 + wordPartIndex * rulesPerNoun],
                    this.rules[9 + wordPartIndex * rulesPerNoun],
                    this.rules[10 + wordPartIndex * rulesPerNoun]
                };
            }
        }
    }
}
