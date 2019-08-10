using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cyriller.Model;

namespace Cyriller.Web.Models
{
    public class CyrAdjectiveDeclineResult : CyrBaseDeclineResult
    {
        public GendersEnum FoundGender { get; set; }
        public AnimatesEnum FoundAnimate { get; set; }

        public string FoundGenderStringRu => this.GetGenderStringRu(this.FoundGender);
        public string FoundAnimatedStringRu => this.GetAnimatedStringRu(this.FoundAnimate);
        public string FoundCaseStringRu => this.GetCaseStringRu(this.FoundCase);
        public string FoundNumberStringRu => this.GetNumberStringRu(this.FoundNumber);
    }
}