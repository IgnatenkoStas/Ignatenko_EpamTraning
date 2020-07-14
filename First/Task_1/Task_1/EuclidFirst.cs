using System;
using System.Diagnostics;

namespace Task_1
{
    public static class EuclidFirst
    {
        public static void Start()
        {
            Console.Clear();
            bool flag = false;
            while (!flag)
            {
                try
                {
                    OutputMenu();
                    int select = MakeAChoice();
                    switch (select)
                    {
                        case 0: flag = true; break;
                        case 1: ChoiceForTwoIntNumbersForBinaryAlg(); break;
                        case 2: ChoiceForTwoIntNumbers(); break;
                        case 3: ChoiceForThreeIntNumbers(); break;
                        case 4: ChoiceForFourIntNumbers(); break;
                        case 5: ChoiceForFiveIntNumbers(); break;
                        case 6: CalculateWaitingTime(); break;
                        default:
                            {
                                Console.WriteLine("Вы не можете выбрать этот пункт.");
                                PressKey();
                            }
                            break;
                    }
                }
                catch { OutputMessageAboutWrongInput(); }
            }
        }

        static void CalculateWaitingTime()
        {
            int a = 12;
            int b = 18;
            Console.WriteLine($"\n\tНаходим НОД {a} и {b} обычным алгоритмом Евклида и бинарным.");
            Euclid(a, b, out Stopwatch swSimple);
            BinEuclid(a, b, out Stopwatch swBin);

            Console.WriteLine($"\n\tВремя, потраченное на нахождение НОДа {a} и {b} обычным алгоритмом Евклида: {swSimple.Elapsed}");
            Console.WriteLine($"\tВремя, потраченное на нахождение НОДа {a} и {b} бинарны алгоритмом Евклида: {swBin.Elapsed}");
            PressKey();
        }

        static void ChoiceForTwoIntNumbers()
        {
            InputData(out int a, out int b);
            Console.WriteLine("\n\tРезультат: " + Euclid(a, b, out Stopwatch sw));
            PressKey();
        }

        static void ChoiceForTwoIntNumbersForBinaryAlg()
        {
            InputData(out int a, out int b);
            Console.WriteLine("\n\tРезультат: " + BinEuclid(a, b, out Stopwatch sw));
            PressKey();
        }

        static void ChoiceForThreeIntNumbers()
        {
            InputData(out int a, out int b, out int c);
            Console.WriteLine("\n\tРезультат: " + Euclid(a, b, c));
            PressKey();
        }

        static void ChoiceForFourIntNumbers()
        {
            InputData(out int a, out int b, out int c, out int d);
            Console.WriteLine("\n\tРезультат: " + Euclid(a, b, c, d));
            PressKey();
        }

        static void ChoiceForFiveIntNumbers()
        {
            InputData(out int a, out int b, out int c, out int d, out int e);
            Console.WriteLine("\n\tРезультат: " + Euclid(a, b, c, d, e));
            PressKey();
        }

        static void PressKey()
        {
            Console.WriteLine("\n\tPress key to continue..");
            Console.ReadKey();
            Console.Clear();
        }

        static int MakeAChoice()
        {
            int select = 0;
            bool flag = false;
            while (!flag)
            {
                select = int.Parse(Console.ReadLine());
                flag = true;
            }

            return select;
        }

