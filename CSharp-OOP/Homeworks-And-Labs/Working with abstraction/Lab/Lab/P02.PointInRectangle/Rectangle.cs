namespace P02.PointInRectangle
{
    public class Rectangle
    {
        private Point topLeft;
        private Point bottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        public bool Contains(Point point)
        {
            if(point.Y <= topLeft.Y && point.Y >= bottomRight.Y && point.X >= topLeft.X && point.X <= bottomRight.X)
            {
                return true;
            }

            return false;
        }
    }
}
