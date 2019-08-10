using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Cyriller.Model.Json;

namespace Cyriller.Rule
{
    public class AdjectiveRule : BaseRule
    {
        public AdjectiveRule(AdjectiveJson source)
        {
            this.ValidateSource(source);

            string[] variants = source.Masculine.Skip(1)
                .Concat(source.Feminine)
                .Concat(source.Neuter)
                .Concat(source.Plural)
                .ToArray();

            this.Value = this.GetRuleString(source.Name, variants);
        }

        protected virtual void ValidateSource(AdjectiveJson source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            source.Validate();
        }
    }
}
