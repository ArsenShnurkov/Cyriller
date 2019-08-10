using System;
using System.Collections.Generic;
using System.Text;

namespace Cyriller.Model.Json
{
    public class AdjectiveJson
    {
        public string Name { get; set; }
        public string[] Plural { get; set; }
        public string[] Masculine { get; set; }
        public string[] Feminine { get; set; }
        public string[] Neuter { get; set; }

        /// <summary>
        /// Превращает текущее прилагательное в строку, используя формат Cyriller словаря.
        /// Словарь: /Cyriller/App_Data/adjectives.txt.
        /// Пример: красный 1.
        /// Пояснение формата: [прилагательное] [индекс правила склонения].
        /// </summary>
        /// <param name="ruleIndex">Индекс правила склонения.</param>
        /// <returns></returns>
        public string ToDictionaryString(int ruleIndex)
        {
            return this.Name + " " + ruleIndex;
        }

        /// <summary>
        /// Проверяет текущее состояние объекта.
        /// Выбрасывает <see cref="ArgumentNullException"/>, если <see cref="Name"/> равно null или пусто.
        /// Выбрасывает <see cref="ArgumentNullException"/>, если <see cref="Plural"/>, <see cref="Masculine"/>, <see cref="Feminine"/> или <see cref="Neuter"/> объект/массив равен null.
        /// Выбрасывает <see cref="ArgumentException"/>, если кол-во элементов в <see cref="Plural"/>, <see cref="Masculine"/>, <see cref="Feminine"/> или <see cref="Neuter"/> массивах не равно шесть.
        /// </summary>
        public void Validate()
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                throw new ArgumentNullException(nameof(NounJson.Name), $"Adjective is missing required {nameof(AdjectiveJson.Name)} value.");
            }

            if (this.Plural == null)
            {
                throw new ArgumentNullException(nameof(NounJson.Singular), $"Adjective {this.Name} is missing required {nameof(AdjectiveJson.Plural)} value.");
            }

            if (this.Masculine == null)
            {
                throw new ArgumentNullException(nameof(NounJson.Singular), $"Adjective {this.Name} is missing required {nameof(AdjectiveJson.Masculine)} value.");
            }

            if (this.Feminine == null)
            {
                throw new ArgumentNullException(nameof(NounJson.Plural), $"Adjective {this.Name} is missing required {nameof(AdjectiveJson.Feminine)} value.");
            }

            if (this.Neuter == null)
            {
                throw new ArgumentNullException(nameof(NounJson.Plural), $"Adjective {this.Name} is missing required {nameof(AdjectiveJson.Neuter)} value.");
            }

            if (this.Plural.Length != 6)
            {
                throw new ArgumentException(nameof(NounJson.Singular), $"Adjective {this.Name} {nameof(AdjectiveJson.Plural)} has invalid number of values. There should be 6 values.");
            }

            if (this.Masculine.Length != 6)
            {
                throw new ArgumentException(nameof(NounJson.Singular), $"Adjective {this.Name} {nameof(AdjectiveJson.Masculine)} has invalid number of values. There should be 6 values.");
            }

            if (this.Feminine.Length != 6)
            {
                throw new ArgumentException(nameof(NounJson.Singular), $"Adjective {this.Name} {nameof(AdjectiveJson.Feminine)} has invalid number of values. There should be 6 values.");
            }

            if (this.Neuter.Length != 6)
            {
                throw new ArgumentException(nameof(NounJson.Singular), $"Adjective {this.Name} {nameof(AdjectiveJson.Neuter)} has invalid number of values. There should be 6 values.");
            }
        }
    }
}
