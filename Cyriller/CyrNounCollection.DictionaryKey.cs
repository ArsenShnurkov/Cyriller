using System;
using System.Collections.Generic;
using System.Text;
using Cyriller.Model;

namespace Cyriller
{
    public partial class CyrNounCollection
    {
        public struct DictionaryKey
        {
            public string Name;
            public GendersEnum Gender;
            public CasesEnum Case;
            public NumbersEnum Number;

            public DictionaryKey(string name, GendersEnum gender, CasesEnum @case, NumbersEnum number)
            {
                this.Name = name;
                this.Gender = gender;
                this.Case = @case;
                this.Number = number;
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DictionaryKey))
                {
                    return false;
                }

                DictionaryKey that = (DictionaryKey)obj;

                return this.Case == that.Case && this.Gender == that.Gender && this.Number == that.Number && this.Name == that.Name;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return $"{this.Name}.{this.Gender}.{this.Case}.{this.Number}";
            }
        }
    }
}
