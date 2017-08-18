using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyriller
{
    public class CyrDeclineCase
    {
        public string NameRu { get; protected set; }
        public string NameEn { get; protected set; }
        public string Description { get; protected set; }
        public int Index { get; protected set; }

        public static CyrDeclineCase[] List
        {
            get
            {
                return new CyrDeclineCase[] { Case1, Case2, Case3, Case4, Case5, Case6 };
            }
        }

        public static CyrDeclineCase Case1
        {
            get
            {
                return new CyrDeclineCase()
                {
                    NameRu = "Именительный",
                    NameEn = "Nominative",
                    Description = "Кто? Что? (есть)",
                    Index = 1
                };
            }
        }

        public static CyrDeclineCase Case2
        {
            get
            {
                return new CyrDeclineCase()
                {
                    NameRu = "Родительный",
                    NameEn = "Genitive",
                    Description = "Кого? Чего? (нет)",
                    Index = 2
                };
            }
        }

        public static CyrDeclineCase Case3
        {
            get
            {
                return new CyrDeclineCase()
                {
                    NameRu = "Дательный",
                    NameEn = "Dative",
                    Description = "Кому? Чему? (дам)",
                    Index = 3
                };
            }
        }

        public static CyrDeclineCase Case4
        {
            get
            {
                return new CyrDeclineCase()
                {
                    NameRu = "Винительный",
                    NameEn = "Accusative",
                    Description = "Кого? Что? (вижу)",
                    Index = 4
                };
            }
        }

        public static CyrDeclineCase Case5
        {
            get
            {
                return new CyrDeclineCase()
                {
                    NameRu = "Творительный",
                    NameEn = "Instrumental",
                    Description = "Кем? Чем? (горжусь)",
                    Index = 5
                };
            }
        }

        public static CyrDeclineCase Case6
        {
            get
            {
                return new CyrDeclineCase()
                {
                    NameRu = "Предложный",
                    NameEn = "Prepositional",
                    Description = "О ком? О чем? (думаю)",
                    Index = 6
                };
            }
        }

        /// <summary>
        /// Именительный, Кто? Что? (есть)
        /// </summary>
        public CyrDeclineCase Nominative
        {
            get
            {
                return Case1;
            }
        }

        /// <summary>
        /// Родительный, Кого? Чего? (нет)
        /// </summary>
        public CyrDeclineCase Genitive
        {
            get
            {
                return Case2;
            }
        }

        /// <summary>
        /// Дательный, Кому? Чему? (дам)
        /// </summary>
        public CyrDeclineCase Dative
        {
            get
            {
                return Case3;
            }
        }

        /// <summary>
        /// Винительный, Кого? Что? (вижу)
        /// </summary>
        public CyrDeclineCase Accusative
        {
            get
            {
                return Case4;
            }
        }

        /// <summary>
        /// Творительный, Кем? Чем? (горжусь)
        /// </summary>
        public CyrDeclineCase Instrumental
        {
            get
            {
                return Case5;
            }
        }

        /// <summary>
        /// Предложный, О ком? О чем? (думаю)
        /// </summary>
        public CyrDeclineCase Prepositional
        {
            get
            {
                return Case6;
            }
        }

        /// <summary>
        /// Именительный, Кто? Что? (есть)
        /// </summary>
        public CyrDeclineCase Именительный
        {
            get
            {
                return Case1;
            }
        }

        /// <summary>
        /// Родительный, Кого? Чего? (нет)
        /// </summary>
        public CyrDeclineCase Родительный
        {
            get
            {
                return Case2;
            }
        }

        /// <summary>
        /// Дательный, Кому? Чему? (дам)
        /// </summary>
        public CyrDeclineCase Дательный
        {
            get
            {
                return Case3;
            }
        }

        /// <summary>
        /// Винительный, Кого? Что? (вижу)
        /// </summary>
        public CyrDeclineCase Винительный
        {
            get
            {
                return Case4;
            }
        }

        /// <summary>
        /// Творительный, Кем? Чем? (горжусь)
        /// </summary>
        public CyrDeclineCase Творительный
        {
            get
            {
                return Case5;
            }
        }

        /// <summary>
        /// Предложный, О ком? О чем? (думаю)
        /// </summary>
        public CyrDeclineCase Предложный
        {
            get
            {
                return Case6;
            }
        }
    }
}
