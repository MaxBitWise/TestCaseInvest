using System;

namespace MyApp 
{
    internal class Program
    {
        public static Dictionary<string, string> literalNumbersDict = new Dictionary<string, string>()
            {
                { "0", "нол"},
                { "1", "од"},
                { "2", "дв"},
                { "3", "тр"},
                { "4", "четыр"},
                { "5", "пят"},
                { "6", "шест"},
                { "7", "сем"},
                { "8", "восем"},
                { "9", "девят"},
                { "10", "десят"},
                { "11", "одиннадцат"},
                { "12", "двенадцат"},
                { "13", "тринадцат"},
                { "14", "четырнадцат"},
                { "15", "пятнадцат"},
                { "16", "шестнадцат"},
                { "17", "семнадцат"},
                { "18", "воесемнадцат"},
                { "19", "девятнадцат"},
                { "20", "двадцат"},
                { "30", "тридцат"},
                { "40", "сорок"},
                { "50", "пят_десят"},
                { "60", "шест_десят"},
                { "70", "сем_десят"},
                { "80", "вос_десят"},
                { "90", "девяносто"},
                { "100", "сто"},
                { "200", "дв_с"},
                { "300", "тр_с"},
                { "400", "четыр_с"},
                { "500", "пят_с"},
                { "600", "шест_с"},
                { "700", "сем_с"},
                { "800", "вос_с"},
                { "900", "девят_с"},
                { "000", "тысяч"},
                { "000000", "миллион"},
                { "000000000", "миллиард"},
            };
        // число 1
        public static Dictionary<string, string> FirstGroup = new Dictionary<string, string>()
        {
            {"И_М", "ин"},
            {"Р_М", "ного"},
            {"Д_М", "ному"},
            {"В_М", "ин"},
            {"Т_М", "ним"},
            {"П_М", "ном"},

            {"И_Ж", "на"},
            {"Р_Ж", "ной"},
            {"Д_Ж", "ной"},
            {"В_Ж", "ну"},
            {"Т_Ж", "ной"},
            {"П_Ж", "ной"},

            {"И_С", "но"},
            {"Р_С", "ного"},
            {"Д_С", "ному"},
            {"В_С", "но"},
            {"Т_С", "ним"},
            {"П_С", "ном"},
        };