        static void InputData(out int a, out int b)
        {
            bool flag = false;
            a = b = 0;
            while (!flag)
            {
                try
                {
                    Console.Write("\n\n\tВведите a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("\tВведите b: ");
                    b = int.Parse(Console.ReadLine());

                    if (a > 0 && b > 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("a и b должны быть ПОЛОЖИТЕЛЬНЫЕ");
                        PressKey();
                    }
                }
                catch { OutputMessageAboutWrongInput(); }
            }

        }

        static void InputData(out int a, out int b, out int c, out int d)
        {
            bool flag = false;
            a = b = c = d = 0;
            while (!flag)
            {
                try
                {
                    Console.Write("\n\n\tВведите a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("\tВведите b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("\tВведите c: ");
                    c = int.Parse(Console.ReadLine());
                    Console.Write("\tВведите d: ");
                    d = int.Parse(Console.ReadLine());

                    if (a > 0 && b > 0 && c > 0 && d > 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("a, b, c, d должны быть ПОЛОЖИТЕЛЬНЫЕ");
                        PressKey();
                    }
                }
                catch { OutputMessageAboutWrongInput(); }
            }

        }

        static void InputData(out int a, out int b, out int c)
        {
            bool flag = false;
            a = b = c = 0;
            while (!flag)
            {
                try
                {
                    Console.Write("\n\n\tВведите a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("\tВведите b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("\tВведите c: ");
                    c = int.Parse(Console.ReadLine());

                    if (a > 0 && b > 0 && c > 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("a, b, c должны быть ПОЛОЖИТЕЛЬНЫЕ");
                        PressKey();
                    }
                }
                catch { OutputMessageAboutWrongInput(); }
            }

        }

        static void InputData(out int a, out int b, out int c, out int d, out int e)
        {
            bool flag = false;
            a = b = c = d = e = 0;
            while (!flag)
            {
                try
                {
                    Console.Write("\n\n\tВведите a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("\tВведите b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("\tВведите c: ");
                    c = int.Parse(Console.ReadLine());
                    Console.Write("\tВведите d: ");
                    d = int.Parse(Console.ReadLine());
                    Console.Write("\tВведите e: ");
                    e = int.Parse(Console.ReadLine());

                    if (a > 0 && b > 0 && c > 0 && d > 0 && e > 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("a, b, c, d, e должны быть ПОЛОЖИТЕЛЬНЫЕ");
                        PressKey();
                    }
                }
                catch { OutputMessageAboutWrongInput(); }
            }

        }

        static void OutputMessageAboutWrongInput()
        {
            Console.WriteLine("\nВы ввели НЕ число! Попробуйте снова.");
            PressKey();
        }

        static void OutputMenu()
        {
            Console.WriteLine("\n\t1.Алгоритм Евклида (бинарный) для вычисления НОД двух целых чисел.");
            Console.WriteLine("\t2.Алгоритм Евклида для вычисления НОД двух целых чисел.");
            Console.WriteLine("\t3.Алгоритм Евклида для вычисления НОД трех целых чисел.");
            Console.WriteLine("\t4.Алгоритм Евклида для вычисления НОД четырех целых чисел.");
            Console.WriteLine("\t5.Алгоритм Евклида для вычисления НОД пяти целых чисел.");
            Console.WriteLine("\t6.Замерить время выполнения методов обычного алгоритма Евклида и бинарного для двух целых чисел.");
            Console.WriteLine("\n\t0.Закончить работу.");
            Console.Write("\n\n\n\tВаш выбор: ");
        }

        public static int Euclid(int a, int b, out Stopwatch sw)
        {
            sw = new Stopwatch();
            int result;

            sw.Start();
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            result = a + b;
            sw.Stop();

            return result;
        }

        public static int Euclid(int a, int b, int c)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                    b %= a;
            }
            int resultFirst = a + b;

            while (resultFirst != 0 && c != 0)
            {
                if (resultFirst > c)
                    resultFirst %= c;
                else
                    c %= resultFirst;
            }
            int resultSecond = resultFirst + c;

            return resultSecond;
        }

        public static int Euclid(int a, int b, int c, int d)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            int resultFirst = a + b;

            while (resultFirst != 0 && c != 0)
            {
                if (resultFirst > c)
                {
                    resultFirst %= c;
                }
                else
                    c %= resultFirst;
            }
            int resultSecond = resultFirst + c;

            while (resultSecond != 0 && d != 0)
            {
                if (resultSecond > d)
                    resultSecond %= d;
                else
                    d %= resultSecond;
            }
            int resultThird = resultSecond + d;

            return resultThird;
        }

        public static int Euclid(int a, int b, int c, int d, int e)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                    b %= a;
            }
            int resultFirst = a + b;

            while (resultFirst != 0 && c != 0)
            {
                if (resultFirst > c)
                {
                    resultFirst %= c;
                }
                else
                    c %= resultFirst;
            }
            int resultSecond = resultFirst + c;

            while (resultSecond != 0 && d != 0)
            {
                if (resultSecond > d)
                {
                    resultSecond %= d;
                }
                else
                    d %= resultSecond;
            }
            int resultThird = resultSecond + d;

            while (resultThird != 0 && e != 0)
            {
                if (resultThird > e)
                {
                    resultThird %= e;
                }
                else
                    e %= resultThird;
            }
            int resultFourth = resultThird + e;

            return resultFourth;
        }

        public static int BinEuclid(int a, int b, out Stopwatch sw)
        {
            sw = new Stopwatch();
            sw.Start();

            // НОД(1, b) = НОД(a, 1) = 1
            if (a == 1 || b == 1)
            {
                sw.Stop();
                return 1;
            }

            // НОД(a, 0) = a
            if (b == 0)
            {
                sw.Stop();
                return a;
            }

            // НОД(0, b) = b
            if (a == 0)
            {
                sw.Stop();
                return b;   
            }

            // НОД(a, a) = a
            if (a == b)
            {
                sw.Stop();
                return a;                         
            }
                     
            if(a % 2 == 0)
            {
                sw.Stop();
                return (b % 2 == 0) ?
                    BinEuclid(a / 2, b / 2, out sw) * 2 : BinEuclid(a / 2, b, out sw);
            }
            else
            {
                sw.Stop();
                return (b % 2 == 0) ? 
                    BinEuclid(a, b / 2, out sw) : BinEuclid(b, Math.Abs(b - a), out sw); 
            }
        }
    }
}
