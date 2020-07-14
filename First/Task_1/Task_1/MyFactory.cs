using System;

namespace Task_1
{
    static class MyFactory
    {
        static public Figure GetCertainFigure(string[] line, ref bool flag, ref int difference)
        {
            Figure figure = null;
            switch (line[0])
            {
                case "Square":
                    {
                        figure = new Square(line[0], double.Parse(line[1]), double.Parse(line[2]), double.Parse(line[3]), double.Parse(line[4]));
                        flag = true;
                    }
                    break;
                case "Triang":
                    {
                        figure = new Triangle(line[0], double.Parse(line[1]), double.Parse(line[2]), double.Parse(line[3]));
                        flag = true;
                    }
                    break;
                case "Rectan":
                    {
                        figure = new Rectangle(line[0], double.Parse(line[1]), double.Parse(line[2]), double.Parse(line[3]), double.Parse(line[4]));
                        flag = true;
                    }
                    break;
                default:
                    {
                        difference++;
                    }
                    break;
            }

            return figure;
        }

        static public Figure GetCertainFigure(object obj)
        {
            Figure figure = null;
            Type type = obj.GetType();

            switch (type.Name)
            {
                case "Square":
                    {
                        figure = (Square)obj;
                    }
                    break;
                case "Rectan":
                    {
                        figure = (Rectangle)obj;
                    }
                    break;
                case "Triang":
                    {
                        figure = (Triangle)obj;
                    }
                    break;
            }
            return figure;
        }
    }
}
