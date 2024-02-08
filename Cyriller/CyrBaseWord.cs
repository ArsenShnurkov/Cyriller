using System;
using System.Collections.Generic;
using System.Text;

namespace Cyriller
{
    public abstract class CyrBaseWord
    {
        protected virtual CyrResult GetResult(string name, CyrRule[] rules)
        {
            CyrResult result = new CyrResult
            (
                rules[0].Apply(name),
                rules[1].Apply(name),
                rules[2].Apply(name),
                rules[3].Apply(name),
                rules[4].Apply(name),
                rules[5].Apply(name)
            );

            return result;
        }
    }
}
