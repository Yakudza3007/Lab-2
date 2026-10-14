internal class Polygonal
{
    private Point[] points;

    public Polygonal(Point[] points)
    {
        this.points = points;
    }
    
    public Point[] Points
    {
        get { return points; }
        set { this.points = value; }
    }   
    
    public override string ToString()
    {
        return $"Линия [{string.Join(',', Points)}]";
    }
}