using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyriller.Model;

namespace Cyriller
{
    public class CyrAdjective
    {
        protected GendersEnum gender;
        protected AnimatesEnum animate;
        protected string name;
        protected string collectionName;
        protected CyrRule[] rules;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name">Прилагательное мужского рода в именительном падеже</param>
        /// <param name="CollectionName">Слово найденное в коллекции</param>
        /// <param name="Gender">Пол для склонения</param>
        /// <param name="rules">Правила склонения</param>
        public CyrAdjective(string Name, string CollectionName, GendersEnum Gender, CyrRule[] rules)
        {
            this.name = Name;
            this.collectionName = CollectionName;
            this.gender = Gender;
            this.rules = rules;
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

        public CyrResult Decline(AnimatesEnum Animate)
        {
            CyrResult result;

            if (this.gender == GendersEnum.Feminine)
            {
                result = new CyrResult(this.rules[5].Apply(this.name),
                    this.rules[6].Apply(this.name),
                    this.rules[7].Apply(this.name),
                    this.rules[8].Apply(this.name),
                    this.rules[9].Apply(this.name),
                    this.rules[10].Apply(this.name));
            }
            else if (this.gender == GendersEnum.Neuter)
            {
                result = new CyrResult(this.rules[11].Apply(this.name),
                    this.rules[12].Apply(this.name),
                    this.rules[13].Apply(this.name),
                    this.rules[14].Apply(this.name),
                    this.rules[15].Apply(this.name),
                    this.rules[16].Apply(this.name));
            }
            else
            {
                result = new CyrResult(this.name,
                    this.rules[0].Apply(this.name),
                    this.rules[1].Apply(this.name),
                    Animate == AnimatesEnum.Animated ? this.rules[2].Apply(this.name) : this.name,
                    this.rules[3].Apply(this.name),
                    this.rules[4].Apply(this.name));
            }

            return result;
        }

        public CyrResult DeclinePlural(AnimatesEnum Animate)
        {
            CyrResult result = new CyrResult(this.rules[17].Apply(this.name),
                this.rules[18].Apply(this.name),
                this.rules[19].Apply(this.name),
                Animate == AnimatesEnum.Animated ? this.rules[21].Apply(this.name) : this.rules[17].Apply(this.name),
                this.rules[20].Apply(this.name),
                this.rules[21].Apply(this.name));

            return result;
        }
    }
}
