using System;

namespace MyLibrary
{
    public class MyLibrary
    {
        public static int F(int x)
        {
            int product = 1;
            while (x != 0)
            {
                int digit = x % 10;
                if (digit % 3 == 0 && digit != 0)
                {
                    product *= digit;
                }
                x /= 10;
            }
            return product;
        }

        public static string IsPrime(int number)
        {
            if (number <= 1)
            {
                return "Составное число";
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return "Составное число";
                }
            }
            return "Простое число";
        }

        public static string NumbertoWords(int number)
        {
            if (number < 1 || number > 999)
            {
                return "Число вне диапазона (1 ≤ n ≤ 999)";
            }

            if (number == 0)
            {
                return "ноль";
            }

            int h, t, o;
            h = number / 100;
            t = (number % 100) / 10;
            o = number % 10;

            string words = "";

            switch (h)
            {
                case 1: words += "сто "; break;
                case 2: words += "двести "; break;
                case 3: words += "триста "; break;
                case 4: words += "четыреста "; break;
                case 5: words += "пятьсот "; break;
                case 6: words += "шестьсот "; break;
                case 7: words += "семьсот "; break;
                case 8: words += "восемьсот "; break;
                case 9: words += "девятьсот "; break;
            }

            switch (t)
            {
                case 1:
                    {
                        switch (o)
                        {
                            case 0: words += "десять"; break;
                            case 1: words += "одиннадцать"; break;
                            case 2: words += "двенадцать"; break;
                            case 3: words += "тринадцать"; break;
                            case 4: words += "четырнадцать"; break;
                            case 5: words += "пятнадцать"; break;
                            case 6: words += "шестнадцать"; break;
                            case 7: words += "семнадцать"; break;
                            case 8: words += "восемнадцать"; break;
                            case 9: words += "девятнадцать"; break;
                        }
                        break;
                    }
                case 2: words += "двадцать "; break;
                case 3: words += "тридцать "; break;
                case 4: words += "сорок "; break;
                case 5: words += "пятьдесят "; break;
                case 6: words += "шестьдесят "; break;
                case 7: words += "семьдесят "; break;
                case 8: words += "восемьдесят "; break;
                case 9: words += "девяносто "; break;
            }

            if (t != 1)
            {
                switch (o)
                {
                    case 1: words += "один"; break;
                    case 2: words += "два"; break;
                    case 3: words += "три"; break;
                    case 4: words += "четыре"; break;
                    case 5: words += "пять"; break;
                    case 6: words += "шесть"; break;
                    case 7: words += "семь"; break;
                    case 8: words += "восемь"; break;
                    case 9: words += "девять"; break;
                }
            }

            return words.Trim();
        }
    }
}
