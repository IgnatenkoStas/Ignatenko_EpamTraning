using System;
using System.IO;
using System.Linq;

namespace Task_1
{
    static class WorkWithFile
    {
        static public void OutputFromFile(out Figure[] figures, string path)
        {
            int difference = 0;
            int counterOfLines = File.ReadAllLines(path).Length;
            Figure[] figuresTemp = new Figure[counterOfLines];

            using (StreamReader fstream = new StreamReader(path))     
            {
                for (int i = 0; i < counterOfLines; i++)
                {
                    bool flag = false;
                    string[] line = fstream.ReadLine().Split('|').ToArray();
                    Figure tmp = MyFactory.GetCertainFigure(line, ref flag, ref difference);

                    if (flag)
                    {
                        figuresTemp[i - difference] = tmp;
                    }
                }
            }

            figures = new Figure[figuresTemp.Length - difference];
            Array.Copy(figuresTemp, 0, figures, 0, figures.Length);
        }

        static public void WriteToFile(Figure[] figures, string path)
        {
            using (StreamWriter stream = new StreamWriter(path, false)) 
            {
                foreach (Figure figure in figures)
                {
                    switch(figure.Name)
                    {
                        case "Square":
                            {
                                Square tmp = (Square)figure;
                                stream.Write(tmp.Name);
                                stream.Write("|");
                                stream.Write(tmp.FirstSide);
                                stream.Write("|");
                                stream.Write(tmp.SecondSide);
                                stream.Write("|");
                                stream.Write(tmp.ThirdSide);
                                stream.Write("|");
                                stream.Write(tmp.FourthSide);
                                stream.Write("\n");
                            }
                            break;
                        case "Triang":
                            {
                                Triangle tmp = (Triangle)figure;
                                stream.Write(tmp.Name);
                                stream.Write("|");
                                stream.Write(tmp.FirstSide);
                                stream.Write("|");
                                stream.Write(tmp.SecondSide);
                                stream.Write("|");
                                stream.Write(tmp.ThirdSide);
                                stream.Write("\n");
                            }
                            break;
                        case "Rectan":
                            {
                                Rectangle tmp = (Rectangle)figure;
                                stream.Write(tmp.Name);
                                stream.Write("|");
                                stream.Write(tmp.FirstSide);
                                stream.Write("|");
                                stream.Write(tmp.SecondSide);
                                stream.Write("|");
                                stream.Write(tmp.ThirdSide);
                                stream.Write("|");
                                stream.Write(tmp.FourthSide);
                                stream.Write("\n");
                            }
                            break;
                    }
                }
            }
        }

    }
}
