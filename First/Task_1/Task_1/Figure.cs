namespace Task_1
{
    public class Figure
    {
        private string _name;
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;
        private double _square;
        private double _perimetr;

        public double FirstSide
        {
            get { return _firstSide; }
            set { _firstSide = value; }
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double SecondSide
        {
            get { return _secondSide; }
            set { _secondSide = value; }
        }
        
        public double ThirdSide
        {
            get { return _thirdSide; }
            set { _thirdSide = value; }
        }

        public double Square
        {
            get { return _square; }
            set { _square = value; }
        }

        public double Perimetr
        {
            get { return _perimetr; }
            set { _perimetr = value; }
        }
        
        
        public Figure(string name, double firstSide, double secondSide, double thirdSide)
        {
            Name = name;
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
    }
}
