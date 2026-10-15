internal class Point
{
    private int _coordinateX;
    private int _coordinateY;

    public Point(int coordinateX, int coordinateY)
    {
        _coordinateX = coordinateX;
        _coordinateY = coordinateY;
    }
    
    public int CoordinateX
    {
        get { return _coordinateX; }
        set { _coordinateX = value; }
    }

    public int CoordinateY
    {
        get { return _coordinateY; }
        set { _coordinateY = value; }
    }
    
    public override string ToString()
    {
        return $"{{{_coordinateX};{_coordinateY}}}";
    }
}
