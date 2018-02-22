namespace newDll
{
    public abstract class Shape
    {
        public double X { get; set; }

        public double Y { get; set; }

        public string Color { get; set; }

        public Shape(double x, double y, string color)
        {
            X = x;
            Y = y;
            Color = color;

        }

        public virtual string Print()
        {
            return $"Position on the X axis is: {X}\nPosition on the Y axis is: {Y}\nThe Color is: {Color}\n";
        }


        public abstract double CalcSpace();
        public abstract double CalcScope();



    }
}
