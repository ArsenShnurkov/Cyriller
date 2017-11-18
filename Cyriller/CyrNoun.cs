using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyriller.Model;

namespace Cyriller
{
    public class CyrNoun
    {
        public const string Hyphen = "-";

        protected GendersEnum gender;
        protected AnimatesEnum animate;
        protected WordTypesEnum type;
        protected string name;
        protected string collectionName;
        protected CyrRule[] rules;
        protected int rulesOffset = 11;

        public CyrNoun(string Name, GendersEnum Gender, AnimatesEnum Animate, WordTypesEnum Type, CyrRule[] Rules)
            : this(Name, Name, Gender, Animate, Type, Rules)
        {
        }

        public CyrNoun(string Name, string CollectionName, GendersEnum Gender, AnimatesEnum Animate, WordTypesEnum Type, CyrRule[] Rules)
        {
            this.collectionName = CollectionName;
            this.name = Name;
            this.gender = Gender;
            this.animate = Animate;
            this.type = Type;
            this.rules = Rules;
        }

        public bool IsAnimated
        {
            get
            {
                return this.animate == AnimatesEnum.Animated;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string CollectionName
        {
            get
            {
                return this.collectionName;
            }
        }

        public bool ExactMatch
        {
            get
            {
                return this.name == this.collectionName;
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
            string[] parts = this.name.Split(Hyphen[0]);

            if (parts.Length == 1 || this.rules.Length <= 11)
            {
                CyrResult result = new CyrResult(this.name,
                    this.rules[0].Apply(this.name),
                    this.rules[1].Apply(this.name),
                    this.rules[2].Apply(this.name),
                    this.rules[3].Apply(this.name),
                    this.rules[4].Apply(this.name));

                return result;
            }

            return this.DeclineMultipleParts(parts);
        }

        public CyrResult DeclinePlural()
        {
            string[] parts = this.name.Split(Hyphen[0]);

            if (parts.Length == 1)
            {
                CyrResult result = new CyrResult(this.rules[5].Apply(this.name),
                    this.rules[6].Apply(this.name),
                    this.rules[7].Apply(this.name),
                    this.rules[8].Apply(this.name),
                    this.rules[9].Apply(this.name),
                    this.rules[10].Apply(this.name));

                return result;
            }

            return this.DeclinePluralMultipleParts(parts);
        }

        protected CyrResult DeclineMultipleParts(string[] parts)
        {
            List<CyrResult> results = new List<CyrResult>();

            for (int i = 0; i < parts.Length; i++)
            {
                int offest = i * this.rulesOffset;

                CyrResult partResult = new CyrResult(parts[i],
                    this.rules[0 + offest].Apply(parts[i]),
                    this.rules[1 + offest].Apply(parts[i]),
                    this.rules[2 + offest].Apply(parts[i]),
                    this.rules[3 + offest].Apply(parts[i]),
                    this.rules[4 + offest].Apply(parts[i]));

                results.Add(partResult);
            }

            return this.JoinResults(results);
        }

        protected CyrResult DeclinePluralMultipleParts(string[] parts)
        {
            List<CyrResult> results = new List<CyrResult>();

            for (int i = 0; i < parts.Length; i++)
            {
                int offest = i * this.rulesOffset;

                CyrResult partResult = new CyrResult(this.rules[5 + offest].Apply(parts[i]),
                    this.rules[6 + offest].Apply(parts[i]),
                    this.rules[7 + offest].Apply(parts[i]),
                    this.rules[8 + offest].Apply(parts[i]),
                    this.rules[9 + offest].Apply(parts[i]),
                    this.rules[10 + offest].Apply(parts[i]));

                results.Add(partResult);
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
    }
}
