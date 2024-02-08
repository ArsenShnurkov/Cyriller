using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cyriller.Model;

namespace Cyriller.Web.Models
{
    public class CyrNounDeclineResult : CyrBaseDeclineResult
    {
        public GendersEnum Gender { get; set; }
        public WordTypesEnum WordType { get; set; }
        public AnimatesEnum Animate { get; set; }

        public string GenderStringRu => this.GetGenderStringRu(this.Gender);
        public string AnimatedStringRu => this.GetAnimatedStringRu(this.Animate);
        public string WordTypeStringRu => this.GetWordTypeStringRu(this.WordType);
        public string FoundCaseStringRu => this.GetCaseStringRu(this.FoundCase);
        public string FoundNumberStringRu => this.GetNumberStringRu(this.FoundNumber);
    }
}