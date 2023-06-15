
namespace OOPExamples
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }


        public static Point operator -(Point a, Point b)
        {
            var xOfResult = a.X - b.X;
            var yOfResult = a.Y - b.Y;
            return new Point()
            {
                X = xOfResult,
                Y = yOfResult
            };
        }

        public static Point operator +(Point a, Point b)
        {
            var xOfResult = a.X + b.X;
            var yOfResult = a.Y + b.Y;
            return new Point()
            {
                X = xOfResult,
                Y = yOfResult
            };
        }

        public static bool operator ==(Point a, Point b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Point a, Point b)
        {
            return a.X != b.X || a.Y != b.Y;
        }

        public static implicit operator Point(int number)
        {
            return new Point()
            {
                X = number,
                Y = number
            };
        }
        public static implicit operator Point(string number)
        {
            return new Point()
            {
               
            };
        }
    }
}
