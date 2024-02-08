namespace Cyriller.Model
{
    public enum CasesEnum
    {
        /// <summary>
        /// Именительный, Кто? Что? (есть)
        /// </summary>
        Nominative = 1,

        /// <summary>
        /// Родительный, Кого? Чего? (нет)
        /// </summary>
        Genitive = 2,

        /// <summary>
        /// Дательный, Кому? Чему? (дам)
        /// </summary>
        Dative = 3,

        /// <summary>
        /// Винительный, Кого? Что? (вижу)
        /// </summary>
        Accusative = 4,

        /// <summary>
        /// Творительный, Кем? Чем? (горжусь)
        /// </summary>
        Instrumental = 5,

        /// <summary>
        /// Предложный, О ком? О чем? (думаю)
        /// </summary>
        Prepositional = 6
    }
}
