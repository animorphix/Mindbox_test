namespace MindBoxLibrary
{
    public class Circle: IShape
    {
        private double _radius;
        public Circle(double radius)
        {
            this._radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}