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
        protected string end;
        protected int cut;

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
