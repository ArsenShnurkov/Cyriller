using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Cyriller.Model.Json;

namespace Cyriller.Rule
{
    public class NounRule : BaseRule
    {
        /// <summary>
        /// Используется для распознавания составных слов, к примеру "Австро-венгрия".
        /// </summary>
        public string Hyphen { get; set; } = "-";

        /// <summary>
        /// Используется для склеивания правил склонения для составных слов.
        /// </summary>
        public string WordSeparator { get; set; } = "|";

        public NounRule(NounJson source)
        {
            this.ValidateSource(source);

            string noun = source.Name;
            string[] parts = noun.Split(Hyphen.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> rules = new List<string>();
            string[] variants = new string[]
            {
                source.Singular[1],
                source.Singular[2],
                source.Singular[3],
                source.Singular[4],
                source.Singular[5],
                source.Plural[0],
                source.Plural[1],
                source.Plural[2],
                source.Plural[3],
                source.Plural[4],
                source.Plural[5]
            };
            string[][] variantParts = variants.Select(x => x.Split(Hyphen.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)).ToArray();

            for (int i = 0; i < parts.Length; i++)
            {
                string part = parts[i];
                string[] variant = variantParts.Select(x => x.Length > i ? x[i] : null).ToArray();

                rules.Add(this.GetRuleString(part, variant));
            }

            this.Value = string.Join(WordSeparator, rules.ToArray());
        }

        protected virtual void ValidateSource(NounJson source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            source.Validate();
        }
    }
}
