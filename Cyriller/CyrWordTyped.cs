using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyriller.Model;

namespace Cyriller
{
    public partial class CyrWord
    {
        protected CyrResult DeclineNounAya()
        {
            string[] items = new string[] { "Джая", "Мая", "стая", "свая", "шемая" };
            CyrResult r = new CyrResult();

            r[1] =  w;

            if (items.Contains(w))
            {
                string[] yey = new string[] { "шемая" };

                r[2] = w.ReplaceRegex("я$", "и");
                r[3] = w.ReplaceRegex("я$", "е");
                r[4] = w.ReplaceRegex("я$", "ю");
                r[5] = yey.Contains(w) ? w.ReplaceRegex("я$", "ёй") : w.ReplaceRegex("я$", "ей");
                r[6] = w.ReplaceRegex("я$", "е");

                return r;
            }

            items = new string[] { "Аглая", "Ая", "Архелая", "Архилая", "входящая", "гончая", "гулящая", "Дая", "Даная", "Джая", "исходящая", "кормчая", "купчая", "Мая", "новоприезжая", "образующая", "падучая", "первородящая", "повторнородящая", "прихожая", "равнодействующая", "Рая", "разнорабочая", "свая", "секущая", "стая", "съезжая", "Тая", "телеведущая", "Фирая", "Хая", "Шенгелая", "передняя", "преисподняя" };

            if (items.Contains(w))
            {
                r[2] = w.ReplaceRegex("[ая]я$", "ей");
                r[3] = w.ReplaceRegex("[ая]я$", "ей");
                r[4] = w.RegexHasMatches("яя$") ? w.ReplaceRegex("яя$", "юю") : w.ReplaceRegex("ая$", "ую");
                r[5] = w.ReplaceRegex("[ая]я$", "ей");
                r[6] = w.ReplaceRegex("[ая]я$", "ей");

                return r;
            }

            r[2] = w.ReplaceRegex("[ая]я$", "ой");
            r[3] = w.ReplaceRegex("[ая]я$", "ой");
            r[4] = w.ReplaceRegex("[ая]я$", "ую");
            r[5] = w.ReplaceRegex("[ая]я$", "ой");
            r[6] = w.ReplaceRegex("[ая]я$", "ой");

            return r;
        }

