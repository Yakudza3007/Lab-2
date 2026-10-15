internal class Polygonal
{
    private Point[] _points;

    public Polygonal(Point[] points)
    {
        _points = points;
    }

    public Polygonal()
    {
        _points = new Point[] { };
    }
    
    public Point[] Points
    {
        get { return _points; }
        set { _points = value; }
    }
    
    public void Add(Point[] newPoints)
    {
        Point[] result = new Point[_points.Length + newPoints.Length];
        for (int i = 0; i < _points.Length; i++)
        {
            result[i] = _points[i];
        }
        for (int i = 0; i < newPoints.Length; i++)
        {
            result[_points.Length + i] = newPoints[i];
        }
        _points = result;
    }
    
    public void Add(Point newPoint)
    {
        Add(new Point[] { newPoint });
    }
    
    public double Length()
    {
        double sum = 0;
        for (int i = 0; i < _points.Length - 1; i++)
        {
            int dx = _points[i + 1].CoordinateX - _points[i].CoordinateX;
            int dy = _points[i + 1].CoordinateY - _points[i].CoordinateY;
            sum += Math.Sqrt(dx * dx + dy * dy);
        }
        return sum;
    }
    
    public override string ToString()
    {
        return $"Линия [{string.Join(',', Points)}]";
    }
}