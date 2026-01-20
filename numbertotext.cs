using System;
using System.Text;

namespace codethuanC_
{
    internal class bt
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập vào số có giới hạn 3 đơn vị");
            string a = Console.ReadLine();
            bool b = int.TryParse(a, out int num);
            if (!b)
            {
                Console.WriteLine("Bạn phải nhập số có 3 đơn vị");
            }
            if (num < 0 || num > 999)
            {
                Console.WriteLine("out of ability");
                return;
            }
            if (num <= 10)
                switch (num)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;


                }
            else if (num < 20)
                switch (num)
                {
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eightteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;

                }
            else if (num < 100)
            {
                int tens = num / 10;
                int ones = num % 10;
                string text = "";

                switch (tens)
                {
                    case 2: text = "twenty"; break;
                    case 3: text = "thirty"; break;
                    case 4: text = "forty"; break;
                    case 5: text = "fifty"; break;
                    case 6: text = "sixty"; break;
                    case 7: text = "seventy"; break;
                    case 8: text = "eighty"; break;
                    case 9: text = "ninety"; break;
                }

                if (ones != 0)
                {
                    switch (ones)
                    {
                        case 1: text += " one"; break;
                        case 2: text += " two"; break;
                        case 3: text += " three"; break;
                        case 4: text += " four"; break;
                        case 5: text += " five"; break;
                        case 6: text += " six"; break;
                        case 7: text += " seven"; break;
                        case 8: text += " eight"; break;
                        case 9: text += " nine"; break;
                    }
                }
                Console.WriteLine(text);
            }
            else
            {
                int hundreds = num / 100;
                int rest = num % 100;
                string text = "";

                // đọc hàng trăm
                switch (hundreds)
                {
                    case 1: text = "one hundred"; break;
                    case 2: text = "two hundred"; break;
                    case 3: text = "three hundred"; break;
                    case 4: text = "four hundred"; break;
                    case 5: text = "five hundred"; break;
                    case 6: text = "six hundred"; break;
                    case 7: text = "seven hundred"; break;
                    case 8: text = "eight hundred"; break;
                    case 9: text = "nine hundred"; break;
                }

                if (rest == 0)
                {
                    Console.WriteLine(text);
                }
                else
                {
                    text += " and ";

                    if (rest < 10)
                    {
                        switch (rest)
                        {
                            case 1: text += "one"; break;
                            case 2: text += "two"; break;
                            case 3: text += "three"; break;
                            case 4: text += "four"; break;
                            case 5: text += "five"; break;
                            case 6: text += "six"; break;
                            case 7: text += "seven"; break;
                            case 8: text += "eight"; break;
                            case 9: text += "nine"; break;
                        }
                    }
                    else if (rest < 20)
                    {
                        switch (rest)
                        {
                            case 10: text += "ten"; break;
                            case 11: text += "eleven"; break;
                            case 12: text += "twelve"; break;
                            case 13: text += "thirteen"; break;
                            case 14: text += "fourteen"; break;
                            case 15: text += "fifteen"; break;
                            case 16: text += "sixteen"; break;
                            case 17: text += "seventeen"; break;
                            case 18: text += "eighteen"; break;
                            case 19: text += "nineteen"; break;
                        }
                    }
                    else
                    {
                        int t = rest / 10;
                        int o = rest % 10;

                        switch (t)
                        {
                            case 2: text += "twenty"; break;
                            case 3: text += "thirty"; break;
                            case 4: text += "forty"; break;
                            case 5: text += "fifty"; break;
                            case 6: text += "sixty"; break;
                            case 7: text += "seventy"; break;
                            case 8: text += "eighty"; break;
                            case 9: text += "ninety"; break;
                        }

                        if (o != 0)
                        {
                            switch (o)
                            {
                                case 1: text += " one"; break;
                                case 2: text += " two"; break;
                                case 3: text += " three"; break;
                                case 4: text += " four"; break;
                                case 5: text += " five"; break;
                                case 6: text += " six"; break;
                                case 7: text += " seven"; break;
                                case 8: text += " eight"; break;
                                case 9: text += " nine"; break;
                            }
                        }
                    }

                    Console.WriteLine(text);



                }
            }
        }
    }
}
