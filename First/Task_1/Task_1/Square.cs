using System;

namespace Task_1
{
    public class Square : Figure
    {
        private double _fourthSide;

        public double FourthSide
        {
            get { return _fourthSide; }
            set { _fourthSide = value; }
        }

        public Square(string name, double firstSide, double secondSide, double thirdSide, double fourthSide) : base(name, firstSide, secondSide, thirdSide)
        {
            FourthSide = fourthSide;
            Square = CalculateSquare(FirstSide, SecondSide);
            Perimetr = CalculatePerimeter(FirstSide, SecondSide, ThirdSide, FourthSide);
        }


        public double CalculateSquare(double firstSide, double secondSide)
        {
            return firstSide * secondSide;
        }

        public double CalculatePerimeter(double firstSide, double secondSide, double thirdSide, double fourthSide)
        {
            return firstSide + secondSide + thirdSide + fourthSide;
        }

        public override string ToString()
        {
            return $"Название : {Name};\t" +
                $"cторона 1: {FirstSide}см;\t" +
                $"cторона 2: {SecondSide}см;\t" +
                $"cторона 3: {ThirdSide}см;\t" +
                $"cторона 4: {FourthSide}см;\t" +
                $"площадь: {Square}кв.см.;\t" +
                $"периметр: {Perimetr}см.;";
        }

        public override bool Equals(object obj)
        {
            Figure figure = MyFactory.GetCertainFigure(obj);
            return (this.Perimetr == figure.Perimetr);
        }

        public override int GetHashCode()
        {
            return int.Parse(Perimetr.ToString());
        }
    }
}
