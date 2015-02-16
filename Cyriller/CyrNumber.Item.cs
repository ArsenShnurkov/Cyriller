﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyriller.Model;

namespace Cyriller
{
    public partial class CyrNumber
    {
        public class Item
        {
            protected CyrResult singular;
            protected CyrResult plural;
            protected CyrNoun noun;

            public Item(CyrNoun Noun)
            {
                this.noun = Noun;
                this.singular = noun.Decline();
                this.plural = noun.DeclinePlural();
            }

            public string[] GetName(CasesEnum Case, long Value)
            {
                if (this.Gender == GendersEnum.Feminine)
                {
                    return GetFeminine(Case);
                }
                else if (this.Gender == GendersEnum.Neuter)
                {
                    return GetNeuter(Case);
                }
                else
                {
                    return this.GetMasculine(Case, Value);
                }
            }

            public GendersEnum Gender
            {
                get
                {
                    return this.noun.Gender;
                }
            }

            public AnimatesEnum Animate
            {
                get
                {
                    return this.noun.Animate;
                }
            }

            protected string[] GetMasculine(CasesEnum Case, long Value)
            {
                if (this.Animate == AnimatesEnum.Animated && Value < 20)
                {
                    switch (Case)
                    {
                        case CasesEnum.Nominative:
                            return new string[] { singular[1], singular[2], plural[2] };
                        case CasesEnum.Genitive:
                            return new string[] { singular[2], plural[2], plural[2] };
                        case CasesEnum.Dative:
                            return new string[] { singular[3], plural[3], plural[3] };
                        case CasesEnum.Accusative:
                            return new string[] { singular[4], plural[4], plural[4] };
                        case CasesEnum.Instrumental:
                            return new string[] { singular[5], plural[5], plural[5] };
                        case CasesEnum.Prepositional:
                            return new string[] { singular[6], plural[6], plural[6] };
                        default:
                            throw new ArgumentException("Invalid Case!");
                    }
                }
                else
                {
                    switch (Case)
                    {
                        case CasesEnum.Nominative:
                            if (noun.Name.ToLower() == "год")
                            {
                                return new string[] { singular[1], singular[2], "лет" };
                            }

                            return new string[] { singular[1], singular[2], plural[2] };
                        case CasesEnum.Genitive:
                            if (noun.Name.ToLower() == "год")
                            {
                                return new string[] { singular[2], plural[2], "лет" };
                            }

                            return new string[] { singular[2], plural[2], plural[2] };
                        case CasesEnum.Dative:
                            return new string[] { singular[3], plural[3], plural[3] };
                        case CasesEnum.Accusative:
                            if (noun.Name.ToLower() == "год")
                            {
                                return new string[] { singular[4], singular[4], "лет" };
                            }

                            return new string[] { singular[1], singular[2], plural[2] };
                        case CasesEnum.Instrumental:
                            return new string[] { singular[5], plural[5], plural[5] };
                        case CasesEnum.Prepositional:
                            return new string[] { singular[6], plural[6], plural[6] };
                        default:
                            throw new ArgumentException("Invalid Case!");
                    }
                }
            }

            protected string[] GetFeminine(CasesEnum Case)
            {
                switch (Case)
                {
                    case CasesEnum.Nominative:
                        return new string[] { singular[1], singular[2], plural[2] };
                    case CasesEnum.Genitive:
                        return new string[] { singular[2], plural[2], plural[2] };
                    case CasesEnum.Dative:
                        return new string[] { singular[3], plural[3], plural[3] };
                    case CasesEnum.Accusative:
                        return new string[] { singular[4], singular[2], plural[4] };
                    case CasesEnum.Instrumental:
                        return new string[] { singular[5], plural[5], plural[5] };
                    case CasesEnum.Prepositional:
                        return new string[] { singular[6], plural[6], plural[6] };
                    default:
                        throw new ArgumentException("Invalid Case!");
                }
            }

            protected string[] GetNeuter(CasesEnum Case)
            {
                switch (Case)
                {
                    case CasesEnum.Nominative:
                        return new string[] { singular[1], singular[2], plural[2] };
                    case CasesEnum.Genitive:
                        return new string[] { singular[2], plural[2], plural[2] };
                    case CasesEnum.Dative:
                        return new string[] { singular[3], plural[3], plural[3] };
                    case CasesEnum.Accusative:
                        return new string[] { singular[4], singular[2], plural[2] };
                    case CasesEnum.Instrumental:
                        return new string[] { singular[5], plural[5], plural[5] };
                    case CasesEnum.Prepositional:
                        return new string[] { singular[6], plural[6], plural[6] };
                    default:
                        throw new ArgumentException("Invalid Case!");
                }
            }
        }
    }
}
