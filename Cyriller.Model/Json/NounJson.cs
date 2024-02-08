using System;
using System.Collections.Generic;
using System.Text;

namespace Cyriller.Model.Json
{
    public class NounJson
    {
        public AnimatesEnum Animate { get; set; }
        public GendersEnum Gender { get; set; }
        public string Name { get; set; }
        public WordTypesEnum WordType { get; set; }
        public string[] Singular { get; set; }
        public string[] Plural { get; set; }

        /// <summary>
        /// Превращает текущее существительное в строку, используя формат Cyriller словаря.
        /// Словарь: /Cyriller/App_Data/nouns.txt.
        /// Пример: абажур 1,2,0,8.
        /// Пояснение формата: [существительное] [род],[одушевленность],[тип слова],[индекс правила склонения].
        /// </summary>
        /// <param name="ruleIndex">Индекс правила склонения.</param>
        /// <returns></returns>
        public string ToDictionaryString(int ruleIndex)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Name)
                .Append(" ")
                .Append((int)this.Gender)
                .Append(",")
                .Append((int)this.Animate)
                .Append(",")
                .Append((int)this.WordType)
                .Append(",")
                .Append(ruleIndex);

            return sb.ToString();
        }

        /// <summary>
        /// Проверяет текущее состояние объекта.
        /// Выбрасывает <see cref="ArgumentNullException"/>, если <see cref="Name"/> равно null или пусто.
        /// Выбрасывает <see cref="ArgumentNullException"/>, если <see cref="Singular"/> или <see cref="Plural"/> массив равен null.
        /// Выбрасывает <see cref="ArgumentException"/>, если кол-во элементов в <see cref="Singular"/> или <see cref="Plural"/> массивах не равно шесть.
        /// </summary>
        public void Validate()
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                throw new ArgumentNullException(nameof(NounJson.Name), $"Noun is missing required {nameof(NounJson.Name)} value.");
            }

            if (this.Singular == null)
            {
                throw new ArgumentNullException(nameof(NounJson.Singular), $"Noun {this.Name} is missing required {nameof(NounJson.Singular)} value.");
            }

            if (this.Plural == null)
            {
                throw new ArgumentNullException(nameof(NounJson.Plural), $"Noun {this.Name} is missing required {nameof(NounJson.Plural)} value.");
            }

            if (this.Singular.Length != 6)
            {
                throw new ArgumentException(nameof(NounJson.Singular), $"Noun {this.Name} {nameof(NounJson.Singular)} has invalid number of values. There should be 6 values.");
            }

            if (this.Plural.Length != 6)
            {
                throw new ArgumentException(nameof(NounJson.Plural), $"Noun {this.Name} {nameof(NounJson.Plural)} has invalid number of values. There should be 6 values.");
            }
        }
    }
}
