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
        private const string Unavailable = "*";

        /// <summary>
        /// Оригинальная строка, из которой было создано данное правило.
        /// </summary>
        protected string originalRuleString;

        /// <summary>
        /// Кол-во символов для удаления с конца слова, при применении данного правила склонения.
        /// </summary>
        protected int cut;

        /// <summary>
        /// Новое окончание слова, при применении данного правила склонения.
        /// </summary>
        protected string end;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rule">
        /// Строка, описывающая правило склонения.
        /// Пример:
        /// "ен2" - удалить два символа, с конца слова и добавить "ен".
        /// "ым" - не удалять ни одного символа, с конца слова, но добавить "ым".
        /// "*" - данное правило не применимо. Всегда возвращает <see cref="String.Empty"/>, при попытке применить правило используя <see cref="CyrRule.Apply(string)"/>.
        /// </param>
        public CyrRule(string rule)
        {
            if (string.IsNullOrEmpty(rule))
            {
                this.end = string.Empty;
                this.cut = 0;
                return;
            }

            List<char> endChars = new List<char>();
            List<char> cutChars = new List<char>();

            foreach (char ch in rule)
            {
                if (char.IsDigit(ch))
                {
                    cutChars.Add(ch);
                }
                else
                {
                    endChars.Add(ch);
                }
            }

            this.originalRuleString = rule;
            this.end = new string(endChars.ToArray());

            switch (cutChars.Count)
            {
                case 0:
                    this.cut = 0;
                    break;
                case 1:
                    this.cut = (int)char.GetNumericValue(cutChars[0]);
                    break;
                default:
                    this.cut = int.Parse(new string(cutChars.ToArray()));
                    break;
            }
        }

        /// <summary>
        /// Склоняет указанное слово.
        /// </summary>
        /// <param name="name">Слово для склонения.</param>
        /// <returns></returns>
        public string Apply(string name)
        {
            if (this.end == Unavailable)
            {
                return string.Empty;
            }

            int length = name.Length - cut;

            if (length <= 0)
            {
                return this.end;
            }

            return name.Substring(0, length) + end;
        }

        /// <summary>
        /// Отменяет склонение указанного слова.
        /// Используется для восстановления исходной формы слов, отсутствующих в словаре.
        /// Пример: слово "прасными" будет склоняться по правилу склонения слова "красными", следовательно, исходная форма будет "прасный".
        /// </summary>
        /// <param name="original">Оригинальное слово, для получения удаленного окончания при склонении.</param>
        /// <param name="current">Слово для восстановления в исходное положение.</param>
        /// <returns></returns>
        public string Revert(string original, string current)
        {
            if (this.end == Unavailable)
            {
                return current;
            }

            int length = current.Length - this.end.Length;
            string originalEnd = original.Substring(original.Length - this.cut);

            return current.Substring(0, length) + originalEnd;
        }

        public override bool Equals(object obj)
        {
            CyrRule that = obj as CyrRule;
            bool equals = this.originalRuleString == that?.originalRuleString;

            return equals;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.originalRuleString;
        }
    }
}
