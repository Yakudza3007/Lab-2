internal class Point
{
    private int _coordinateX;
    private int _coordinateY;

    public Point(int coordinateX, int coordinateY)
    {
        this._coordinateX = coordinateX;
        this._coordinateY = coordinateY;
    }
    
    public int CoordinateX
    {
        get { return _coordinateX; }
        set { this._coordinateX = value; }
    }

    public int CoordinateY
    {
        get { return this._coordinateY; }
        set { this._coordinateY = value; }
    }
    
    public override string ToString()
    {
        return $"{{{_coordinateX};{_coordinateY}}}";
    }
}
