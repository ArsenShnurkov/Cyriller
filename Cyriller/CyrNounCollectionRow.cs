using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyriller
{
    internal class CyrNounCollectionRow
    {
        public int GenderID { get; set; }
        public int AnimateID { get; set; }
        public int TypeID { get; set; }
        public int RuleID { get; set; }

        public static CyrNounCollectionRow Parse(string value)
        {
            string[] parts = value.Split(',');

            if (parts.Length != 4)
            {
                throw new ArgumentException($"{value} is not a valid representation of {nameof(CyrNounCollectionRow)}!");
            }

            CyrNounCollectionRow row = new CyrNounCollectionRow();

            row.GenderID = int.Parse(parts[0]);
            row.AnimateID = int.Parse(parts[1]);
            row.TypeID = int.Parse(parts[2]);
            row.RuleID = int.Parse(parts[3]);

            return row;
        }
    }
}
