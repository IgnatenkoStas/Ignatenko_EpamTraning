using System;

namespace Task_1
{
    public class Triangle : Figure
    {
        public Triangle(string name, double firstSide, double secondSide, double thirdSide) : base(name, firstSide, secondSide, thirdSide)
        {
            Square = CalculateSquare(FirstSide, SecondSide, ThirdSide);
            Perimetr = CalculatePerimeter(FirstSide, SecondSide, ThirdSide);
        }

        public double CalculateSquare(double firstSide, double secondSide, double thirdSide)
        {
            double p = (firstSide + secondSide + thirdSide) / 2;
            double h = (2 * Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide))) / firstSide;
            return (firstSide * h) / 2;
        }

        public double CalculatePerimeter(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide + secondSide + thirdSide;
        }

        public override bool Equals(object obj)
        {
            Figure figure = MyFactory.GetCertainFigure(obj);
            return (this.Perimetr == figure.Perimetr);
        }

        public override string ToString()
        {
            return $"Название : {Name};\t" +
                $"cторона 1: {FirstSide}см;\t" +
                $"cторона 2: {SecondSide}см;\t" +
                $"cторона 3: {ThirdSide}см;\t" +
                $"площадь: {Square}кв.см.;\t" +
                $"периметр: {Perimetr}см.;";
        }

        public override int GetHashCode()
        {
            return int.Parse(Perimetr.ToString());
        }
    }
}