        // число 2
        public static Dictionary<string, string> SecondGroup = new Dictionary<string, string>()
        {
            {"И_М", "а"},
            {"И_Ж", "е"},
            {"Р", "ух"},
            {"Д", "ум"},
            {"В_М", "а"},
            {"В_Ж", "е"},
            {"Т", "умя"},
            {"П", "ух"},
        };
        // число 3
        public static Dictionary<string, string> ThirdGroup = new Dictionary<string, string>()
        {
            {"И", "и"},
            {"Р", "ёх"},
            {"Д", "ём"},
            {"В", "и"},
            {"Т", "емя"},
            {"П", "ёх"},
        };
        // число 4
        public static Dictionary<string, string> FourthGroup = new Dictionary<string, string>()
        {
            {"И", "е"},
            {"Р", "ёх"},
            {"Д", "ём"},
            {"В", "е"},
            {"Т", "ьмя"},
            {"П", "ёх"},
        };
        // числа 5 - 30
        public static Dictionary<string, string> FifthGroup = new Dictionary<string, string>()
        {
            {"И", "ь"},
            {"Р", "и"},
            {"Д", "и"},
            {"В", "ь"},
            {"Т", "ью"},
            {"П", "и"},
        };
        //числа 40 90 100
        public static Dictionary<string, string> FourTeensGroup = new Dictionary<string, string>()
        {
            {"И", ""},
            {"Р", "а"},
            {"Д", "а"},
            {"В", ""},
            {"Т", "а"},
            {"П", "а"},
        };
        //числа 50 60 70
        public static Dictionary<string, string> TenthGroup = new Dictionary<string, string>()
        {
            {"И", "ь_"},
            {"Р", "и_и"},
            {"Д", "и_и"},
            {"В", "ь_"},
            {"Т", "ью_ью"},
            {"П", "и_и"},
        };
        //число 80
        public static Dictionary<string, string> EigthGroup = new Dictionary<string, string>()
        {
            {"И", "емь_"},
            {"Р", "ьми_и"},
            {"Д", "ьми_и"},
            {"В", "емь_"},
            {"Т", "ьмью_ью"},
            {"П", "ьми_и"},
        };
        //число 200
        public static Dictionary<string, string> TwoHundreadGroup = new Dictionary<string, string>()
        {
            {"И", "е_ти"},
            {"Р", "ух_от"},
            {"Д", "ум_там"},
            {"В", "е_ти"},
            {"Т", "умя_тами"},
            {"П", "ух_тах"},
        };
        //число 300
        public static Dictionary<string, string> ThreeHundreadGroup = new Dictionary<string, string>()
        {
            {"И", "и_та"},
            {"Р", "ёх_от"},
            {"Д", "ём_там"},
            {"В", "и_та"},
            {"Т", "емя_тами"},
            {"П", "ёх_тах"},
        };
        //число 400
        public static Dictionary<string, string> FourHundreadGroup = new Dictionary<string, string>()
        {
            {"И", "е_та"},
            {"Р", "ёх_от"},
            {"Д", "ём_там"},
            {"В", "е_та"},
            {"Т", "ьмя_тами"},
            {"П", "ёх_тах"},
        };
        //число 500 600 700 800 900
        public static Dictionary<string, string> HundreadsGroup = new Dictionary<string, string>()
        {
            {"И", "ь_от"},
            {"Р", "и_от"},
            {"Д", "и_там"},
            {"В", "ь_от"},
            {"Т", "ью_тами"},
            {"П", "и_тах"},
        };
        //число 800
        public static Dictionary<string, string> EightHundreadsGroup = new Dictionary<string, string>()
        {
            {"И", "емь_от"},
            {"Р", "ьми_от"},
            {"Д", "ьми_там"},
            {"В", "емь_от"},
            {"Т", "ьмью_тами"},
            {"П", "ьми_тах"},
        };
        //склонение слов миллион миллиард в мн числе
        public static Dictionary<string, string> MillionGroup = new Dictionary<string, string>()
        {
            {"И", "а"},
            {"Р", "ов"},
            {"Д", "ам"},
            {"В", "а"},
            {"Т", "ами"},
            {"П", "ах"},
        };
        //склонение слов миллион миллиард в ед числе
        public static Dictionary<string, string> OneMillionGroup = new Dictionary<string, string>()
        {
            {"И", ""},
            {"Р", "а"},
            {"Д", "у"},
            {"В", ""},
            {"Т", "ом"},
            {"П", "е"},
        };
        //склонение слова тысяча в множественном числе
        public static Dictionary<string, string> ThoushandGroup = new Dictionary<string, string>()
        {
            {"И", "и"},
            {"Р", ""},
            {"Д", "ам"},
            {"В", "и"},
            {"Т", "ами"},
            {"П", "ах"},
        };
        //склонение слова тысяча в единственном числе
        public static Dictionary<string, string> OneThoushandGroup = new Dictionary<string, string>()
        {
            {"И", "а"},
            {"Р", "и"},
            {"Д", "е"},
            {"В", "у"},
            {"Т", "ей"},
            {"П", "е"},
        };
        //склонение слова ноль
        public static Dictionary<string, string> ZeroGroup = new Dictionary<string, string>()
        {
            {"И", "ь"},
            {"Р", "я"},
            {"Д", "ю"},
            {"В", "ь"},
            {"Т", "ем"},
            {"П", "е"},
        };


