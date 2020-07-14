using System;
using System.Linq;

namespace Task_1
{
    class FigureSecond
    {
        private readonly string _path = "Figures.txt";
        private Figure[] _figures;
        public void Start()
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
                        case 1:
                            {
                                WorkWithFile.OutputFromFile(out _figures, _path);
                                Console.WriteLine($"\n\tДанные успешно выгружены в массив из {_path}");
                            }; break;
                        case 2:
                            {
                                WorkWithFile.WriteToFile(_figures, _path);
                                Console.WriteLine($"\n\tДанные успешно сохранены в {_path}");
                            }; break;
                        case 3:
                            {
                                if (_figures != null)
                                {
                                    OutputArray(_figures);
                                }
                                else
                                {
                                    Console.WriteLine("\n\tКоллекция фигур пуста :(");
                                }
                            }; break;
                        case 4:
                            {
                                FindFiguresWithEqualPerimetr(out Figure[] figures);
                                OutputArray(figures);
                            }; break;
                        default:
                            {
                                Console.WriteLine("\n\tВы не можете выбрать этот пункт.");
                            }
                            break;
                    }
                    PressKey();
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

        public void FindFiguresWithEqualPerimetr(out Figure[] resultFigures)
        {
            OutputArray(this._figures);
            Console.Write("\n\tВыберите индекс интересующей вас фигуры: ");
            int selectedIndex = MakeAChoice();
            resultFigures = new Figure[2];
            if(selectedIndex < _figures.Length && selectedIndex >= 0)
            {
                Figure figure = _figures[selectedIndex];
                resultFigures = _figures.Where(p => p.Equals(figure)).ToArray();
            }
            else
            {
                Console.WriteLine("\n\tВы не можете выбрать несуществующую фигуру.");
                PressKey();
            }
        }
        
        public void OutputMessageAboutWrongInput()
        {
            Console.WriteLine("\nВы ввели НЕ число! Попробуйте снова.");
            PressKey();
        }

        public void PressKey()
        {
            Console.WriteLine("\n\tPress key to continue..");
            Console.ReadKey();
            Console.Clear();
        }

        public void OutputMenu()
        {
            Console.WriteLine($"\n\t1.Выгрузить данные из {_path}.");
            Console.WriteLine($"\t2.Сохранить данные в {_path}.");
            Console.WriteLine("\t3.Просмотреть все фигуры.");
            Console.WriteLine("\t4.Найти в массиве все фигуры, равные данной.");
            Console.WriteLine("\n\t0.Закончить работу.");
            Console.Write("\n\n\tВаш выбор: ");
        }

        public void OutputArray(Figure[] figures)
        {
            int index = 0;
            Console.WriteLine("\n\n\tКоллекция фигур:\n");
            foreach (Figure figure in figures)
            {
                Console.WriteLine(index + ". " + figure.ToString());
                index++;
            }
        }
    }
}
