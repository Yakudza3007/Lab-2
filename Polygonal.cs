internal class Polygonal
{
    private Point[] points;

    public Polygonal(Point[] points)
    {
        this.points = points;
    }

    public Polygonal()
    {
        this.points = new Point[] { };
    }
    
    public Point[] Points
    {
        get { return points; }
        set { this.points = value; }
    }
    
    public void Add(Point[] newPoints)
    {
        Point[] result = new Point[points.Length + newPoints.Length];
        for (int i = 0; i < points.Length; i++)
        {
            result[i] = points[i];
        }
        for (int i = 0; i < newPoints.Length; i++)
        {
            result[points.Length + i] = newPoints[i];
        }
        points = result;
    }
    
    public void Add(Point newPoint)
    {
        Add(new Point[] { newPoint });
    }
    
    public double Length()
    {
        double sum = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            int dx = points[i + 1].CoordinateX - points[i].CoordinateX;
            int dy = points[i + 1].CoordinateY - points[i].CoordinateY;
            sum += Math.Sqrt(dx * dx + dy * dy);
        }
        return sum;
    }
    
    public override string ToString()
    {
        return $"Линия [{string.Join(',', Points)}]";
    }
}