        //вспомогательная функция для разделения числительного по токенам, которые в основной функции слконяются последовательно 
        public static List<string> NumberSplit(long nSum)
        {
            string strNumber = nSum.ToString();
            int numLength = strNumber.Length;
            var result = new List<String>();

            if (numLength > 3)
            {
                bool isDoubleCharDigit = false;
                for (int i = 0; i < numLength; i++)
                {
                    if (isDoubleCharDigit)
                    {
                        isDoubleCharDigit = false;
                        continue;
                    }
                    int zeroCounts = numLength - (i + 1);
                    if (zeroCounts >= 3)
                    {
                        if (((zeroCounts % 3) == 1) && strNumber[i] == '1')
                        {
                            result.Add(strNumber[i].ToString() + strNumber[i+1].ToString());
                            result.Add(string.Concat(Enumerable.Repeat("0", zeroCounts-1)));
                            isDoubleCharDigit = true;
                        }
                        else
                        {
                            if (strNumber[i] != '0')
                            {
                                string zeroStroke = string.Concat(Enumerable.Repeat("0", zeroCounts % 3));
                                result.Add(strNumber[i] + zeroStroke);
                            }
                            if ((zeroCounts % 3) == 0 && result.Count != 0)
                                if (result.Last()[0] != '0')
                                    result.Add(string.Concat(Enumerable.Repeat("0", zeroCounts)));
                            
                            
                        }
                    }
                    else
                    {
                        if ((zeroCounts == 1) && strNumber[i] == '1')
                        {
                            result.Add(strNumber[i].ToString() + strNumber[i + 1].ToString());
                            isDoubleCharDigit = true;
                        }
                        else
                        {
                            if (strNumber[i] != '0')
                            {
                                string zeroStroke = string.Concat(Enumerable.Repeat("0", zeroCounts));
                                result.Add(strNumber[i] + zeroStroke);
                            }
                        }
                    }

                }
            }
            else
            {
                if (numLength == 1)
                {
                    result.Add(strNumber[0].ToString());
                }
                if(numLength == 2)
                {
                    if (strNumber[0] == '1')
                    {
                        result.Add(strNumber[0].ToString() + strNumber[1].ToString());
                    }
                    else
                    {
                        result.Add(strNumber[0].ToString()+"0");
                        if (strNumber[1] != '0')
                        {
                            result.Add(strNumber[1].ToString());
                        }
                    }
                }
                if(numLength == 3)
                {
                    if (strNumber[1] == '1')
                    {
                        string zeroStroke = string.Concat(Enumerable.Repeat("0", numLength - 1));
                        result.Add(strNumber[0] + zeroStroke);
                        result.Add(strNumber[1].ToString() + strNumber[2].ToString());
                    }
                    else
                    {
                        for (int i = 0; i < numLength; i++)
                        {
                            if (strNumber[i] != '0')
                            {
                                string zeroStroke = string.Concat(Enumerable.Repeat("0", numLength - (i + 1)));
                                result.Add(strNumber[i] + zeroStroke);
                            }
                        }
                    }
                }
            }


            return result;

        }

        //проврека на правильность введённых данных
        public static string CheckInput(long nSum, string sGender, string sCase )
        {
            string[] trueGender = { "М", "Ж", "С" };
            string[] trueCase = { "И", "Р", "Д", "В", "Т", "П" };
            string result = "";
            if (nSum < 0 || nSum > 999_999_999_999)
                result += "Введенно недопустимое число\n";
            if (!trueGender.Contains(sGender))
                result += "Введен недопустимый род\n";
            if (!trueCase.Contains(sCase))
                result += "Введен депустимый падеж\n";
            return result;
        }

