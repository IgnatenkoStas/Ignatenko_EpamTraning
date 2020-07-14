using System;

namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            FigureSecond figure = new FigureSecond(); 
            bool flag = false;
            while (!flag)
            {
                Console.Clear();
                try
                {
                    OutputMenu();
                    int select = MakeAChoice();
                    switch (select)
                    {
                        case 0: flag = true; break;
                        case 1:
                            {
                                EuclidFirst.Start();
                            }
                            break;
                        case 2:
                            {
                                figure.Start();
                            } 
                            break;
                        default:
                            {
                                Console.WriteLine("\n\tВы не можете выбрать этот пункт.");
                                PressKey();
                            }
                            break;
                    }
                }
                catch { OutputMessageAboutWrongInput(); }
            }
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

        static void OutputMenu()
        {
            Console.WriteLine("\n\t1.Алгоритмы Евклида для вычисления НОД");
            Console.WriteLine("\t2.Работа с фигурами, загруженными из файла.");
            Console.WriteLine("\n\t0.Закончить работу.");
            Console.Write("\n\n\n\tВаш выбор: ");
        }

        static void PressKey()
        {
            Console.WriteLine("\n\tPress key to continue..");
            Console.ReadKey();
            Console.Clear();
        }

        static void OutputMessageAboutWrongInput()
        {
            Console.WriteLine("\nВы ввели НЕ число! Попробуйте снова.");
            PressKey();
        }
    }
}
