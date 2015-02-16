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
        protected GendersEnum gender;
        protected AnimatesEnum animate;
        protected WordTypesEnum type;
        protected string name;
        protected string collectionName;
        protected CyrRule[] rules;

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
            CyrResult result = new CyrResult(this.name,
                this.rules[0].Apply(this.name),
                this.rules[1].Apply(this.name),
                this.rules[2].Apply(this.name),
                this.rules[3].Apply(this.name),
                this.rules[4].Apply(this.name));

            return result;
        }

        public CyrResult DeclinePlural()
        {
            CyrResult result = new CyrResult(this.rules[5].Apply(this.name),
                this.rules[6].Apply(this.name),
                this.rules[7].Apply(this.name),
                this.rules[8].Apply(this.name),
                this.rules[9].Apply(this.name),
                this.rules[10].Apply(this.name));

            return result;
        }
    }
}