        //основная функция для склонения введенного числа
        public static string sumProp(long nSum, string sGender, string sCase)
        {
            string check = CheckInput(nSum, sGender, sCase);
            if (check != "")
            {
                return check;
            }
            else
            {
                string result = "";
                var listNumbers = NumberSplit(nSum);

                for (int i = 0; i < listNumbers.Count; i++)
                {
                    // склонение числа 1
                    if (listNumbers[i] == "1")
                        if (listNumbers.Count - i - 1 > 0)
                        {
                            if (listNumbers[i + 1] == "000")
                                result += literalNumbersDict[listNumbers[i]] + FirstGroup[sCase + "_" + "Ж"] + " ";
                            else if ((listNumbers[i + 1] == "000000") || (listNumbers[i + 1] == "000000000"))
                                result += literalNumbersDict[listNumbers[i]] + FirstGroup[sCase + "_" + "М"] + " ";
                        }
                        else
                            result += literalNumbersDict[listNumbers[i]] + FirstGroup[sCase + "_" + sGender] + " ";

                    // склонение числа 2 
                    if (listNumbers[i] == "2")
                        if ((sCase == "И" || sCase == "В"))
                        {
                            if (listNumbers.Count - i - 1 > 0)
                            {
                                if (listNumbers[i + 1] == "000")
                                {
                                    result += literalNumbersDict[listNumbers[i]] + SecondGroup[sCase + "_" + "Ж"] + " ";
                                }
                                else if ((listNumbers[i + 1] == "000000") || (listNumbers[i + 1] == "000000000"))
                                {
                                    result += literalNumbersDict[listNumbers[i]] + SecondGroup[sCase + "_" + "М"] + " ";
                                }
                            }
                            else if (sGender == "М" || sGender == "Ж")
                            {
                                result += literalNumbersDict[listNumbers[i]] + SecondGroup[sCase + "_" + sGender] + " ";
                            }

                        }
                        else
                            result += literalNumbersDict[listNumbers[i]] + SecondGroup[sCase] + " ";

                    // склонение числа 3
                    if (listNumbers[i] == "3")
                        result += literalNumbersDict[listNumbers[i]] + ThirdGroup[sCase] + " ";

                    // склонение числа 4
                    if (listNumbers[i] == "4")
                        result += literalNumbersDict[listNumbers[i]] + FourthGroup[sCase] + " ";

                    // склонение чисел от 5 до 30
                    if ((int.Parse(listNumbers[i]) >= 5) && (int.Parse(listNumbers[i]) <= 30))
                        result += literalNumbersDict[listNumbers[i]] + FifthGroup[sCase] + " ";

                    // склонение числа 40
                    if (listNumbers[i] == "40")
                        result += literalNumbersDict[listNumbers[i]] + FourTeensGroup[sCase] + " ";

                    // склонение чисел 90 и 100
                    if (listNumbers[i] == "90" || listNumbers[i] == "100")
                        if (sCase != "И" && sCase != "В")
                            result += literalNumbersDict[listNumbers[i]].Substring(0, 
                                literalNumbersDict[listNumbers[i]].Length - 1) + FourTeensGroup[sCase] + " ";
                        else
                            result += literalNumbersDict[listNumbers[i]] + " ";

                    // склонение чисел 50 60 70 80
                    if ((int.Parse(listNumbers[i]) >= 50) && (int.Parse(listNumbers[i]) <= 80))
                    {
                        if (listNumbers[i] == "80")
                        {
                            var numberSplited = literalNumbersDict[listNumbers[i]].Split("_");
                            var endingSplited = EigthGroup[sCase].Split("_");
                            result += numberSplited[0] + endingSplited[0] + numberSplited[1] + endingSplited[1] + " ";
                        }
                        else
                        {
                            var numberSplited = literalNumbersDict[listNumbers[i]].Split("_");
                            var endingSplited = TenthGroup[sCase].Split("_");
                            result += numberSplited[0] + endingSplited[0] + numberSplited[1] + endingSplited[1] + " ";
                        }

                    }

                    //склонение числа 200
                    if (listNumbers[i] == "200")
                    {
                        var numberSplited = literalNumbersDict[listNumbers[i]].Split("_");
                        var endingSplited = TwoHundreadGroup[sCase].Split("_");
                        result += numberSplited[0] + endingSplited[0] + numberSplited[1] + endingSplited[1] + " ";
                    }

                    // склонение числа 300
                    if (listNumbers[i] == "300")
                    {
                        var numberSplited = literalNumbersDict[listNumbers[i]].Split("_");
                        var endingSplited = ThreeHundreadGroup[sCase].Split("_");
                        result += numberSplited[0] + endingSplited[0] + numberSplited[1] + endingSplited[1] + " ";
                    }

                    //склонение числа 400
                    if (listNumbers[i] == "400")
                    {
                        var numberSplited = literalNumbersDict[listNumbers[i]].Split("_");
                        var endingSplited = FourHundreadGroup[sCase].Split("_");
                        result += numberSplited[0] + endingSplited[0] + numberSplited[1] + endingSplited[1] + " ";
                    }

                    //склонение чисел 500 600 700 800 900
                    if ((int.Parse(listNumbers[i]) >= 500) && (int.Parse(listNumbers[i]) <= 900))
                    {
                        if (listNumbers[i] == "800")
                        {
                            var numberSplited = literalNumbersDict[listNumbers[i]].Split("_");
                            var endingSplited = EightHundreadsGroup[sCase].Split("_");
                            result += numberSplited[0] + endingSplited[0] + numberSplited[1] + endingSplited[1] + " ";
                        }
                        else
                        {
                            var numberSplited = literalNumbersDict[listNumbers[i]].Split("_");
                            var endingSplited = HundreadsGroup[sCase].Split("_");
                            result += numberSplited[0] + endingSplited[0] + numberSplited[1] + endingSplited[1] + " ";
                        }
                    }

                    // склонение слов миллион миллиард
                    if (listNumbers[i] == "000000" || listNumbers[i] == "000000000")
                        if (listNumbers[i - 1] == "1")
                            result += literalNumbersDict[listNumbers[i]] + OneMillionGroup[sCase] + " ";
                        else if ((listNumbers[i - 1][listNumbers[i - 1].Length-1] == '0') &&
                                 (sCase == "И" || sCase == "В"))
                            result += literalNumbersDict[listNumbers[i]] + MillionGroup["Р"] + " ";
                        else
                            result += literalNumbersDict[listNumbers[i]] + MillionGroup[sCase] + " ";

                    // склонение слова тысяча
                    if (listNumbers[i] == "000")
                        if (listNumbers[i - 1] == "1")
                            result += literalNumbersDict[listNumbers[i]] + OneThoushandGroup[sCase] + " ";
                        else if ((listNumbers[i - 1][listNumbers[i - 1].Length - 1] == '0') &&
                                  (sCase == "И" || sCase == "В"))
                            result += literalNumbersDict[listNumbers[i]] + ThoushandGroup["Р"] + " ";
                        else
                            result += literalNumbersDict[listNumbers[i]] + ThoushandGroup[sCase] + " ";

                    // склонение числа 0
                    if (listNumbers[i] == "0")
                        result += literalNumbersDict[listNumbers[i]] + ZeroGroup[sCase] + " ";
                }

                return result;
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(sumProp(1_911_900_956_112, "F", "T"));
            Console.WriteLine(sumProp(0, "М", "Т"));
            Console.WriteLine(sumProp(-1, "G", "U"));
            Console.WriteLine(sumProp(-1, "М", "R"));

            Console.WriteLine(sumProp(987654432343, "М", "Т"));
            Console.WriteLine(sumProp(31, "М", "Р"));
            Console.WriteLine(sumProp(31, "Ж", "Р"));
            Console.WriteLine(sumProp(31, "С", "Р"));
            Console.WriteLine(sumProp(22, "М", "И"));
            Console.WriteLine(sumProp(22, "Ж", "И"));
            Console.WriteLine(sumProp(154323, "М", "И"));
            Console.WriteLine(sumProp(151323, "М", "И"));
            Console.WriteLine(sumProp(221152321, "С", "Д"));
            Console.WriteLine(sumProp(221152321, "С", "И"));
            Console.WriteLine(sumProp(103, "М", "И"));
            Console.WriteLine(sumProp(911_900_956_112, "М", "Д"));
            Console.WriteLine(sumProp(100_000_000_000, "М", "Д"));

            Console.WriteLine(sumProp(80, "М", "Р"));
            Console.WriteLine(sumProp(180310, "Ж", "И"));
            Console.WriteLine(sumProp(800, "С", "И"));
            Console.WriteLine(sumProp(800, "С", "Р"));
            Console.WriteLine(sumProp(800, "М", "И"));
            Console.WriteLine(sumProp(800, "Ж", "Т"));
            Console.WriteLine(sumProp(1000, "С", "И"));
            Console.WriteLine(sumProp(900_100_200_500, "Ж", "П"));
        }
    }
}