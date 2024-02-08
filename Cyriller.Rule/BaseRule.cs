using System;
using System.Collections.Generic;
using System.Text;

namespace Cyriller.Rule
{
    public abstract class BaseRule
    {
        /// <summary>
        /// Используется для склеивания разных форм (в зависимости от падежа, рода, числа, одушевленности) склонения. 
        /// </summary>
        public string CaseSeparator { get; set; } = ",";

        /// <summary>
        /// Используется для обозначения недоступности определенной формы склонения для определенного слова.
        /// </summary>
        public string Unavailable { get; set; } = "*";

        public string Value { get; protected set; }

        protected virtual string GetRuleString(string word, string[] variants)
        {
            List<string> rules = new List<string>();

            foreach (string variant in variants)
            {
                if (string.IsNullOrEmpty(variant))
                {
                    rules.Add(Unavailable);
                    continue;
                }

                int index = 0;
                StringBuilder sb = new StringBuilder();

                for (index = 0; index < word.Length && index < variant.Length; index++)
                {
                    if (word[index] != variant[index])
                    {
                        break;
                    }
                }

                string end = variant.Substring(index);
                int cut = word.Length - index;

                sb.Append(end);

                if (cut > 0)
                {
                    sb.Append(cut);
                }

                rules.Add(sb.ToString());
            }

            return string.Join(CaseSeparator, rules.ToArray());
        }
    }
}
