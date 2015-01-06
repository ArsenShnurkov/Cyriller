using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyriller.Model;

namespace Cyriller
{
    public partial class CyrWord
    {
        protected CyrResult DeclineNoun3()
        {
            string t;
            CyrResult r = new CyrResult();

            r[1] = w;
            t = w.ReplaceRegex(@"(\w)$", "и");
            r[2] = t;
            r[3] = t;
            r[4] = w;
            r[5] = w + "ю";
            r[6] = w.ReplaceRegex(@"(\w)$", "и");

            return r;
        }
    }
}
