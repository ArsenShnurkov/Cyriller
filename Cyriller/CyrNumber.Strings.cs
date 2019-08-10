using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyriller.Model;

namespace Cyriller
{
    public partial class CyrNumber
    {
        protected class Strings
        {
            public Strings()
                : this(CasesEnum.Nominative, GendersEnum.Masculine, AnimatesEnum.Inanimated)
            {
            }

            public Strings(CasesEnum @case, GendersEnum gender, AnimatesEnum animate)
            {
                switch (@case)
                {
                    case CasesEnum.Nominative:
                        this.Hundreds = new string[] { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
                        this.Tens = new string[] { "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
                        this.Numbers = new string[] { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
                        this.Thousand = new string[] { "тысяча", "тысячи", "тысяч" };
                        this.Million = new string[] { "миллион", "миллиона", "миллионов" };
                        this.Billion = new string[] { "миллиард", "миллиарда", "миллиардов" };
                        this.Zero = "ноль";

                        if (gender == GendersEnum.Feminine)
                        {
                            this.Integer = new string[] { "целая", "целые", "целых" };
                            this.DecimalTen = new string[] { "десятая", "десятые", "десятых" };
                            this.DecimalHundred = new string[] { "сотая", "сотые", "сотых" };
                            this.DecimalThousand = new string[] { "тысячная", "тысячные", "тысячных" };
                            this.DecimalMillion = new string[] { "миллионная", "миллионные", "миллионных" };
                            this.DecimalBillion = new string[] { "миллиардная", "миллиардные", "миллиардных" };
                        }
                        else
                        {
                            this.Integer = new string[] { "целый", "целых", "целых" };
                            this.DecimalTen = new string[] { "десятый", "десятых", "десятых" };
                            this.DecimalHundred = new string[] { "сотый", "сотых", "сотых" };
                            this.DecimalThousand = new string[] { "тысячный", "тысячных", "тысячных" };
                            this.DecimalMillion = new string[] { "миллионный", "миллионных", "миллионных" };
                            this.DecimalBillion = new string[] { "миллиардный", "миллиардных", "миллиардных" };
                        }
                        break;
                    case CasesEnum.Genitive:
                        this.Hundreds = new string[] { "ста", "двухсот", "трехсот", "четырехсот", "пятисот", "шестисот", "семисот", "восьмисот", "девятисот" };
                        this.Tens = new string[] { "десяти", "двадцати", "тридцати", "сорока", "пятидесяти", "шестидесяти", "семидесяти", "весьмидесяти", "девяноста" };
                        this.Numbers = new string[] { "одного", "двух", "трех", "четырех", "пяти", "шести", "семи", "восьми", "девяти", "десяти", "одиннадцати", "двенадцати", "тринадцати", "четырнадцати", "пятнадцати", "шестнадцати", "семнадцати", "восемнадцати", "девятнадцати" };
                        this.Thousand = new string[] { "тысячи", "тысяч", "тысяч" };
                        this.Million = new string[] { "миллиона", "миллионов", "миллионов" };
                        this.Billion = new string[] { "миллиарда", "миллиардов", "миллиардов" };
                        this.Zero = "ноля";

                        if (gender == GendersEnum.Feminine)
                        {
                            this.Integer = new string[] { "целой", "целыми", "целыми" };
                            this.DecimalTen = new string[] { "десятой", "десятых", "десятых" };
                            this.DecimalHundred = new string[] { "сотой", "сотых", "сотых" };
                            this.DecimalThousand = new string[] { "тысячной", "тысячных", "тысячных" };
                            this.DecimalMillion = new string[] { "миллионной", "миллионных", "миллионных" };
                            this.DecimalBillion = new string[] { "миллиардной", "миллиардных", "миллиардных" };
                        }
                        else
                        {
                            this.Integer = new string[] { "целого", "целых", "целых" };
                            this.DecimalTen = new string[] { "десятого", "десятых", "десятых" };
                            this.DecimalHundred = new string[] { "сотого", "сотых", "сотых" };
                            this.DecimalThousand = new string[] { "тысячного", "тысячных", "тысячных" };
                            this.DecimalMillion = new string[] { "миллионного", "миллионных", "миллионных" };
                            this.DecimalBillion = new string[] { "миллиардного", "миллиардных", "миллиардных" };
                        }
                        break;
                    case CasesEnum.Dative:
                        this.Hundreds = new string[] { "ста", "двумстам", "тремстам", "четыремстам", "пятистам", "шестистам", "семистам", "восьмистам", "девятистам" };
                        this.Tens = new string[] { "десяти", "двадцати", "тридцати", "сорока", "пятидесяти", "шестидесяти", "семидесяти", "весьмидесяти", "девяноста" };
                        this.Numbers = new string[] { "одному", "двум", "трем", "четырем", "пяти", "шести", "семи", "восьми", "девяти", "десяти", "одиннадцати", "двенадцати", "тринадцати", "четырнадцати", "пятнадцати", "шестнадцати", "семнадцати", "восемнадцати", "девятнадцати" };
                        this.Thousand = new string[] { "тысяче", "тысячам", "тысячам" };
                        this.Million = new string[] { "миллиону", "миллионам", "миллионам" };
                        this.Billion = new string[] { "миллиарду", "миллиардам", "миллиардам" };
                        this.Zero = "ноля";

                        if (gender == GendersEnum.Feminine)
                        {
                            this.Integer = new string[] { "целой", "целым", "целым" };
                            this.DecimalTen = new string[] { "десятой", "десятым", "десятым" };
                            this.DecimalHundred = new string[] { "сотой", "сотым", "сотым" };
                            this.DecimalThousand = new string[] { "тысячной", "тысячным", "тысячным" };
                            this.DecimalMillion = new string[] { "миллионной", "миллионным", "миллионным" };
                            this.DecimalBillion = new string[] { "миллиардной", "миллиардным", "миллиардным" };
                        }
                        else
                        {
                            this.Integer = new string[] { "целому", "целым", "целым" };
                            this.DecimalTen = new string[] { "десятому", "десятым", "десятым" };
                            this.DecimalHundred = new string[] { "сотому", "сотым", "сотым" };
                            this.DecimalThousand = new string[] { "тысячному", "тысячным", "тысячным" };
                            this.DecimalMillion = new string[] { "миллионному", "миллионным", "миллионным" };
                            this.DecimalBillion = new string[] { "миллиардному", "миллиардным", "миллиардным" };
                        }
                        break;
                    case CasesEnum.Accusative:
                        this.Hundreds = new string[] { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
                        this.Tens = new string[] { "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };

                        if (animate == AnimatesEnum.Animated)
                        {
                            this.Numbers = new string[] { "одного", "двух", "трех", "четырех", "пять", "шести", "семи", "восьми", "девяти", "десяти", "одиннадцати", "двенадцати", "тринадцати", "четырнадцати", "пятнадцати", "шестнадцати", "семнадцати", "восемнадцати", "девятнадцати" };
                        }
                        else
                        {
                            this.Numbers = new string[] { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
                        }

                        this.Thousand = new string[] { "тысячу", "тысячи", "тысяч" };
                        this.Million = new string[] { "миллион", "миллиона", "миллионов" };
                        this.Billion = new string[] { "миллиард", "миллиарда", "миллиардов" };
                        this.Zero = "ноль";

                        if (gender == GendersEnum.Feminine)
                        {
                            this.Integer = new string[] { "целую", "целые", "целых" };
                            this.DecimalTen = new string[] { "десятую", "десятых", "десятых" };
                            this.DecimalHundred = new string[] { "сотую", "сотых", "сотых" };
                            this.DecimalThousand = new string[] { "тысячную", "тысячных", "тысячных" };
                            this.DecimalMillion = new string[] { "миллионную", "миллионныех", "миллионных" };
                            this.DecimalBillion = new string[] { "миллиардную", "миллиардных", "миллиардных" };
                        }
                        else
                        {
                            this.Integer = new string[] { "целого", "целых", "целых" };
                            this.DecimalTen = new string[] { "десятый", "десятых", "десятых" };
                            this.DecimalHundred = new string[] { "сотый", "сотых", "сотых" };
                            this.DecimalThousand = new string[] { "тысячный", "тысячных", "тысячных" };
                            this.DecimalMillion = new string[] { "миллионный", "миллионныех", "миллионных" };
                            this.DecimalBillion = new string[] { "миллиардный", "миллиардных", "миллиардных" };
                        }
                        break;
                    case CasesEnum.Instrumental:
                        this.Hundreds = new string[] { "ста", "двумястами", "тремястами", "четырьмястами", "пятьюстами", "шестьюстами", "семьюстами", "восьмьюстами", "девятьюстами" };
                        this.Tens = new string[] { "десятью", "двадцатью", "тридцатью", "сорока", "пятьюдесятью", "шестьюдесятью", "семьюдесятью", "восьмьюдесятью", "девяноста" };
                        this.Numbers = new string[] { "одним", "двумя", "тремя", "четырьмя", "пятью", "шестью", "семью", "восемью", "девятью", "десятью", "одиннадцатью", "двенадцатью", "тринадцатью", "четырнадцатью", "пятнадцатью", "шестнадцатью", "семнадцатью", "восемнадцатью", "девятнадцатью" };
                        this.Thousand = new string[] { "тысячей", "тысячами", "тысячами" };
                        this.Million = new string[] { "миллионом", "миллионами", "миллионами" };
                        this.Billion = new string[] { "миллиардом", "миллиардами", "миллиардами" };
                        this.Zero = "нолем";

                        if (gender == GendersEnum.Feminine)
                        {
                            this.Integer = new string[] { "целой", "целыми", "целыми" };
                            this.DecimalTen = new string[] { "десятой", "десятыми", "десятыми" };
                            this.DecimalHundred = new string[] { "сотой", "сотыми", "сотыми" };
                            this.DecimalThousand = new string[] { "тысячной", "тысячными", "тысячными" };
                            this.DecimalMillion = new string[] { "миллионной", "миллионными", "миллионными" };
                            this.DecimalBillion = new string[] { "миллиардной", "миллиардными", "миллиардными" };
                        }
                        else
                        {
                            this.Integer = new string[] { "целым", "целыми", "целыми" };
                            this.DecimalTen = new string[] { "десятым", "десятыми", "десятыми" };
                            this.DecimalHundred = new string[] { "сотым", "сотыми", "сотыми" };
                            this.DecimalThousand = new string[] { "тысячным", "тысячными", "тысячными" };
                            this.DecimalMillion = new string[] { "миллионным", "миллионными", "миллионными" };
                            this.DecimalBillion = new string[] { "миллиардным", "миллиардными", "миллиардными" };
                        }
                        break;
                    case CasesEnum.Prepositional:
                        this.Hundreds = new string[] { "ста", "двухстах", "трехстах", "четырехстах", "пятистах", "шестистах", "семистах", "восьмистах", "девятистах" };
                        this.Tens = new string[] { "десяти", "двадцати", "тридцати", "сорока", "пятидесяти", "шестидесяти", "семидесяти", "восьмидесяти", "девяноста" };
                        this.Numbers = new string[] { "одном", "двух", "трех", "четырех", "пяти", "шести", "семи", "восеми", "девяти", "десяти", "одиннадцати", "двенадцати", "тринадцати", "четырнадцати", "пятнадцати", "шестнадцати", "семнадцати", "восемнадцати", "девятнадцати" };
                        this.Thousand = new string[] { "тысяче", "тысячах", "тысячах" };
                        this.Million = new string[] { "миллионе", "миллионах", "миллионах" };
                        this.Billion = new string[] { "миллиарде", "миллиардах", "миллиардах" };
                        this.Zero = "ноле";

                        if (gender == GendersEnum.Feminine)
                        {
                            this.Integer = new string[] { "целой", "целых", "целых" };
                            this.DecimalTen = new string[] { "десятой", "десятых", "десятых" };
                            this.DecimalHundred = new string[] { "сотой", "сотых", "сотых" };
                            this.DecimalThousand = new string[] { "тысячной", "тысячных", "тысячных" };
                            this.DecimalMillion = new string[] { "миллионной", "миллионных", "миллионных" };
                            this.DecimalBillion = new string[] { "миллиардной", "миллиардных", "миллиардных" };
                        }
                        else
                        {
                            this.Integer = new string[] { "целом", "целых", "целых" };
                            this.DecimalTen = new string[] { "десятом", "десятых", "десятых" };
                            this.DecimalHundred = new string[] { "сотом", "сотых", "сотых" };
                            this.DecimalThousand = new string[] { "тысячном", "тысячных", "тысячных" };
                            this.DecimalMillion = new string[] { "миллионном", "миллионных", "миллионных" };
                            this.DecimalBillion = new string[] { "миллиардном", "миллиардных", "миллиардных" };
                        }
                        break;
                }

                if (gender == GendersEnum.Feminine)
                {
                    switch (@case)
                    {
                        case CasesEnum.Nominative:
                            this.Numbers[0] = "одна";
                            this.Numbers[1] = "две";
                            break;
                        case CasesEnum.Genitive:
                            this.Numbers[0] = "одной";
                            this.Numbers[1] = "двух";
                            break;
                        case CasesEnum.Dative:
                            this.Numbers[0] = "одной";
                            this.Numbers[1] = "двум";
                            break;
                        case CasesEnum.Accusative:
                            this.Numbers[0] = "одну";

                            if (animate == AnimatesEnum.Animated)
                            {
                                this.Numbers[1] = "двух";
                            }
                            else
                            {
                                this.Numbers[1] = "две";
                            }

                            break;
                        case CasesEnum.Instrumental:
                            this.Numbers[0] = "одной";
                            this.Numbers[1] = "двумя";
                            break;
                        case CasesEnum.Prepositional:
                            this.Numbers[0] = "одной";
                            this.Numbers[1] = "двух";
                            break;
                    }
                }
                else if (gender == GendersEnum.Neuter)
                {
                    switch (@case)
                    {
                        case CasesEnum.Nominative:
                            this.Numbers[0] = "одно";
                            break;
                        case CasesEnum.Genitive:
                            this.Numbers[0] = "одного";
                            break;
                        case CasesEnum.Dative:
                            this.Numbers[0] = "одному";
                            break;
                        case CasesEnum.Accusative:
                            this.Numbers[0] = "одно";
                            break;
                        case CasesEnum.Instrumental:
                            this.Numbers[0] = "одним";
                            break;
                        case CasesEnum.Prepositional:
                            this.Numbers[0] = "одном";
                            break;
                    }
                }
            }

            public string[] Hundreds { get; set; }
            public string[] Tens { get; set; }
            public string[] Numbers { get; set; }
            public string[] Thousand { get; set; }
            public string[] Million { get; set; }
            public string[] Billion { get; set; }
            public string Zero { get; set; }

            public string[] Integer { get; set; }
            public string[] DecimalTen { get; set; }
            public string[] DecimalHundred { get; set; }
            public string[] DecimalThousand { get; set; }
            public string[] DecimalMillion { get; set; }
            public string[] DecimalBillion { get; set; }
        }
    }
}
