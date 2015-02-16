using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyriller.Model;

namespace Cyriller
{
    public class CyrResult
    {
        protected string case1;
        protected string case2;
        protected string case3;
        protected string case4;
        protected string case5;
        protected string case6;

        public CyrResult()
        {
        }

        public CyrResult(string Word)
        {
            this.case1 = Word;
            this.case2 = Word;
            this.case3 = Word;
            this.case4 = Word;
            this.case5 = Word;
            this.case6 = Word;
        }

        public CyrResult(string Case1, string Case2, string Case3, string Case4, string Case5, string Case6)
        {
            this.case1 = Case1;
            this.case2 = Case2;
            this.case3 = Case3;
            this.case4 = Case4;
            this.case5 = Case5;
            this.case6 = Case6;
        }

        public static CyrResult operator +(CyrResult A, CyrResult B)
        {
            return new CyrResult(A.case1 + " " + B.case1,
                A.case2 + " " + B.case2,
                A.case3 + " " + B.case3,
                A.case4 + " " + B.case4,
                A.case5 + " " + B.case5,
                A.case6 + " " + B.case6);
        }

        /// <summary>
        /// Именительный, Кто? Что? (есть)
        /// </summary>
        public string Nominative
        {
            get
            {
                return this.case1;
            }
        }

        /// <summary>
        /// Родительный, Кого? Чего? (нет)
        /// </summary>
        public string Genitive
        {
            get
            {
                return this.case2;
            }
        }

        /// <summary>
        /// Дательный, Кому? Чему? (дам)
        /// </summary>
        public string Dative
        {
            get 
            {
                return this.case3;
            }
        }

        /// <summary>
        /// Винительный, Кого? Что? (вижу)
        /// </summary>
        public string Accusative
        {
            get
            {
                return this.case4;
            }
        }

        /// <summary>
        /// Творительный, Кем? Чем? (горжусь)
        /// </summary>
        public string Instrumental
        {
            get 
            {
                return this.case5;
            }
        }

        /// <summary>
        /// Предложный, О ком? О чем? (думаю)
        /// </summary>
        public string Prepositional
        {
            get
            {
                return this.case6;
            }
        }

        /// <summary>
        /// Именительный, Кто? Что? (есть)
        /// </summary>
        public string Именительный
        {
            get
            {
                return this.case1;
            }
        }

        /// <summary>
        /// Родительный, Кого? Чего? (нет)
        /// </summary>
        public string Родительный
        {
            get
            {
                return this.case2;
            }
        }

        /// <summary>
        /// Дательный, Кому? Чему? (дам)
        /// </summary>
        public string Дательный
        {
            get
            {
                return this.case3;
            }
        }

        /// <summary>
        /// Винительный, Кого? Что? (вижу)
        /// </summary>
        public string Винительный
        {
            get
            {
                return this.case4;
            }
        }

        /// <summary>
        /// Творительный, Кем? Чем? (горжусь)
        /// </summary>
        public string Творительный
        {
            get
            {
                return this.case5;
            }
        }

        /// <summary>
        /// Предложный, О ком? О чем? (думаю)
        /// </summary>
        public string Предложный
        {
            get
            {
                return this.case6;
            }
        }

        public string Get(CasesEnum Case)
        {
            switch (Case)
            {
                case CasesEnum.Nominative: return case1;
                case CasesEnum.Genitive: return case2;
                case CasesEnum.Dative: return case3;
                case CasesEnum.Accusative: return case4;
                case CasesEnum.Instrumental: return case5;
                case CasesEnum.Prepositional: return case6;
                default: return case1;
            }
        }

        public void Set(CasesEnum Case, string Value)
        {
            switch (Case)
            {
                case CasesEnum.Nominative: case1 = Value; break;
                case CasesEnum.Genitive: case2 = Value; break;
                case CasesEnum.Dative: case3 = Value; break;
                case CasesEnum.Accusative: case4 = Value; break;
                case CasesEnum.Instrumental: case5 = Value; break;
                case CasesEnum.Prepositional: case6 = Value; break;
                default: case1 = Value; break;
            }
        }

        public void Add(CyrResult Result, string Separator = "-")
        {
            this.case1 += Separator + Result.case1;
            this.case2 += Separator + Result.case2;
            this.case3 += Separator + Result.case3;
            this.case4 += Separator + Result.case4;
            this.case5 += Separator + Result.case5;
            this.case6 += Separator + Result.case6;
        }

        public List<string> ToList()
        {
            return new List<string>() { case1, case2, case3, case4, case5, case6 };
        }

        public string[] ToArray()
        {
            return new string[] { case1, case2, case3, case4, case5, case6 };
        }

        public Dictionary<CasesEnum, string> ToDictionary()
        {
            CasesEnum[] caseNames = new CasesEnum[] { CasesEnum.Nominative, CasesEnum.Genitive, CasesEnum.Dative, CasesEnum.Accusative, CasesEnum.Instrumental, CasesEnum.Prepositional };
            Dictionary<CasesEnum, string> result = new Dictionary<CasesEnum, string>();

            result.Add(caseNames[0], case1);
            result.Add(caseNames[1], case2);
            result.Add(caseNames[2], case3);
            result.Add(caseNames[3], case4);
            result.Add(caseNames[4], case5);
            result.Add(caseNames[5], case6);

            return result;
        }

        public Dictionary<string, string> ToStringDictionary()
        {
            string[] caseNames = new string[] { "Nominative", "Genitive", "Dative", "Accusative", "Instrumental", "Prepositional" };
            Dictionary<string, string> result = new Dictionary<string, string>();

            result.Add(caseNames[0], case1);
            result.Add(caseNames[1], case2);
            result.Add(caseNames[2], case3);
            result.Add(caseNames[3], case4);
            result.Add(caseNames[4], case5);
            result.Add(caseNames[5], case6);

            return result;
        }

        public Dictionary<string, string> ToRussianStringDictionary()
        {
            string[] caseNames = new string[] { "Именительный", "Родительный", "Дательный", "Винительный", "Творительный", "Предложный" };
            Dictionary<string, string> result = new Dictionary<string, string>();

            result.Add(caseNames[0], case1);
            result.Add(caseNames[1], case2);
            result.Add(caseNames[2], case3);
            result.Add(caseNames[3], case4);
            result.Add(caseNames[4], case5);
            result.Add(caseNames[5], case6);

            return result;
        }

        /// <summary>
        /// One based index. See the CasesEnum enumeration.
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public string this[int Index]
        {
            get
            {
                this.CheckIndex(Index);
                return this.Get((CasesEnum)Index);
            }
            set
            {
                this.CheckIndex(Index);
                this.Set((CasesEnum)Index, value);
            }
        }

        protected void CheckIndex(int Index)
        {
            if (Index == 0)
            {
                throw new IndexOutOfRangeException("This is a one based index!");
            }
        }
    }
}