        protected CyrResult DeclineNounBok()
        {
            string[] bokom = new string[] { "бок", "лежебок", "шпрингбок" };

            if (bokom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounCa()
        {
            string[] coy = new string[] { "Аца", "гнильца", "грязнотца", "грязца", "кислеца", "краснотца", "наглеца", "Потенца", "сипотца", "сольца", "сырца", "Тверца", "трусца", "хитреца", "хрипотца", "Чепца", "кислотца", "крепостца", "ленца", "маца", "овца", "пыльца", "рысца", "тенца", "трясца" };

            if (!coy.Contains(w))
            {
                return this.DeclineNoun1();
            }

            CyrResult r = new CyrResult(w,
                w.ReplaceRegex("а$", "ы"),
                w.ReplaceRegex("а$", "е"),
                w.ReplaceRegex("а$", "у"),
                w.ReplaceRegex("а$", "ой"),
                w.ReplaceRegex("а$", "е"));

            return r;
        }

        protected CyrResult DeclineNounCha()
        {
            string[] choy = new string[] { "Авача", "Адыча", "алыча", "арча", "бахча", "епанча", "Кавача", "каланча", "камча", "каракульча", "карча", "кяманча", "Могоча", "моча", "парча", "пиросвеча", "саранча", "свеча", "Солодча", "Сунгача", "фут-свеча", "чавыча", "чесуча" };

            if (choy.Contains(w))
            {
                return this.DeclineNoun1();
            }

            CyrResult r = new CyrResult(w,
                w.ReplaceRegex("а$", "и"),
                w.ReplaceRegex("а$", "е"),
                w.ReplaceRegex("а$", "у"),
                w.ReplaceRegex("а$", "ей"),
                w.ReplaceRegex("а$", "е"));

            return r;
        }

        protected CyrResult DeclineNounChiy()
        {
            string[] chiem = new string[] { "чий" };
            CyrResult r = new CyrResult();

            r[1] = w;

            if (chiem.Contains(w))
            {
                r[2] = w.ReplaceRegex("й$", "я");
                r[3] = w.ReplaceRegex("й$", "ю");
                r[4] = w;
                r[5] = w.ReplaceRegex("й$", "ем");
                r[6] = w.ReplaceRegex("й$", "и");
            }
            else
            {
                r[2] = w.ReplaceRegex("ий$", "его");
                r[3] = w.ReplaceRegex("ий$", "ему");
                r[4] = this.IsAnimated ? w.ReplaceRegex("ий$", "его") : w;
                r[5] = w.ReplaceRegex("й$", "м");
                r[6] = w.ReplaceRegex("ий$", "ем");
            }

            return r;
        }

        protected CyrResult DeclineNounEc()
        {
            if (this.w.RegexHasMatches("[еиуаоэ]ец$"))
            {
                return this.DeclineNounIec();
            }

            CyrResult r = new CyrResult();
            string[] icom = new string[] { "белец", "валец", "гнилец", "голец", "делец", "Елец", "жилец", "Ингулец", "козелец", "малец", "оголец", "стрелец", "телец", "удалец" };

            r[1] = w;

            if (icom.Contains(w))
            {
                r[2] = w.ReplaceRegex("ец$", "ьца");
                r[3] = w.ReplaceRegex("ец$", "ьцу");
                r[4] = this.IsAnimated ? w.ReplaceRegex("ец$", "ьца") : w;
                r[5] = w.ReplaceRegex("ец$", "ьцом");
                r[6] = w.ReplaceRegex("ец$", "ьце");

                return r;
            }

            string[] icem = new string[] { "автовладелец", "агулец", "анголец", "антилец", "архангелец", "барнаулец", "бенгалец", "богомолец", "браззавилец", "бразилец", "бригадмилец", "брюсселец", "венесуэлец", "владелец", "гватемалец", "грузовладелец", "давалец", "дачевладелец", "доброволец", "домовладелец", "забайкалец", "землевладелец", "земледелец", "израилец", "кабулец", "кампалец", "капиталец", "каргополец", "кастилец", "кералец", "комсомолец", "кормилец", "кызылец", "латгалец", "ливерпулец", "малец", "манилец", "мариуполец", "марселец", "материалец", "мингрелец", "монреалец", "народоволец", "неандерталец", "невелец", "негидалец", "непалец", "нижнетагилец", "николец", "норилец", "огнеземелец", "однофамилец", "палец", "патентовладелец", "перевалец", "пномпенец", "погорелец", "поилец", "помолец", "португалец", "постоялец", "пришелец", "провансалец", "рабовладелец", "развалец", "рамаллец", "рутулец", "рыдалец", "садовладелец", "сан-паулец", "севастополец", "сейшелец", "сенегалец", "сеулец", "сиделец", "симферополец", "сингалец", "скиталец", "смалец", "совладелец", "ставрополец", "стамбулец", "стоялец", "страдалец", "судовладелец", "суздалец", "тагилец", "тамилец", "тиролец", "тоболец", "товаровладелец", "трансваалец", "умелец", "уралец", "фалец", "чернобылец", "шахтовладелец" };

            if (icem.Contains(w))
            {
                r[2] = w.ReplaceRegex("ец$", "ьца");
                r[3] = w.ReplaceRegex("ец$", "ьцу");
                r[4] = this.IsAnimated ? w.ReplaceRegex("ец$", "ьца") : w;
                r[5] = w.ReplaceRegex("ец$", "ьцем");
                r[6] = w.ReplaceRegex("ец$", "ьце");

                return r;
            }

            string[] ecem = new string[] { "Алексец", "Бец", "Бурец", "Вавжинец", "военспец", "выжлец", "главспец", "Кобец", "промсырец", "спец", "флец", "Хейфец", "Штирлец" };

            if (ecem.Contains(w))
            {
                return this.DeclineNoun2Simple(true);
            }

            string[] ecom = new string[] { "багрец", "беглец", "близнец", "военспец", "главспец", "гордец", "дохлец", "жнец", "жрец", "игрец", "кольчец", "кострец", "кузнец", "лжец", "льстец", "мертвец", "мокрец", "мудрец", "наглец", "нутрец", "овсец", "орлец", "острец", "пиздец", "подлец", "пошлец", "пришлец", "простец", "ремнец", "рожнец", "спец", "стервец", "тяглец", "хитрец", "храбрец", "чабрец", "червец", "чернец", "чистец", "чтец", "швец", "шельмец" };

            if (ecom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            string[] com = new string[] { "аржанец", "белец", "Бобринец", "боец", "борец", "бубенец", "валец", "варенец", "вдовец", "венец", "волосенец", "волчец", "Волынец", "глупец", "гнилец", "голбец", "голубец", "голец", "гонец", "Городец", "Гороховец", "гребец", "Грязовец", "дворец", "делец", "долгунец", "донец", "Елец", "жеребец", "живец", "жилец", "звонец", "зеленец", "зубец", "изразец", "Икорец", "Ингулец", "истец", "каганец", "клинец", "Ковалец", "козелец", "конец", "корец", "косец", "Кременец", "крестец", "купец", "ларец", "леденец", "ловец", "малец", "молодец", "Моржовец", "муромец", "Мухавец", "образец", "оголец", "огурец", "Олонец", "отец", "певец", "перепродавец", "песец", "Петродворец", "писец", "плавунец", "пловец", "погребец", "поставец", "продавец", "птенец", "путец", "резец", "ржанец", "рубец", "рунец", "рыбец", "самец", "светец", "свинец", "севец", "синец", "скворец", "скопец", "скупец", "слепец", "слопец", "соистец", "солонец", "сорванец", "сосец", "ставец", "столбец", "Сторожинец", "стрелец", "стригунец", "струнец", "сукугунец", "сыпец", "сыровец", "сырец", "таганец", "творец", "телец", "тетраэтилсвинец", "типец", "Торопец", "торец", "трепец", "Тростянец", "Трускавец", "тунец", "тупец", "удалец", "федосеевец", "хвостец", "хлопунец", "холодец", "хромец", "Чадобец", "чепец", "Череповец", "щипец", "юнец", "ясенец" };

            if (com.Contains(w))
            {
                return this.DeclineNoun2WithoutSuffix();
            }

            return this.DeclineNoun2WithoutSuffix(true);
        }

        protected CyrResult DeclineNounEk()
        {
            if (w.RegexHasMatches("щек$"))
            {
                return this.DeclineNoun2Simple();
            }

            CyrResult r = new CyrResult();

            r[1] = w;

            if (w.RegexHasMatches("[аеоуи][её]к$"))
            {
                r[2] = w.ReplaceRegex(".к$", "йка");
                r[3] = w.ReplaceRegex(".к$", "йку");
                r[4] = this.IsAnimated ? w.ReplaceRegex(".к$", "йка") : w;
                r[5] = w.ReplaceRegex(".к$", "йком");
                r[6] = w.ReplaceRegex(".к$", "йке");

                return r;
            }

            if (w.RegexHasMatches("[жчш][её]к$"))
            {
                string[] ekom = new string[] { "Джек", "гачек", "Гекчек", "Гульчечек", "жиро-чек", "чек", "Абхишек", "Арташек", "Гашек", "Лешек", "Мнишек", "тамашек", "Франтишек", "Францишек" };

                if (ekom.Contains(w))
                {
                    return this.DeclineNoun2Simple();
                }

                return this.DeclineNoun2WithoutSuffix();
            }

            string[] ikom = new string[] { "белёк", "валёк", "василёк", "вензелёк", "гусёк", "денёк", "зверёк", "зятёк", "камелёк", "киселёк", "клубенёк", "князёк", "кобелёк", "козырёк", "комелёк", "конёк", "королёк", "кошелёк", "кренделёк", "кулёк", "куманёк", "ларёк", "линёк", "малёк", "мотылёк", "муженёк", "мулёк", "огонёк", "окунёк", "паренёк", "пенёк", "перстенёк", "поршенёк", "пуделёк", "пузырёк", "стебелёк", "стерженёк", "тебенёк", "тенёк", "тигелёк", "тополёк", "уголёк", "угорёк", "фитилёк", "флигелёк", "хмелёк", "хорёк", "царёк", "шпенёк", "штырёк", "якорёк", "Оленек" };

            if (ikom.Contains(w))
            {
                r[2] = w.ReplaceRegex("[её]к$", "ька");
                r[3] = w.ReplaceRegex("[её]к$", "ьку");
                r[4] = this.IsAnimated ? w.ReplaceRegex("[её]к$", "ька") : w;
                r[5] = w.ReplaceRegex("[её]к$", "ьком");
                r[6] = w.ReplaceRegex("[её]к$", "ьке");

                return r;
            }

            return this.DeclineNoun2Simple();
        }

        protected CyrResult DeclineNounEl()
        {
            string[] lom = new string[] { "авиаузел", "аэроузел", "вымысел", "гидроузел", "домысел", "дятел", "замысел", "кобёл", "козёл", "котёл", "микроузел", "нефтепромысел", "окисел", "осёл", "орёл", "Павел", "пепел", "подузел", "помысел", "промысел", "радиоузел", "санузел", "солепромысел", "узел", "умысел", "электрокотел", "орел", "осел" };

            if (!lom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounEn()
        {
            string[] inom = new string[] { "лен" };
            CyrResult r = new CyrResult();

            r[1] = w;

            if (inom.Contains(w))
            {
                r[2] = w.ReplaceRegex("ен$", "ьна");
                r[3] = w.ReplaceRegex("ен$", "ьну");
                r[4] = this.IsAnimated ? w.ReplaceRegex("ен$", "ьна") : w;
                r[5] = w.ReplaceRegex("ен$", "ьном");
                r[6] = w.ReplaceRegex("ен$", "ьне");

                return r;
            }

            string[] nom = new string[] { "Брисбен", "бубен", "молебен", "овен" };

            if (nom.Contains(w))
            {
                return this.DeclineNoun2WithoutSuffix();
            }

            return this.DeclineNoun2Simple();
        }

        protected CyrResult DeclineNounEli()
        {
            if (this.gender == GendersEnum.Feminine)
            {
                return this.DeclineNoun3();
            }

            string[] lem = new string[] { "кашель", "кегель", "комель", "стебель", "тигель" };
            CyrResult r = new CyrResult();

            r[1] = w;

            if (lem.Contains(w))
            {
                r[2] = w.ReplaceRegex("ель$", "ля");
                r[3] = w.ReplaceRegex("ель$", "лю");
                r[4] = this.IsAnimated ? w.ReplaceRegex("ель$", "ля") : w;
                r[5] = w.ReplaceRegex("ель$", "лем");
                r[6] = w.ReplaceRegex("ель$", "ле");

                return r;
            }

            string[] yom = new string[] { "жавель", "кисель", "кобель", "коростель", "кошель", "рубель", "скарпель", "шмель", "щавель" };

            r[2] = w.ReplaceRegex("ь$", "я");
            r[3] = w.ReplaceRegex("ь$", "ю");
            r[4] = this.IsAnimated ? w.ReplaceRegex("ь$", "я") : w;
            r[5] = yom.Contains(w) ? w.ReplaceRegex("ь$", "ём") : w.ReplaceRegex("ь$", "ем");
            r[6] = w.ReplaceRegex("ь$", "е");

            return r;
        }

        protected CyrResult DeclineNounEni()
        {
            if (this.gender == GendersEnum.Feminine)
            {
                return this.DeclineNoun3();
            }

            string[] yom;
            string[] enem = new string[] { "бюллетень", "гордень", "женьшень", "Ильмень", "кетмень", "кипень", "кистень", "Коростень", "курень", "нок-гордень", "олень", "пельмень", "Пномпень", "ревень", "руслень", "таймень", "тюлень", "уздень", "Урень", "чекмень", "Червень", "шпень", "ясень", "ячмень" };
            CyrResult r = new CyrResult();

            r[1] = w;

            if (enem.Contains(w))
            {
                yom = new string[] { "кетмень", "кистень", "курень", "ревень", "уздень", "чекмень", "шпень", "ячмень" };
                r[2] = w.ReplaceRegex("ь$", "я");
                r[3] = w.ReplaceRegex("ь$", "ю");
                r[4] = this.IsAnimated ? w.ReplaceRegex("ь$", "я") : w;
                r[5] = yom.Contains(w) ? w.ReplaceRegex("ь$", "ём") : w.ReplaceRegex("ь$", "ем");
                r[6] = w.ReplaceRegex("ь$", "е");

                return r;
            }

            if (w == "увалень")
            {
                r[2] = w.ReplaceRegex("ень$", "ьня");
                r[3] = w.ReplaceRegex("ень$", "ьню");
                r[4] = w.ReplaceRegex("ень$", "ьня");
                r[5] = w.ReplaceRegex("ень$", "ьнем");
                r[6] = w.ReplaceRegex("ень$", "ьне");

                return r;
            }

            yom = new string[] { "день", "кремень", "пень", "плетень", "ремень", "слепень", "трудодень", "человеко-день" };
            r[2] = w.ReplaceRegex("ень$", "ня");
            r[3] = w.ReplaceRegex("ень$", "ню");
            r[4] = this.IsAnimated ? w.ReplaceRegex("ень$", "ня") : w;
            r[5] = yom.Contains(w) ? w.ReplaceRegex("ень$", "нём") : w.ReplaceRegex("ень$", "нем");
            r[6] = w.ReplaceRegex("ень$", "не");

            return r;
        }

        protected CyrResult DeclineNounEr()
        {
            string[] rom = new string[] { "ветер", "ковёр", "копёр", "одёр", "Одер", "чабёр", "бобёр", "шабёр" };

            if (!rom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounEs()
        {
            string[] som = new string[] { "овёс", "пёс" };

            if (!som.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounEy()
        {
            string[] iem = new string[] { "воробей", "жеребей", "ирей", "муравей", "репей", "ручей", "Сатаней", "соловей", "улей", "чирей" };
            CyrResult r = new CyrResult();

            r[1] = w;

            if (iem.Contains(w))
            {
                string[] yom = new string[] { "воробей", "муравей", "репей", "ручей", "соловей" };

                r[2] = w.ReplaceRegex(".й$", "ья");
                r[3] = w.ReplaceRegex(".й$", "ью");
                r[4] = this.IsAnimated ? w.ReplaceRegex(".й$", "ья") : w;
                r[5] = yom.Contains(w) ? w.ReplaceRegex(".й$", "ьём") : w.ReplaceRegex(".й$", "ьем");
                r[6] = w.ReplaceRegex(".й$", "ье");

                return r;
            }

            string[] ei = new string[] { "рэлей", "урей" };

            r[2] = w.ReplaceRegex("й$", "я");
            r[3] = w.ReplaceRegex("й$", "ю");
            r[4] = this.IsAnimated ? w.ReplaceRegex("й$", "я") : w;
            r[5] = w.ReplaceRegex("й$", "ем");
            r[6] = ei.Contains(w) ? w.ReplaceRegex("й$", "и") : w.ReplaceRegex("й$", "е");

            return r;
        }

        protected CyrResult DeclineNounEzh()
        {
            if (w.EndsWith("ёж"))
            {
                
                CyrResult r = this.DeclineNoun2Simple();

                return CutNounYo(r);
            }

            string[] ezhem = new string[] { "бареж", "Воронеж", "Кебеж", "коллеж", "кортеж", "Льеж", "манеж", "Нововоронеж", "Радонеж", "Реж", "Себеж", "Сенеж", "Сереж", "Трубеж", "Фатеж", "цеж" };

            if (ezhem.Contains(w))
            {
                return this.DeclineNoun2Simple(true);
            }

            return this.DeclineNoun2Simple();
        }

        protected CyrResult DeclineNounDi()
        {
            if (this.gender == GendersEnum.Feminine)
            {
                return this.DeclineNoun3();
            }

            string[] dom = new string[] { "господь" };
            CyrResult r = new CyrResult();

            r[1] = w;

            if (dom.Contains(w))
            {
                r[2] = w.ReplaceRegex("ь$", "а");
                r[3] = w.ReplaceRegex("ь$", "у");
                r[4] = w.ReplaceRegex("ь$", "а");
                r[5] = w.ReplaceRegex("ь$", "ом");
                r[6] = w.ReplaceRegex("ь$", "е");

                return r;
            }

            string[] yom = new string[] { "вождь", "гвоздь", "груздь", "дождь" };

            r[2] = w.ReplaceRegex("ь$", "я");
            r[3] = w.ReplaceRegex("ь$", "ю");
            r[4] = this.IsAnimated ? w.ReplaceRegex("ь$", "я") : w;
            r[5] = yom.Contains(w) ? w.ReplaceRegex("ь$", "ём") : w.ReplaceRegex("ь$", "ем");
            r[6] = w.ReplaceRegex("ь$", "е");

            return r;
        }

        protected CyrResult DeclineNounDok()
        {
            string[] dokom = new string[] { "диплодок", "док", "едок", "ездок", "медок", "Моздок", "оподельдок", "паддок", "седок" };

            if (dokom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounDoy()
        {
            string[] dym = new string[] { "гнедой" };
            CyrResult r;

            if (dym.Contains(w))
            {
                r = new CyrResult(w,
                    w.ReplaceRegex("й$", "го"),
                    w.ReplaceRegex("й$", "му"),
                    w.ReplaceRegex("й$", "го"),
                    w.ReplaceRegex("ой$", "ым"),
                    w.ReplaceRegex("й$", "м"));

                return r;
            }

            r = new CyrResult(w,
                w.ReplaceRegex("й$", "я"),
                w.ReplaceRegex("й$", "ю"),
                w.ReplaceRegex("й$", "я"),
                w.ReplaceRegex("й$", "ем"),
                w.ReplaceRegex("й$", "е"));

            return r;
        }

        protected CyrResult DeclineNounIec()
        {
            CyrResult r = new CyrResult();
            string[] ycom = new string[] { "боец" };

            r[1] = w;
            r[2] = w.ReplaceRegex("ец$", "йца");
            r[3] = w.ReplaceRegex("ец$", "йцу");
            r[4] = w.ReplaceRegex("ец$", "йца");
            r[5] = ycom.Contains(w) ? w.ReplaceRegex("ец$", "йцом") : w.ReplaceRegex("ец$", "йцем");
            r[6] = w.ReplaceRegex("ец$", "йце");

            return r;
        }

        protected CyrResult DeclineNounIe()
        {
            string[] ie = new string[] { "меджидие", "мумие", "острие", "плие" };

            if (!ie.Contains(w))
            {
                return this.DeclineNoun2();
            }

            CyrResult r = new CyrResult(w,
                w.ReplaceRegex("е$", "я"),
                w.ReplaceRegex("е$", "ю"),
                w,
                w + "м",
                w);

            return r;
        }

        protected CyrResult DeclineNounIna()
        {
            string[] ino = new string[] { "голосина", "горбина", "дождина", "домина", "кирпичина", "кусина", "лбина", "мостина", "островина", "стволина", "сугробина", "холодина" };

            if (!ino.Contains(w))
            {
                return this.DeclineNoun1();
            }

            CyrResult r = new CyrResult(w,
                w.ReplaceRegex("а$", "ы"),
                w.ReplaceRegex("а$", "е"),
                w.ReplaceRegex("а$", "о"),
                w.ReplaceRegex("а$", "ой"),
                w.ReplaceRegex("а$", "е"));

            return r;
        }

        protected CyrResult DeclineNounIsh()
        {
            string[] om = new string[] { "свищ", "кишмиш", "шиш", "стриж", "чиж" };

            if (om.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2Simple(true);
        }

        protected CyrResult DeclineNounIysya()
        {
            CyrResult r = new CyrResult(w,
                w.ReplaceRegex("ийся$", "егося"),
                w.ReplaceRegex("ийся$", "емуся"),
                w.ReplaceRegex("ийся$", "егося"),
                w.ReplaceRegex("ийся$", "имся"),
                w.ReplaceRegex("ийся$", "емся"));

            return r;
        }

        protected CyrResult DeclineNounKiy()
        {
            string[] iem = new string[] { "кий", "эпиникий" };
            CyrResult r = new CyrResult();

            r[1] = w;

            if (iem.Contains(w))
            {
                string[] ii = new string[] { "кий", "эпиникий", "Маврикий" };

                r[2] = w.ReplaceRegex("й$", "я");
                r[3] = w.ReplaceRegex("й$", "ю");
                r[4] = w;
                r[5] = w.ReplaceRegex("й$", "ем");
                r[6] = ii.Contains(w) ? w.ReplaceRegex("й$", "и") : w.ReplaceRegex("й$", "е");

                return r;
            }

            r[2] = w.ReplaceRegex("ий$", "ого");
            r[3] = w.ReplaceRegex("ий$", "ому");
            r[4] = this.IsAnimated ? w.ReplaceRegex("ий$", "ого") : w;
            r[5] = w.ReplaceRegex("й$", "м");
            r[6] = w.ReplaceRegex("ий$", "ом");

            return r;
        }

        protected CyrResult DeclineNounLica()
        {
            CyrResult r = new CyrResult();
            string[] cey = new string[] { "развальца" };

            r[1] = w;
            r[2] = w.ReplaceRegex("а$", "ы");
            r[3] = w.ReplaceRegex("а", "е");
            r[4] = w.ReplaceRegex("а", "у");
            r[5] = cey.Contains(w) ? w.ReplaceRegex("а", "ей") : w.ReplaceRegex("а", "ой");
            r[6] = w.ReplaceRegex("а", "е");

            return r;
        }

        protected CyrResult DeclineNounLok()
        {
            string[] locom = new string[] { "Алок", "Баллок", "блок", "брелок", "взволок", "видеоблок", "войлок", "волок", "гакблок", "дымоволок", "изволок", "кеш-блок", "кильблок", "клок", "кронблок", "микроблок", "моноблок", "мотоблок", "наволок", "переволок", "пищеблок", "подблок", "подволок", "стеклоблок", "сулок", "суперблок", "теплоблок", "фиш-блок", "хамерлок", "Хилок", "хозблок", "чеглок", "Шерлок", "шлакоблок", "щёлок", "энергоблок" };

            if (locom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounMok()
        {
            string[] mokom = new string[] { "амок", "причмок" };

            if (mokom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounMiy()
        {
            CyrResult r = new CyrResult(w,
                w.ReplaceRegex("й$", "я"),
                w.ReplaceRegex("й$", "ю"),
                this.IsAnimated ? w.ReplaceRegex("й$", "я") : w,
                w.ReplaceRegex("й$", "ем"),
                w.ReplaceRegex("й$", "и"));

            return r;
        }

        protected CyrResult DeclineNounMya()
        {
            string[] mem = new string[] { "полымя" };
            CyrResult r = new CyrResult();

            r[1] = w;

            if (w == "полымя")
            {
                r[2] = w;
                r[3] = w;
                r[4] = w;
                r[5] = w.ReplaceRegex("я$", "ем");
                r[6] = w.ReplaceRegex("я$", "е");
            }
            else
            {
                r[2] = w.ReplaceRegex("я$", "ени");
                r[3] = w.ReplaceRegex("я$", "ени");
                r[4] = w;
                r[5] = w.ReplaceRegex("я$", "енем");
                r[6] = w.ReplaceRegex("я$", "ени");
            }

            return r;
        }

        protected CyrResult DeclineNounNiy()
        {
            string[] nim = new string[] { "ближний", "всевышний", "Застрожний", "полусредний", "Самотечний" };
            CyrResult r = new CyrResult();

            r[1] = w;

            if (nim.Contains(w))
            {
                r[2] = w.ReplaceRegex("ий$", "его");
                r[3] = w.ReplaceRegex("ий$", "ему");
                r[4] = this.IsAnimated ? w.ReplaceRegex("ий$", "его") : w;
                r[5] = w.ReplaceRegex("ий$", "им");
                r[6] = w.ReplaceRegex("ий$", "ем");

                return r;
            }

            r[2] = w.ReplaceRegex("й$", "я");
            r[3] = w.ReplaceRegex("й$", "ю");
            r[4] = this.IsAnimated ? w.ReplaceRegex("й$", "я") : w;
            r[5] = w.ReplaceRegex("й$", "ем");
            r[6] = w.ReplaceRegex("й$", "и");

            return r;
        }

        protected CyrResult DeclineNounOl()
        {
            string[] lom = new string[] { "Баянгол", "Мисол", "мосол", "посол", "угол", "хохол", "чехол", "щегол" };

            if (!lom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounOn()
        {
            string[] nom = new string[] { "козон", "Кэсон", "Лусон", "Могзон", "полусон", "рожон", "Сатирикон", "сон", "Тэджон", "электросон" };

            if (!nom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounOni()
        {
            if (this.gender == GendersEnum.Feminine)
            {
                return this.DeclineNoun3();
            }

            string[] nem = new string[] { "заградогонь", "огонь" };
            CyrResult r = new CyrResult();
            string[] yom;

            r[1] = w;

            if (nem.Contains(w))
            {
                yom = new string[] { "заградогонь", "огонь" };
                r[2] = w.ReplaceRegex("онь$", "ня");
                r[3] = w.ReplaceRegex("онь$", "ню");
                r[4] = w;
                r[5] = yom.Contains(w) ? w.ReplaceRegex("онь$", "нём") : w.ReplaceRegex("онь$", "нем");
                r[6] = w.ReplaceRegex("онь$", "не");

                return r;
            }

            yom = new string[] { "конь" };
            r[2] = w.ReplaceRegex("ь$", "я");
            r[3] = w.ReplaceRegex("ь$", "ю");
            r[4] = this.IsAnimated ? w.ReplaceRegex("ь$", "я") : w;
            r[5] = yom.Contains(w) ? w.ReplaceRegex("ь$", "ём") : w.ReplaceRegex("ь$", "ем");
            r[6] = w.ReplaceRegex("ь$", "е");

            return r;
        }

        protected CyrResult DeclineNounOvi()
        {
            string[] bvi = new string[] { "любовь", "нелюбовь", "церковь" };

            if (!bvi.Contains(w))
            {
                return this.DeclineNoun3();
            }

            CyrResult r = new CyrResult(w,
                w.ReplaceRegex("овь$", "ви"),
                w.ReplaceRegex("овь$", "ви"),
                w,
                w + "ю",
                w.ReplaceRegex("овь$", "ви"));

            return r;
        }

        protected CyrResult DeclineNounOr()
        {
            string[] rom = new string[] { "багор", "бугор", "вихор", "Лахор", "свекор", "Шамхор", "Щугор", "свёкор" };

            if (!rom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounOri()
        {
            string[] orem = new string[] { "осокорь", "хорь", "якорь" };
            CyrResult r = new CyrResult();
            string[] yom;

            r[1] = w;

            if (orem.Contains(w))
            {
                yom = new string[] { "хорь" };
                r[2] = w.ReplaceRegex("ь$", "я");
                r[3] = w.ReplaceRegex("ь$", "ю");
                r[4] = this.IsAnimated ? w.ReplaceRegex("ь$", "я") : w;
                r[5] = yom.Contains(w) ? w.ReplaceRegex("ь$", "ём") : w.ReplaceRegex("ь$", "ем");
                r[6] = w.ReplaceRegex("ь$", "е");

                return r;
            }

            string[] riyu = new string[] { "Орь", "корь", "хворь" };

            if (riyu.Contains(w))
            {
                r[2] = w.ReplaceRegex("ь$", "и");
                r[3] = w.ReplaceRegex("ь$", "и");
                r[4] = this.IsAnimated ? w.ReplaceRegex("ь$", "и") : w;
                r[5] = w + "ю";
                r[6] = w.ReplaceRegex("ь$", "и");

                return r;
            }

            yom = new string[] { "угорь" };
            r[2] = w.ReplaceRegex("орь$", "ря");
            r[3] = w.ReplaceRegex("орь$", "рю");
            r[4] = this.IsAnimated ? w.ReplaceRegex("орь$", "ря") : w;
            r[5] = yom.Contains(w) ? w.ReplaceRegex("орь$", "рём") : w.ReplaceRegex("орь$", "рем");
            r[6] = w.ReplaceRegex("орь$", "ре");

            return r;
        }

        protected CyrResult DeclineNounOsh()
        {
            string[] shom = new string[] { "хвощ", "грош" };

            if (shom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2Simple(true);
        }

        protected CyrResult DeclineNounOti()
        {
            if (this.gender == GendersEnum.Feminine)
            {
                return this.DeclineNoun3();
            }

            CyrResult r = new CyrResult(w,
                w.ReplaceRegex("оть$", "тя"),
                w.ReplaceRegex("оть$", "тю"),
                this.IsAnimated ? w.ReplaceRegex("оть$", "тя") : w,
                w.ReplaceRegex("оть$", "тем"),
                w.ReplaceRegex("оть$", "те"));

            return r;
        }

        protected CyrResult DeclineNounOy()
        {
            string[] ym = new string[] { "авторулевой", "блатной", "вороной", "гнедой", "горновой", "городовой", "домовой", "ездовой", "живой", "загребной", "золотой", "зубной", "ковшевой", "кордовой", "лозовой", "мастеровой", "мачтовой", "мнимобольной", "номерной", "плитовой", "половой", "пультовой", "радиопозывной", "слепоглухонемой", "становой", "стволовой", "Стрежевой", "стреловой", "стременной", "часовой", "Чусовой", "штабной", "штрафной", "шумковой", "щелевой", "Яровой", "Броневой", "берестовой", "гирорулевой", "копровой", "костровой", "лотовой", "люковой", "марсовой", "нервнобольной", "островой", "понятой", "портной", "Толстой", "юровой" };
            CyrResult r = new CyrResult();

            r[1] = w;

            if (ym.Contains(w))
            {
                r[2] = w.ReplaceRegex("й$", "го");
                r[3] = w.ReplaceRegex("й$", "му");
                r[4] = this.IsAnimated ? w.ReplaceRegex("й$", "го") : w;
                r[5] = w.ReplaceRegex("ой$", "ым");
                r[6] = w.ReplaceRegex("й$", "м");

                return r;
            }

            string[] im = new string[] { "городской", "Лонской", "Луговской", "Мостовской", "старшой", "Сухой", "Трубецкой", "Чепурной", "Донской", "руцкой", "сверхбольшой", "слепоглухой" };

            if (im.Contains(w))
            {
                r[2] = w.ReplaceRegex("й$", "го");
                r[3] = w.ReplaceRegex("й$", "му");
                r[4] = this.IsAnimated ? w.ReplaceRegex("й$", "го") : w;
                r[5] = w.ReplaceRegex("ой$", "им");
                r[6] = w.ReplaceRegex("й$", "м");

                return r;
            }

            r[2] = w.ReplaceRegex("й$", "я");
            r[3] = w.ReplaceRegex("й$", "ю");
            r[4] = this.IsAnimated ? w.ReplaceRegex("й$", "я") : w;
            r[5] = w.ReplaceRegex("й$", "ем");
            r[6] = w.ReplaceRegex("й$", "е");

            return r;
        }

        protected CyrResult DeclineNounOzh()
        {
            if (w.RegexHasMatches("нож$"))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2Simple(true);
        }

        protected CyrResult DeclineNounOh()
        {
            string[] nom = new string[] { "мох" };

            if (!nom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounRok()
        {
            string[] rokom = new string[] { "бедрок", "дрок", "зарок", "игрок", "лжепророк", "морок", "оброк", "обморок", "окорок", "отрок", "плимутрок", "полуобморок", "порок", "пророк", "прок", "рок", "смотрок", "срок", "трок", "урок", "шлафрок" };

            if (rokom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounSFok()
        {
            string[] sokom = new string[] { "монегасок", "сок", "фок" };

            if (!sokom.Contains(w))
            {
                return this.DeclineNoun2WithoutSuffix();
            }

            return this.DeclineNoun2Simple();
        }

        protected CyrResult DeclineNounSha()
        {
            string[] shoy = new string[] { "моща", "праща", "Абаша", "душа", "лапша", "левша", "парша", "правша", "Тараша", "томоша", "черемша", "шакша", "шебарша" };

            if (!shoy.Contains(w))
            {
                return this.DeclineNoun1();
            }

            CyrResult r = new CyrResult(w,
                w.ReplaceRegex("а$", "и"),
                w.ReplaceRegex("а$", "е"),
                w.ReplaceRegex("а$", "у"),
                w.ReplaceRegex("а$", "ой"),
                w.ReplaceRegex("а$", "е"));

            return r;
        }

        protected CyrResult DeclineNounShok()
        {
            string[] shokom = new string[] { "шок", "артишок", "афтершок", "электрошок" };

            if (shokom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounTer()
        {
            string[] trom = new string[] { "ветер", "костёр", "шатёр" };

            if (!trom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounTya()
        {
            string[] tyatey = new string[] { "дитя", "тятя", "полудитя" };
            CyrResult r = new CyrResult();

            r[1] = w;

            if (tyatey.Contains(w))
            {
                r[2] = w + "ти";
                r[3] = w + "ти";
                r[4] = w;
                r[5] = w + "тей";
                r[6] = w + "ти";

                return r;
            }

            if (this.gender == GendersEnum.Feminine)
            {
                return this.DeclineNoun1();
            }

            r[2] = w.ReplaceRegex("я$", "и");
            r[3] = w.ReplaceRegex("я$", "е");
            r[4] = this.IsAnimated ? w.ReplaceRegex("я$", "ю") : w;
            r[5] = w.ReplaceRegex("я$", "ей");
            r[6] = w.ReplaceRegex("я$", "е");

            return r;
        }

        protected CyrResult DeclineNounTov()
        {
            string[] vom = new string[] { "Ардатов", "бакштов", "гитов", "Жостов", "Кстов", "Кшиштов", "найтов", "Нарбутов", "остов", "Реутов", "Саратов", "Фастов", "швартов", "шпринтов" };
            CyrResult r = new CyrResult(w,
                w + "а",
                w + "у",
                this.IsAnimated ? w + "а" : w,
                vom.Contains(w) ? w + "ом" : w + "ым",
                w + "е");

            return r;
        }

        protected CyrResult DeclineNounTok()
        {
            string[] tokom = new string[] { "альпеншток", "Белосток", "Биншток", "биоток", "быстроток", "вагонопоток", "Вайншток", "Владивосток", "водопроток", "водосток", "водоток", "Восток", "гидропоток", "градшток", "грузопоток", "заток", "знаток", "исток", "кровоток", "ливнесток", "отток", "пассажиропоток", "подток", "поток", "приток", "противоток", "проток", "прямоток", "росвосток", "Росток", "сверхток", "северо-восток", "северо-северо-восток", "сток", "теплоприток", "товаропоток", "ток", "флагшток", "фототок", "футшток", "шток", "электроток", "юго-восток" };

            if (tokom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounTos()
        {
            string[] tom = new string[] { "лжехристос", "христос" };

            if (!tom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            CyrResult r = new CyrResult(w,
                w.ReplaceRegex("ос$", "а"),
                w.ReplaceRegex("ос$", "у"),
                w.ReplaceRegex("ос$", "а"),
                w.ReplaceRegex("ос$", "ом"),
                w.ReplaceRegex("ос$", "е"));

            return r;
        }

        protected CyrResult DeclineNounVok()
        {
            string[] vokom = new string[] { "ничевок", "экивок" };

            if (vokom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }

        protected CyrResult DeclineNounYazh()
        {
            string[] zhom = new string[] { "кряж", "ряж", "муляж", "тяж" };

            if (zhom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2Simple(true);
        }

        protected CyrResult DeclineNounZok()
        {
            string[] okom = new string[] { "Абдуразок" };

            if (okom.Contains(w))
            {
                return this.DeclineNoun2Simple();
            }

            return this.DeclineNoun2WithoutSuffix();
        }
    }
}
